using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Objects;

namespace BLL
{
    public class Class_usuario
    {
        public int ingresousuario(string no, string te, string us, string co)
        {
            ObjectParameter respuesta = new ObjectParameter("rsp", typeof(int));//crear la variable q resivira el valor que devuelva el procedimiento almacenado
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.IngresoUsuario(no, te, us, co, respuesta);
            int rSP = Int16.Parse(respuesta.Value.ToString());
            return rSP;
        }

        public object listausuarios()
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = from usu in db.usuario
                       where usu.estado_usuario == true
                       select new { usu.id_usuario, usu.nombre_empleado, usu.nombre_usuario };
            return temp.ToList();
        }

        public string[] datosusuario(int id)
        {
            string[] r= new string[4];
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from usu in db.usuario
                        where usu.id_usuario == id
                        select new { usu.nombre_empleado, usu.telefono_empleado, usu.nombre_usuario, usu.pass_usuario }).First();
            r[0] = temp.nombre_empleado;
            r[1] = temp.telefono_empleado;
            r[2] = temp.nombre_usuario;
            r[3] = temp.pass_usuario;
            
            return r;
        }

        public void editarusuario(int id, string no, string te, string co)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from usu in db.usuario
                        where usu.id_usuario == id
                        select usu).First();
            temp.nombre_empleado = no;
            temp.telefono_empleado = te;
            temp.pass_usuario = co;

            db.SaveChanges();
        }

        public void eliminarusuario(int id)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from usu in db.usuario
                        where usu.id_usuario == id
                        select usu).First();
            temp.estado_usuario = false;
            db.SaveChanges();
        }


        public void historialingreso(string us)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.HistorialIngreso(us);
        }
    }
}
