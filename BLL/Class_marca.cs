using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Objects;

namespace BLL
{
    public class Class_marca
    {
        public object listamarcasactivas()
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = from ma in db.marca
                       where ma.estado_marca == true
                       select new { ma.id_marca, ma.nombre_marca };
            return temp.ToList();
        }

        public int ingresomarca(string no)
        {
            ObjectParameter respuesta = new ObjectParameter("rsp", typeof(int));//crear la variable q resivira el valor que devuelva el procedimiento almacenado
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.ingresomarca(no, respuesta);

            int rSP = Int16.Parse(respuesta.Value.ToString());
            return rSP;
        }

        public string datosmarca(int id)
        {
            string rs = null;
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = from ma in db.marca
                       where ma.id_marca == id
                       select new { ma.nombre_marca };
            
            if(temp.Count()>0)
                rs = temp.ToList()[0].nombre_marca;

            return rs;
        }

        public void editarmarca(int id, string no)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();

            var temp = (from ma in db.marca
                        where ma.id_marca == id
                        select ma).First();
            temp.nombre_marca = no;
            db.SaveChanges();
        }

        public void eliminarmarca(int id)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();

            var temp = (from ma in db.marca
                        where ma.id_marca == id
                        select ma).First();
            temp.estado_marca = false;
            db.SaveChanges();
        }
    }
}
