using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Objects;

namespace BLL
{
    public class Class_cliente
    {
        public object ListaClientesActivos()
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = from cli in db.cliente
                        where cli.estado_cliente == true
                        select new { cli.id_cliente, cli.nombre_cliente, cli.nit_cliente, cli.telefono_cliente };
            return temp.ToList();
        }

        public int ingresocliente(string no, string ni, string di, string te, string co, DateTime fe)
        {
            ObjectParameter respuesta = new ObjectParameter("rsp", typeof(int));//crear la variable q resivira el valor que devuelva el procedimiento almacenado
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.IngresoCliente(no, ni, di, te, co, fe, respuesta);
            int rSP = Int16.Parse(respuesta.Value.ToString());
            return rSP;
        }

        public string[] datoscliente(int id)
        {
            string[] dt = new string[6];

            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = from cli in db.cliente
                        where cli.id_cliente==id
                        select cli;

            if (temp.Count() > 0)
            {
                dt[0] = temp.ToList()[0].nombre_cliente;
                dt[1] = temp.ToList()[0].nit_cliente;
                dt[2] = temp.ToList()[0].direccion_cliente;
                dt[3] = temp.ToList()[0].telefono_cliente;
                dt[4] = temp.ToList()[0].correo_cliente;
                dt[5] = temp.ToList()[0].fecha_nacimiento_cliente.ToString();
            }
            else
                dt = null;

            return dt;
        }

        public void editarcliente(int id, string no, string ni, string di, string te, string co, DateTime fe)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from cli in db.cliente
                        where cli.id_cliente == id
                        select cli).First();
            temp.nombre_cliente = no;
            temp.nit_cliente = ni;
            temp.direccion_cliente = di;
            temp.telefono_cliente = te;
            temp.correo_cliente = co;
            temp.fecha_nacimiento_cliente = fe;

            db.SaveChanges();
        }

        public void eliminarcliente(int id)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from cli in db.cliente
                        where cli.id_cliente == id
                        select cli).First();
            temp.estado_cliente = false;
            db.SaveChanges();
        }


        public string nitclienteporid(int idcli)
        {
            string r = "";
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from cli in db.cliente
                        where cli.id_cliente == idcli
                        select new { cli.nit_cliente }).First();
            r = temp.nit_cliente.ToString();
            return r;
        }

        public int ultimocliente()
        {
            int r = 0;
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from cli in db.cliente
                        orderby cli.id_cliente descending
                        select new { cli.id_cliente }).First();
            r = temp.id_cliente;
            return r;
        }
    }
}
