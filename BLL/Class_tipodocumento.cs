using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Class_tipodocumento
    {
        public object listatipodocumento()
        {
            mastertech_db1Entities db = new mastertech_db1Entities();

            var temp = from ti in db.tipo_documento
                       where ti.estado_tipo_documento == true
                       select new { ti.id_tipo_documento, ti.descripcion_tipo_documento };
            return temp.ToList();
        }
    }
}
