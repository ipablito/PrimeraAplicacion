using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL;

namespace UI
{
    public partial class F_usuarioRol : Form
    {
        public F_usuarioRol()
        {
            InitializeComponent();
        }

        void limpiarcheckbox()
        {
            int c = dataGridView_roles.Rows.Count;
            for (int i = 0; i < c; i++)
            {
                dataGridView_roles.Rows[i].Cells[0].Value = false;
            }
        }

        public void asignar()
        {
            Class_usuario lg = new Class_usuario();
            lookUpEdit_usuario.Properties.DisplayMember = "nombre_usuario";
            lookUpEdit_usuario.Properties.ValueMember = "id_usuario";
            lookUpEdit_usuario.Refresh();
            lookUpEdit_usuario.Properties.DataSource = lg.listausuarios();

            Class_rol lgr = new Class_rol();
            dataGridView_roles.DataSource = lgr.listaroles();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void simpleButton_guardar_Click(object sender, EventArgs e)
        {
            if (lookUpEdit_usuario.Text != "[Vacío]")
            {
                int idUs = Convert.ToInt16(lookUpEdit_usuario.EditValue);
                Class_usuarios_roles lg = new Class_usuarios_roles();

                int cont = dataGridView_roles.Rows.Count;
                lg.EliminarRoles(idUs);

                for (int i = 0; i < cont; i++)
                {
                    if(Convert.ToBoolean(dataGridView_roles.Rows[i].Cells[0].Value)==true)
                        lg.AsignarRolesAUsuario(idUs, Convert.ToInt16(dataGridView_roles.Rows[i].Cells[1].Value));
                }

                ////limpiar datagrid sin error
                //DataTable DT = (DataTable)dataGridView_roles.DataSource;
                //if (DT != null)
                //    DT.Clear();

                this.Hide();
            }
            else
                MessageBox.Show("Seleccione un usuario para asignar roles", "Roles de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lookUpEdit_usuario_TextChanged(object sender, EventArgs e)
        {
            limpiarcheckbox();
            int idUs=Convert.ToInt16(lookUpEdit_usuario.EditValue);
            DataSet1TableAdapters.usuario_rolTableAdapter lg = new DataSet1TableAdapters.usuario_rolTableAdapter();
            DataTable Res = lg.GetData_listarolesusuario(idUs);

            int conRes = Res.Rows.Count;//este es el contador de los roles devueltos por la funcion
            int conDat = dataGridView_roles.Rows.Count;//este contador es del datagridview donde estan los roles activos

            for (int i = 0; i < conRes; i++)
            {
                for (int ii = 0; ii < conDat; ii++)
                {
                    string idRolRes=Res.Rows[i][1].ToString();
                    string idRolDat=dataGridView_roles.Rows[ii].Cells[1].Value.ToString();
                    if (idRolRes == idRolDat)
                    {
                        dataGridView_roles.Rows[ii].Cells[0].Value = Convert.ToBoolean(Res.Rows[i][0]);
                    }
                }
            }

            
        }
    }
}
