using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Objects;

namespace BLL
{
    public class Class_proveedor
    {
        public int ingresoproveedor(string ni, string de, string te, string te2, string di, string co)
        {
            ObjectParameter respuesta = new ObjectParameter("rsp", typeof(int));//crear la variable q resivira el valor que devuelva el procedimiento almacenado
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.IngresoProveedor(ni, de, te, te2, di, co, respuesta);
            int rSP = Int16.Parse(respuesta.Value.ToString());
            return rSP;
        }

        //lista de los proveedores activos
        public object listaproveedores()
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = from pro in db.proveedor
                       where pro.estado_proveedor == true
                       select new { pro.id_proveedor, pro.nit_proveedor, pro.descripcion_proveedor };

            return temp.ToList();
        }

        public string[] datosproveedor(int id)
        {
            string[] r = new string[6];
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from pro in db.proveedor
                        where pro.id_proveedor == id
                        select pro).First();
            r[0] = temp.nit_proveedor;
            r[1] = temp.descripcion_proveedor;
            r[2] = temp.telefono_proveedor;
            r[3] = temp.telefono2_proveedor;
            r[4] = temp.direccion_proveedor;
            r[5] = temp.correo_proveedor;
            return r;
        }

        public void editarproveedor(int id, string ni, string de, string te, string te2, string di, string co)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from pro in db.proveedor
                        where pro.id_proveedor == id
                        select pro).First();
            temp.nit_proveedor = ni;
            temp.descripcion_proveedor = de;
            temp.telefono_proveedor = te;
            temp.telefono2_proveedor = te2;
            temp.direccion_proveedor = di;
            temp.correo_proveedor = co;
            db.SaveChanges();
        }

        public void eliminarproveedor(int id)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from pro in db.proveedor
                        where pro.id_proveedor == id
                        select pro).First();
            temp.estado_proveedor = false;
            db.SaveChanges();
        }

        public string nitbuscadoporid(int idpro)
        {
            string r = "";
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from pro in db.proveedor
                        where pro.id_proveedor == idpro
                        select new { pro.nit_proveedor }).First();
            r = temp.nit_proveedor;
            return r;
        }

        public int idproveedorporsunitydescripcion(string nit, string desc)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from pro in db.proveedor
                        where pro.nit_proveedor == nit && pro.descripcion_proveedor == desc
                        select new { pro.id_proveedor }).First();
            int rsp = temp.id_proveedor;
            return rsp;
        }
    }
}
