using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Objects;

namespace BLL
{
    public class Class_rol
    {
        public int ingresorol(string no)
        {
            ObjectParameter respuesta = new ObjectParameter("rsp", typeof(int));//crear la variable q resivira el valor que devuelva el procedimiento almacenado
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.NuevoRol(no, respuesta);
            int rSP = Int16.Parse(respuesta.Value.ToString());
            return rSP;
        }

        public object listaroles()
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = from ro in db.rol
                       where ro.estado_rol == true
                       orderby ro.id_rol descending
                       select new { ro.id_rol, ro.nombre_rol };
            return temp.ToList();
        }

        public string datosrol(int id)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from ro in db.rol
                        where ro.id_rol == id
                        select new { ro.nombre_rol }).First();
            return temp.nombre_rol;
        }

        public void editarrol(int id, string no)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from ro in db.rol
                        where ro.id_rol == id
                        select ro).First();
            temp.nombre_rol = no;
            db.SaveChanges();
        }

        public void eliminarrol(int id)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from ro in db.rol
                        where ro.id_rol == id
                        select ro).First();
            temp.estado_rol = false;
            db.SaveChanges();
        }
    }
}
