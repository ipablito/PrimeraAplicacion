using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Objects;

namespace BLL
{
    public class Class_factura
    {
        public int encabezdofactura(int idus,int idse, int idcli, DateTime fecha, double total, string referencia)
        {
            ObjectParameter respuesta = new ObjectParameter("NoFactura", typeof(int));//crear la variable q resivira el valor que devuelva el procedimiento almacenado
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.EncabezadoFactura(idus, idse, idcli, fecha, total, referencia, respuesta);
            int rSP = Int16.Parse(respuesta.Value.ToString());
            return rSP;
        }

        public void detallefactura(int iden, double preu, int cant, double subtot, int idbo, int idpro)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.detallefactura(iden, preu, cant, subtot, idbo, idpro);
        }
    }


}
