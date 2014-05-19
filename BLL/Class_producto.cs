using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Objects;

namespace BLL
{
    public class Class_producto
    {
        public int ingresoproducto(string de, string co, double por, int idma)
        {
            ObjectParameter respuesta = new ObjectParameter("rsp", typeof(int));//crear la variable q resivira el valor que devuelva el procedimiento almacenado
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.IngresoProducto(de, co, por, idma, respuesta);
            int rSP = Int16.Parse(respuesta.Value.ToString());
            return rSP;
        }

        public object listaproductos()
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = from pro in db.producto
                       join ma in db.marca
                       on pro.id_marca equals ma.id_marca

                       where pro.estado_producto == true
                       select new { pro.id_producto, pro.descripcion_producto, ma.nombre_marca };
            return temp.ToList();
        }

        public string[] datosproducto(int id)
        {
            string[] r = new string[4];
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from pro in db.producto
                        join ma in db.marca
                        on pro.id_marca equals ma.id_marca
                        where pro.id_producto == id
                        select new { pro.descripcion_producto, pro.codigo_producto, pro.porcentaje_producto, ma.nombre_marca }).First();
            r[0] = temp.descripcion_producto;
            r[1] = temp.codigo_producto;
            r[2] = temp.porcentaje_producto.ToString();
            r[3] = temp.nombre_marca;
            return r;
        }

        public void editarproducto(int id, string de, double por, int idma)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from pro in db.producto
                        where pro.id_producto == id
                        select pro).First();
            temp.descripcion_producto = de;
            temp.porcentaje_producto = por;
            temp.id_marca = idma;
            db.SaveChanges();
        }

        public void eliminarproducto(int id)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from pro in db.producto
                        where pro.id_producto == id
                        select pro).First();
            temp.estado_producto = false;
            db.SaveChanges();
        }


        public string[] preciosproducto(int id)
        {
            string[] r = new string[2];
            mastertech_db1Entities db = new mastertech_db1Entities();

            var temp = (from pro in db.producto
                        where pro.id_producto == id
                        select new { pro.ultimo_precio_compra_producto, pro.ultimo_precio_venta_producto }).First();
            r[0] = temp.ultimo_precio_compra_producto.ToString();
            r[1] = temp.ultimo_precio_venta_producto.ToString();
            return r;
        }

        public void editarprecioventa(int id,double pv)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from pro in db.producto
                        where pro.id_producto == id
                        select pro).First();
            temp.ultimo_precio_venta_producto = pv;
            db.SaveChanges();
        }


        public string[] datosproductoporidparacompra(int idprod)
        {
            string[] r = new string[3];
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from prod in db.producto
                        where prod.id_producto == idprod
                        select new { prod.codigo_producto, prod.descripcion_producto, prod.ultimo_precio_compra_producto }).First();
            r[0] = temp.codigo_producto;
            r[1] = temp.descripcion_producto;
            r[2] = temp.ultimo_precio_compra_producto.ToString();

            return r;
        }

        public int iddeproductobuscadoporsucodigo(string codprod)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from pro in db.producto
                        where pro.codigo_producto == codprod
                        select new { pro.id_producto }).First();
            int rsp = temp.id_producto;
            return rsp;
        }

        public string[] datosproductoporidparaventa(int idprod, int idbo)
        {
            string[] r = new string[5];
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = from prod in db.producto
                        join prodbod in db.producto_bodega
                        on prod.id_producto equals prodbod.id_producto

                       where prod.id_producto == idprod && prodbod.id_bodega == idbo
                        select new {prod.codigo_producto,
                            prod.descripcion_producto,
                            prod.ultimo_precio_compra_producto,
                            prod.ultimo_precio_venta_producto,
                            prodbod.existencia_producto_bodega};

            if (temp.Count() > 0)
            {

                r[0] = temp.ToList()[0].codigo_producto;
                r[1] = temp.ToList()[0].descripcion_producto;
                r[2] = temp.ToList()[0].ultimo_precio_compra_producto.ToString();
                r[3] = temp.ToList()[0].ultimo_precio_venta_producto.ToString();
                r[4] = temp.ToList()[0].existencia_producto_bodega.ToString();
            }
            else
            {
                r = null;
            }
            return r;
        }
    }
}
