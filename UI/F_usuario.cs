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
    public partial class F_usuario : Form
    {
        public F_usuario()
        {
            InitializeComponent();
        }

        //mantener el id para editar i eliminar
        int t_idus = 0;

        void limpiartextos()
        {
            textEdit_contexto.Text = "";
            textEdit_nombre.Text = "";
            textEdit_telefono.Text = "";
            textEdit_usuario.Text = "";
            textBox_contra.Text = "";
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
            if ((textEdit_nombre.Text != "") && (textEdit_usuario.Text != "") && (textBox_contra.Text != ""))
            {
                Class_usuario lg = new Class_usuario();
                int r = lg.ingresousuario(textEdit_nombre.Text, textEdit_telefono.Text, textEdit_usuario.Text, textBox_contra.Text);
                if (r == 1)
                    this.Hide();
                else
                    MessageBox.Show("Este usuario ya existe", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Los campos de NOMBRE, USUARIO y CONTRASEÑA son obligatorios", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textEdit_contexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarusuario();
                nf.ShowDialog();
                textEdit_contexto.Text = Variables.contexto;
            }
        }

        private void simpleButton_buscar_Click(object sender, EventArgs e)
        {
            if ((textEdit_contexto.Text != "") && (Variables.encontrado == true))
            {
                string[] t = new string[4];
                Class_usuario lg = new Class_usuario();
                t = lg.datosusuario(Variables.indice);
                if (t != null)
                {
                    groupBox_datos.Visible = true;
                    textEdit_nombre.Text = t[0];
                    textEdit_telefono.Text = t[1];
                    textEdit_usuario.Text = t[2];
                    textBox_contra.Text = t[3];

                    t_idus = Variables.indice;
                    Variables.resetearvariables();
                    textEdit_contexto.Text = "";
                }

                else
                    MessageBox.Show("Esta bodega no existe", "Bodega", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Porfavor busque la bodega, presionando ENTER en el campo BODEGA", "Bodega", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void simpleButton_editar_Click(object sender, EventArgs e)
        {
            Class_usuario lg = new Class_usuario();
            lg.editarusuario(t_idus, textEdit_nombre.Text, textEdit_telefono.Text, textBox_contra.Text);
            this.Hide();
        }

        private void simpleButton_eliminar_Click(object sender, EventArgs e)
        {
            Class_usuario lg = new Class_usuario();
            lg.eliminarusuario(t_idus);
            this.Hide();
        }
    }
}
