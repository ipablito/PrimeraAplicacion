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
    public partial class F_loggin : Form
    {
        public F_loggin()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.logginTableAdapter lg = new DataSet1TableAdapters.logginTableAdapter();
            
            res = lg.GetData_listapermisos(textEdit_usuario.Text,textBox_contra.Text);

            F_menu fc = new F_menu();

            int per = res.Rows.Count;

            if (per == 0)
            {
                MessageBox.Show("El usuario y la contraseña no coinciden", "Loggin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_contra.Text = "";
                textBox_contra.Focus();
            }
            else
            {
                for (int i = 0; i < per; i++)
                {
                    string nomper = res.Rows[i][1].ToString();
                    bool estper = Convert.ToBoolean(res.Rows[i][0]);
                    fc.FuncionMostrarOcultar(nomper, estper);
                }

                
                Class_usuario lg1 = new Class_usuario();
                lg1.historialingreso(textEdit_usuario.Text);

                fc.Show();
                this.Hide();
            }
        }
    }
}
