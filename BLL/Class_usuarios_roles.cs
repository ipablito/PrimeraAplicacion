using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Class_usuarios_roles
    {
        public void EliminarRoles(int idus)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.EliminarRolesDeUsuario(idus);
        }

        public void AsignarRolesAUsuario(int idus, int idro)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.AsignarRolAUsuario(idus, idro);
        }
    }
}
