using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Objects;

namespace BLL
{
    public class Class_compra
    {
        public int encabezadocompra(int idus,int idse,int idpro,DateTime fecha,double total,string refe)
        {
            ObjectParameter respuesta = new ObjectParameter("NoCompra", typeof(int));//crear la variable q resivira el valor que devuelva el procedimiento almacenado
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.EncabezadoCompra(idus, idse, idpro, fecha, total, refe, respuesta);
            int rSP = Int16.Parse(respuesta.Value.ToString());
            return rSP;
        }

        public void detallecompra(int iden, double preU, int cant, double subtot, int idbo, int idpro)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.detallecompra(iden, preU, cant, subtot, idbo, idpro);
        }


        
    }
}
