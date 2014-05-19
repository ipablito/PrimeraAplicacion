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
    public partial class F_rol : Form
    {
        public F_rol()
        {
            InitializeComponent();
        }

        int t_idrol = 0;

        void limpiartextos()
        {
            textEdit_contexto.Text = "";
            textEdit_nombre.Text = "";
        }

        public void guardar()
        {
            groupBox_buscar.Visible = false;
            groupBox_datos.Visible = true;

            simpleButton_guardar.Visible = true;
            simpleButton_editar.Visible = false;
            simpleButton_eliminar.Visible = false;
            limpiartextos();
        }

        public void editar()
        {
            groupBox_buscar.Visible = true;
            groupBox_datos.Visible = false;

            simpleButton_guardar.Visible = false;
            simpleButton_editar.Visible = true;
            simpleButton_eliminar.Visible = false;
            limpiartextos();
        }

        public void eliminar()
        {
            groupBox_buscar.Visible = true;
            groupBox_datos.Visible = false;

            simpleButton_guardar.Visible = false;
            simpleButton_editar.Visible = false;
            simpleButton_eliminar.Visible = true;
            limpiartextos();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void simpleButton_guardar_Click(object sender, EventArgs e)
        {
            if (textEdit_nombre.Text != "")
            {
                Class_rol lg = new Class_rol();
                int r = lg.ingresorol(textEdit_nombre.Text);
                if (r == 1)
                    this.Hide();
                else
                    MessageBox.Show("Este rol ya existe", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("El campo NOMBRE DEL ROL es obligatorio", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textEdit_contexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarrol();
                nf.ShowDialog();

                textEdit_contexto.Text = Variables.contexto;
            }
        }

        private void simpleButton_buscar_Click(object sender, EventArgs e)
        {
            if ((textEdit_contexto.Text != "") && (Variables.encontrado == true))
            {
                string t = "";
                Class_rol lg = new Class_rol();
                t = lg.datosrol(Variables.indice);
                if (t != null)
                {
                    groupBox_datos.Visible = true;
                    textEdit_nombre.Text = t;
                    t_idrol = Variables.indice;
                    Variables.resetearvariables();
                    textEdit_contexto.Text = "";
                }

                else
                    MessageBox.Show("Esta rol no existe", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Porfavor busque el rol, presionando ENTER en el campo ROL", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void simpleButton_editar_Click(object sender, EventArgs e)
        {
            Class_rol lg = new Class_rol();
            lg.editarrol(t_idrol, textEdit_nombre.Text);
            this.Hide();
        }

        private void simpleButton_eliminar_Click(object sender, EventArgs e)
        {
            Class_rol lg = new Class_rol();
            lg.eliminarrol(t_idrol);
            this.Hide();
        }
    }
}
