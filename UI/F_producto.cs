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
    public partial class F_producto : Form
    {
        public F_producto()
        {
            InitializeComponent();
        }

        //variable para mantener id
        int t_idpro = 0;

        void limpiartextos()
        {
            textEdit_contexto.Text = "";
            textEdit_descripcion.Text = "";
            textEdit_codigo.Text = "";
            textEdit_porcentaje.Text = "";
        }


        void cargarmarcas()
        {
            Class_marca lg = new Class_marca();
            lookUpEdit_marca.Properties.DisplayMember = "nombre_marca";
            lookUpEdit_marca.Properties.ValueMember = "id_marca";
            lookUpEdit_marca.Refresh();
            lookUpEdit_marca.Properties.DataSource = lg.listamarcasactivas();
        }

        public void guardar()
        {
            groupBox_buscar.Visible = false;
            groupBox_datos.Visible = true;

            simpleButton_guardar.Visible = true;
            simpleButton_editar.Visible = false;
            simpleButton_eliminar.Visible = false;

            limpiartextos();
            cargarmarcas();
        }

        public void editar()
        {
            groupBox_buscar.Visible = true;
            groupBox_datos.Visible = false;

            simpleButton_guardar.Visible = false;
            simpleButton_editar.Visible = true;
            simpleButton_eliminar.Visible = false;

            limpiartextos();
            cargarmarcas();
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
            if ((textEdit_descripcion.Text != "") && (textEdit_codigo.Text != "") && (lookUpEdit_marca.Text != "[Vacío]") && (textEdit_porcentaje.Text != ""))
            {
                Class_producto lg = new Class_producto();
                int r = lg.ingresoproducto(textEdit_descripcion.Text, textEdit_codigo.Text, Convert.ToDouble(textEdit_porcentaje.Text), Convert.ToInt16(lookUpEdit_marca.EditValue));
                if (r == 1)
                    this.Hide();
                else
                    MessageBox.Show("Es probable que este producto ya exista, verifique porfavor", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Los campos de DESCRIPCION, CODIGO DE PRODUCTO, PORCENTAJE DE GANANCIA y MARCA son obligatorios", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textEdit_contexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarproducto();
                nf.ShowDialog();
                textEdit_contexto.Text = Variables.contexto;
            }
        }

        private void simpleButton_buscar_Click(object sender, EventArgs e)
        {
            if ((textEdit_contexto.Text != "") && (Variables.encontrado == true))
            {
                string[] t = new string[4];
                Class_producto lg = new Class_producto();
                t = lg.datosproducto(Variables.indice);
                if (t != null)
                {
                    groupBox_datos.Visible = true;
                    textEdit_descripcion.Text = t[0];
                    textEdit_codigo.Text = t[1];
                    textEdit_porcentaje.Text = t[2];
                    lookUpEdit_marca.Text = t[3];
                    t_idpro = Variables.indice;
                    Variables.resetearvariables();
                    textEdit_contexto.Text = "";
                }

                else
                    MessageBox.Show("Este producto no existe", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Porfavor busque el producto, presionando ENTER en el campo PRODUCTO", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void simpleButton_editar_Click(object sender, EventArgs e)
        {
            Class_producto lg = new Class_producto();
            lg.editarproducto(t_idpro, textEdit_descripcion.Text, Convert.ToDouble(textEdit_porcentaje.Text), Convert.ToInt16(lookUpEdit_marca.EditValue));
            this.Hide();
        }

        private void simpleButton_eliminar_Click(object sender, EventArgs e)
        {
            Class_producto lg = new Class_producto();
            lg.eliminarproducto(t_idpro);
            this.Hide();
        }
    }
}
