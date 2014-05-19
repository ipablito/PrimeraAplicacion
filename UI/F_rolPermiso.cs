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
    public partial class F_rolPermiso : Form
    {
        public F_rolPermiso()
        {
            InitializeComponent();
        }

        public void asignar()
        {
            //cargar los roles activos
            Class_rol lg = new Class_rol();
            lookUpEdit_rol.Properties.DisplayMember = "nombre_rol";
            lookUpEdit_rol.Properties.ValueMember = "id_rol";
            lookUpEdit_rol.Refresh();
            lookUpEdit_rol.Properties.DataSource = lg.listaroles();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lookUpEdit_rol_TextChanged(object sender, EventArgs e)
        {
            DataSet1TableAdapters.PermisosRolTableAdapter lg = new DataSet1TableAdapters.PermisosRolTableAdapter();
            DataTable res = lg.GetData_listapermisosrol(Convert.ToInt16(lookUpEdit_rol.EditValue));
            dataGridView_permisos.DataSource = res;
        }

        private void dataGridView_permisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView_permisos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                //MessageBox.Show("Error");
            }
        }

        private void simpleButton_guardar_Click(object sender, EventArgs e)
        {
            if (lookUpEdit_rol.Text != "[Vacío]")
            {
                int idRol = Convert.ToInt16(lookUpEdit_rol.EditValue);
                Class_permiso lg = new Class_permiso();
                int cont = dataGridView_permisos.Rows.Count;

                for (int i = 0; i < cont; i++)
                {
                    lg.editarpermisosrol(idRol, Convert.ToInt16(dataGridView_permisos.Rows[i].Cells[0].Value), Convert.ToSByte(dataGridView_permisos.Rows[i].Cells[2].Value));
                }

                //limpiar datagrid sin error
                DataTable DT = (DataTable)dataGridView_permisos.DataSource;
                if (DT != null)
                    DT.Clear();

                this.Hide();
            }
            else
                MessageBox.Show("Seleccione un rol para asignar permisos", "Permisos de roles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
