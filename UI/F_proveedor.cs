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
    public partial class F_proveedor : Form
    {
        public F_proveedor()
        {
            InitializeComponent();
        }

        int t_id = 0;
        void limpiartextos()
        {
            textEdit_nit.Text = "";
            textEdit_descripcion.Text = "";
            textEdit_telefono.Text = "";
            textEdit_telefono2.Text = "";
            textEdit_direccion.Text = "";
            textEdit_correo.Text = "";
        }

        public void guardar()
        {
            groupBox_datosproveedor.Visible = true;
            groupBox_buscar.Visible = false;
            simpleButton_guardar.Visible = true;
            simpleButton_editar.Visible = false;
            simpleButton_eliminar.Visible = false;
            limpiartextos();
        }

        public void editar()
        {
            groupBox_datosproveedor.Visible = false;
            groupBox_buscar.Visible = true;
            simpleButton_guardar.Visible = false;
            simpleButton_editar.Visible = true;
            simpleButton_eliminar.Visible = false;
            limpiartextos();
        }

        public void eliminar()
        {
            groupBox_datosproveedor.Visible = false;
            groupBox_buscar.Visible = true;
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
            if ((textEdit_nit.Text != "")&&(textEdit_descripcion.Text!=""))
            {
                Class_proveedor lg = new Class_proveedor();
                int r = lg.ingresoproveedor(textEdit_nit.Text, textEdit_descripcion.Text, textEdit_telefono.Text, textEdit_telefono2.Text, textEdit_direccion.Text, textEdit_correo.Text);
                if (r == 1)
                    this.Hide();
                else
                    MessageBox.Show("Este proveedor ya existe", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Los campos de NIT y DESCRIPCION son obligatorios", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textEdit_contexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarproveedor();
                nf.ShowDialog();
                textEdit_contexto.Text = Variables.contexto;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if ((textEdit_contexto.Text != "") && (Variables.encontrado == true))
            {
                string[] t = new string[6];
                Class_proveedor lg = new Class_proveedor();
                t = lg.datosproveedor(Variables.indice);
                if (t != null)
                {
                    groupBox_datosproveedor.Visible = true;
                    textEdit_nit.Text = t[0];
                    textEdit_descripcion.Text = t[1];
                    textEdit_telefono.Text = t[2];
                    textEdit_telefono2.Text = t[3];
                    textEdit_direccion.Text = t[4];
                    textEdit_correo.Text = t[5];

                    t_id = Variables.indice;
                    Variables.resetearvariables();
                    textEdit_contexto.Text = "";
                }

                else
                    MessageBox.Show("Este proveedor no existe", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Porfavor busque el proveedor, presionando ENTER en el campo PROVEEDOR", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void simpleButton_editar_Click(object sender, EventArgs e)
        {
            Class_proveedor lg = new Class_proveedor();
            lg.editarproveedor(t_id, textEdit_nit.Text, textEdit_descripcion.Text, textEdit_telefono.Text, textEdit_telefono2.Text, textEdit_direccion.Text, textEdit_correo.Text);
            this.Hide();
        }

        private void simpleButton_eliminar_Click(object sender, EventArgs e)
        {
            Class_proveedor lg = new Class_proveedor();
            lg.eliminarproveedor(t_id);
            this.Hide();
        }
    }
}
