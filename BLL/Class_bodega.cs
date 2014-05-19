using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Objects;

namespace BLL
{
    public class Class_bodega
    {
        public int ingresobodega(string de, string di, string te, string te2)
        {
            ObjectParameter respuesta = new ObjectParameter("rsp", typeof(int));//crear la variable q resivira el valor que devuelva el procedimiento almacenado
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.IngresoBodega(de, di, te, te2, respuesta);
            int rSP = Int16.Parse(respuesta.Value.ToString());
            return rSP;
        }

        public object listabodega()
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = from bo in db.bodega
                       where bo.estado_bodega == true
                       select new { bo.id_bodega, bo.descripcion_bodega, bo.direccion_bodega };
            return temp.ToList();
        }

        public string[] datosbodega(int id)
        {
            string[] r = new string[4];
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from bo in db.bodega
                        where bo.id_bodega == id
                        select bo).First();
            r[0] = temp.descripcion_bodega;
            r[1] = temp.direccion_bodega;
            r[2] = temp.telefono_bodega;
            r[3] = temp.telefono2_bodega;
            
            return r;
        }

        public void editarbodega(int id, string de, string di, string te, string te2)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from bo in db.bodega
                        where bo.id_bodega == id
                        select bo).First();

            temp.descripcion_bodega = de;
            temp.direccion_bodega = di;
            temp.telefono_bodega = te;
            temp.telefono2_bodega = te2;

            db.SaveChanges();
        }

        public void eliminarbodega(int id)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from bo in db.bodega
                        where bo.id_bodega == id
                        select bo).First();
            temp.estado_bodega = false;
            db.SaveChanges();
        }
    }
}
