using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Class_permiso
    {
        //asignar permisos a los roles
        public void editarpermisosrol(int idrol, int idper,SByte est)
        {
            mastertech_db1Entities db = new mastertech_db1Entities();
            db.EditarPermisoRol(idrol, idper, est);
        }
    }
}
