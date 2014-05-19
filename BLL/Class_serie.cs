using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Objects;

namespace BLL
{
    public class Class_serie
    {
        public int ingresoserie(string de, int idti)
        {
            ObjectParameter respuesta = new ObjectParameter("rsp", typeof(int));//crear la variable q resivira el valor que devuelva el procedimiento almacenado
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.IngresoSerieDocumento(de, idti, respuesta);
            int rSP = Int16.Parse(respuesta.Value.ToString());
            return rSP;
        }

        public object listaseries()
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = from se in db.serie_documento
                       join ti in db.tipo_documento
                       on se.id_tipo_documento equals ti.id_tipo_documento
                       where ti.estado_tipo_documento == true && se.id_estado_documento == 1
                       select new { se.id_serie_documento, se.descripcion_serie_documento, ti.descripcion_tipo_documento };
            return temp.ToList();
        }

        public string[] datosserie(int id)
        {
            string[] r = new string[2];

            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from se in db.serie_documento
                        join ti in db.tipo_documento
                        on se.id_tipo_documento equals ti.id_tipo_documento

                        where se.id_serie_documento == id

                        select new { se.descripcion_serie_documento, ti.descripcion_tipo_documento }).First();
            r[0] = temp.descripcion_serie_documento;
            r[1] = temp.descripcion_tipo_documento;
            return r;
        }

        public void editarserie(int id, string de)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from se in db.serie_documento
                        where se.id_serie_documento == id
                        select se).First();
            temp.descripcion_serie_documento = de;
            db.SaveChanges();
        }

        public void eliminarserie(int id)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = (from se in db.serie_documento
                        where se.id_serie_documento == id
                        select se).First();
            temp.id_estado_documento = 2;
            db.SaveChanges();
        }

        public object listaseriescompras()
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = from se in db.serie_documento
                       join ti in db.tipo_documento
                       on se.id_tipo_documento equals ti.id_tipo_documento
                       where ti.estado_tipo_documento == true && se.id_estado_documento == 1 && ti.descripcion_tipo_documento=="Compra"
                       select new { se.id_serie_documento, se.descripcion_serie_documento};
            return temp.ToList();
        }


        public object listaseriesfacturas()
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            var temp = from se in db.serie_documento
                       join ti in db.tipo_documento
                       on se.id_tipo_documento equals ti.id_tipo_documento
                       where ti.estado_tipo_documento == true && se.id_estado_documento == 1 && ti.descripcion_tipo_documento == "Factura"
                       select new { se.id_serie_documento, se.descripcion_serie_documento };
            return temp.ToList();
        }

    }
}
