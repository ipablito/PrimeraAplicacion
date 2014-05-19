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
    public partial class F_serie : Form
    {
        public F_serie()
        {
            InitializeComponent();
        }

        int t_idse = 0;//para guardar el id de la serie buscada
        void cargartiposdocumento()
        {
            Class_tipodocumento lg = new Class_tipodocumento();
            lookUpEdit_tipodocumento.Properties.DisplayMember = "descripcion_tipo_documento";
            lookUpEdit_tipodocumento.Properties.ValueMember = "id_tipo_documento";
            lookUpEdit_tipodocumento.Refresh();
            lookUpEdit_tipodocumento.Properties.DataSource = lg.listatipodocumento();
        }

        void limpiartextos()
        {
            textEdit_contexto.Text = "";
            textEdit_descripcion.Text = "";
        }

        public void guardar()
        {
            groupBox_buscar.Visible = false;
            groupBox_datos.Visible = true;
            simpleButton_guardar.Visible = true;
            simpleButton_editar.Visible = false;
            simpleButton_eliminar.Visible = false;
            limpiartextos();
            cargartiposdocumento();
        }

        public void editar()
        {
            groupBox_buscar.Visible = true;
            groupBox_datos.Visible = false;
            simpleButton_guardar.Visible = false;
            simpleButton_editar.Visible = true;
            simpleButton_eliminar.Visible = false;
            limpiartextos();
            cargartiposdocumento();
        }

        public void eliminar()
        {
            groupBox_buscar.Visible = true;
            groupBox_datos.Visible = false;
            simpleButton_guardar.Visible = false;
            simpleButton_editar.Visible = false;
            simpleButton_eliminar.Visible = true;
            limpiartextos();
            cargartiposdocumento();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void simpleButton_guardar_Click(object sender, EventArgs e)
        {
            if ((textEdit_descripcion.Text != "") && (lookUpEdit_tipodocumento.Text != "[Vacío]"))
            {
                Class_serie lg = new Class_serie();
                int r = lg.ingresoserie(textEdit_descripcion.Text, Convert.ToInt16(lookUpEdit_tipodocumento.EditValue));
                if (r == 1)
                    this.Hide();
                else
                    MessageBox.Show("Esta serie ya existe", "Serie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Los campos de DESCRIPCION y TIPO DE DOCUMENTO son obligatorios", "Serie", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textEdit_contexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarserie();
                nf.ShowDialog();
                textEdit_contexto.Text = Variables.contexto;
            }
        }

        private void simpleButton_buscar_Click(object sender, EventArgs e)
        {
            if ((textEdit_contexto.Text != "") && (Variables.encontrado == true))
            {
                string[] t = new string[6];
                Class_serie lg = new Class_serie();
                t = lg.datosserie(Variables.indice);
                if (t != null)
                {
                    groupBox_datos.Visible = true;
                    textEdit_descripcion.Text = t[0];
                    lookUpEdit_tipodocumento.Text = t[1];
                    t_idse = Variables.indice;
                    Variables.resetearvariables();
                    textEdit_contexto.Text = "";
                }

                else
                    MessageBox.Show("Esta serie no existe", "Serie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Porfavor busque la serie, presionando ENTER en el campo SERIE", "Serie", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void simpleButton_editar_Click(object sender, EventArgs e)
        {
            Class_serie lg = new Class_serie();
            lg.editarserie(t_idse, textEdit_descripcion.Text);
            this.Hide();
        }

        private void simpleButton_eliminar_Click(object sender, EventArgs e)
        {
            Class_serie lg = new Class_serie();
            lg.eliminarserie(t_idse);
            this.Hide();
        }
    }
}
