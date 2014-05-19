using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Objects;

namespace BLL
{
    public class Class_contacto
    {
        public int ingresocontacto(string no, string te, string di, int idpro)
        {
            ObjectParameter respuesta = new ObjectParameter("rsp", typeof(int));//crear la variable q resivira el valor que devuelva el procedimiento almacenado
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.IngresoContacto(no, te, di, idpro, respuesta);

            int rSP = Int16.Parse(respuesta.Value.ToString());
            return rSP;
        }

        public object listacontactosactivos()
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = from con in db.contacto
                       join pro in db.proveedor
                       on con.id_proveedor equals pro.id_proveedor
                       where con.estado_contacto == true && pro.estado_proveedor == true
                       select new { con.id_contacto, con.nombre_contacto, pro.descripcion_proveedor };
            
            return temp.ToList();
        }

        public string[] datoscontacto(int id)
        {
            string[] r = new string[4];
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from con in db.contacto
                        join pro in db.proveedor
                        on con.id_proveedor equals pro.id_proveedor
                        where con.id_contacto == id
                        select new { con.nombre_contacto, con.telefono_contacto, con.direccion_contacto, pro.descripcion_proveedor }).First();

            r[0]=temp.nombre_contacto;
            r[1]=temp.telefono_contacto;
            r[2]=temp.direccion_contacto;
            r[3]=temp.descripcion_proveedor;

            return r;
        }

        public void editarcontacto(int id, string no, string te, string di, int idpro)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from co in db.contacto
                        where co.id_contacto == id
                        select co).First();
            temp.nombre_contacto = no;
            temp.telefono_contacto = te;
            temp.direccion_contacto = di;
            temp.id_proveedor = idpro;
            db.SaveChanges();
        }

        public void eliminarcontacto(int id)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            
            var temp = (from co in db.contacto
                        where co.id_contacto == id
                        select co).First();
            temp.estado_contacto = false;
            db.SaveChanges();
        }
    }
}
