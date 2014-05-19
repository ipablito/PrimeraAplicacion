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
    public partial class F_marca : Form
    {
        public F_marca()
        {
            InitializeComponent();
        }


        int n_idma = 0;//id de la marca mientras se edita o elimina

        public void guardar()
        {
            groupBox_Datos.Visible = true;
            groupBox_buscar.Visible = false;

            simpleButton_guardar.Visible = true;
            simpleButton_editar.Visible = false;
            simpleButton_eliminar.Visible = false;

            textEdit_nombre.Text = "";
        }

        public void editar()
        {
            groupBox_Datos.Visible = false;
            groupBox_buscar.Visible = true;

            simpleButton_guardar.Visible = false;
            simpleButton_editar.Visible = true;
            simpleButton_eliminar.Visible = false;

            textEdit_nombre.Text = "";
        }

        public void eliminar()
        {
            groupBox_Datos.Visible = false;
            groupBox_buscar.Visible = true;

            simpleButton_guardar.Visible = false;
            simpleButton_editar.Visible = false;
            simpleButton_eliminar.Visible = true;

            textEdit_nombre.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void simpleButton_cargar_Click(object sender, EventArgs e)
        {
            if ((textEdit_contexto.Text!="")&&(Variables.encontrado==true))
            {
                Class_marca lg = new Class_marca();
                textEdit_nombre.Text = lg.datosmarca(Variables.indice);
                if (textEdit_nombre.Text != "")
                {
                    groupBox_Datos.Visible = true;
                    n_idma = Variables.indice;
                    Variables.resetearvariables();
                    textEdit_contexto.Text = "";
                }
                else
                    MessageBox.Show("Esta marca no existe", "Marca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Busque la marca, presionando ENTER en el campo MARCA", "Marca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textEdit_contexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarmarca();
                nf.ShowDialog();

                textEdit_contexto.Text = Variables.contexto;
            }
        }

        private void simpleButton_guardar_Click(object sender, EventArgs e)
        {
            if (textEdit_nombre.Text != "")
            {
                Class_marca lg = new Class_marca();
                int r = lg.ingresomarca(textEdit_nombre.Text);
                if (r == 1)
                    this.Hide();
                else
                    MessageBox.Show("Esta marca ya existe", "Marca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton_editar_Click(object sender, EventArgs e)
        {
            Class_marca lg = new Class_marca();
            lg.editarmarca(n_idma, textEdit_nombre.Text);
            this.Hide();
        }

        private void simpleButton_eliminar_Click(object sender, EventArgs e)
        {
            Class_marca lg = new Class_marca();
            lg.eliminarmarca(n_idma);
            this.Hide();
        }
    }
}
