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
    public partial class F_bodega : Form
    {
        public F_bodega()
        {
            InitializeComponent();
        }


        //variable para el id de la bodega
        int t_idbo = 0;

        void limpiartextos()
        {
            textEdit_contexto.Text = "";
            textEdit_descripcion.Text = "";
            textEdit_direccion.Text = "";
            textEdit_telefono.Text = "";
            textEdit_telefono2.Text = "";
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
            if ((textEdit_descripcion.Text != "") && (textEdit_direccion.Text != ""))
            {
                Class_bodega lg = new Class_bodega();
                int r = lg.ingresobodega(textEdit_descripcion.Text, textEdit_direccion.Text, textEdit_telefono.Text, textEdit_telefono2.Text);
                if (r == 1)
                    this.Hide();
                else
                    MessageBox.Show("Esta bodega ya existe", "Bodega", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Los campos de DESCRIPCION y DIRECCION son obligatorios", "Bodega", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textEdit_contexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarbodega();
                nf.ShowDialog();

                textEdit_contexto.Text = Variables.contexto;
            }
        }

        private void simpleButton_buscar_Click(object sender, EventArgs e)
        {
            if ((textEdit_contexto.Text!= "") && (Variables.encontrado == true))
            {
                string[] t = new string[6];
                Class_bodega lg = new Class_bodega();
                t = lg.datosbodega(Variables.indice);
                if (t != null)
                {
                    groupBox_datos.Visible = true;
                    textEdit_descripcion.Text = t[0];
                    textEdit_direccion.Text = t[1];
                    textEdit_telefono.Text = t[2];
                    textEdit_telefono2.Text = t[3];
                    t_idbo = Variables.indice;
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
            Class_bodega lg = new Class_bodega();
            lg.editarbodega(t_idbo, textEdit_descripcion.Text, textEdit_direccion.Text, textEdit_telefono.Text, textEdit_telefono2.Text);
            this.Hide();
        }

        private void simpleButton_eliminar_Click(object sender, EventArgs e)
        {
            Class_bodega lg = new Class_bodega();
            lg.eliminarbodega(t_idbo);
            this.Hide();
        }
    }
}
