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
    public partial class F_modificarprecioproducto : Form
    {
        public F_modificarprecioproducto()
        {
            InitializeComponent();
        }

        public void nuevoprecio()
        {
            textEdit_contexto.Text = "";
            groupBox_precios.Visible = false;
            labelControl_compra.Text = "0.00";
            labelControl_precioventa.Text = "0.00";
            textEdit_nPrecio.Text = "0.00";
            simpleButton_guardar.Enabled = false;
        }

        //variable para mantener el id del producto
        int t_idpro = 0;

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            if (textEdit_nPrecio.Text != "")
            {
                if (Convert.ToDouble(textEdit_nPrecio.Text) > Convert.ToDouble(labelControl_compra.Text))
                    simpleButton_guardar.Enabled = true;
                else
                    simpleButton_guardar.Enabled = false;
            }
            else
                simpleButton_guardar.Enabled = false;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Class_producto lg = new Class_producto();
            lg.editarprecioventa(t_idpro, Convert.ToDouble(textEdit_nPrecio.Text));
            this.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void simpleButton_buscar_Click(object sender, EventArgs e)
        {
            if ((textEdit_contexto.Text != "") && (Variables.encontrado == true))
            {
                string[] t = new string[4];
                Class_producto lg = new Class_producto();
                t = lg.preciosproducto(Variables.indice);
                if (t != null)
                {
                    groupBox_precios.Visible = true;
                    labelControl_compra.Text = t[0];
                    labelControl_precioventa.Text = t[1];
                    
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

        private void labelControl_precioventa_TextChanged(object sender, EventArgs e)
        {
            textEdit_nPrecio.Text = labelControl_precioventa.Text;
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
    }
}
