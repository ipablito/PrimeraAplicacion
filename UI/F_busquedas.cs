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
    public partial class F_busquedas : Form
    {
        public F_busquedas()
        {
            InitializeComponent();
        }

        public void listaproductosenbodega()
        {
            groupBox_productoenbodega.Visible = true;
            groupBox_historialcomprasaproveedor.Visible = false;
            groupBox_contactosdeunproveedor.Visible = false;
            groupBox_historialexistencia.Visible = false;
            groupBox_historialprecioproducto.Visible = false;
            groupBox_facturasauncliente.Visible = false;
            groupBox_comprapornumero.Visible = false;
            groupBox_comprasentrefechas.Visible = false;
            groupBox_movimientosentrefechas.Visible = false;
            groupBox_facturapornumero.Visible = false;
            groupBox_facturasentrefechas.Visible = false;

            Class_bodega lg = new Class_bodega();
            lookUpEdit1.Properties.ValueMember = "id_bodega";
            lookUpEdit1.Properties.DisplayMember = "descripcion_bodega";
            lookUpEdit1.Refresh();
            lookUpEdit1.Properties.DataSource = lg.listabodega();
        }

        public void comprasaunproveedor()
        {
            groupBox_productoenbodega.Visible = false;
            groupBox_historialcomprasaproveedor.Visible = true;
            groupBox_contactosdeunproveedor.Visible = false;
            groupBox_historialexistencia.Visible = false;
            groupBox_historialprecioproducto.Visible = false;
            groupBox_facturasauncliente.Visible = false;
            groupBox_comprapornumero.Visible = false;
            groupBox_comprasentrefechas.Visible = false;
            groupBox_movimientosentrefechas.Visible = false;
            groupBox_facturapornumero.Visible = false;
            groupBox_facturasentrefechas.Visible = false;
        }

        public void contactodeproveedor()
        {
            groupBox_productoenbodega.Visible = false;
            groupBox_historialcomprasaproveedor.Visible = false;
            groupBox_contactosdeunproveedor.Visible =true;
            groupBox_historialexistencia.Visible = false;
            groupBox_historialprecioproducto.Visible = false;
            groupBox_facturasauncliente.Visible = false;
            groupBox_comprapornumero.Visible = false;
            groupBox_comprasentrefechas.Visible = false;
            groupBox_movimientosentrefechas.Visible = false;
            groupBox_facturapornumero.Visible = false;
            groupBox_facturasentrefechas.Visible = false;
        }

        public void historialexistenciaproductoenbodega()
        {
            groupBox_productoenbodega.Visible = false;
            groupBox_historialcomprasaproveedor.Visible = false;
            groupBox_contactosdeunproveedor.Visible = false;
            groupBox_historialexistencia.Visible = true;
            groupBox_historialprecioproducto.Visible = false;
            groupBox_facturasauncliente.Visible = false;
            groupBox_comprapornumero.Visible = false;
            groupBox_comprasentrefechas.Visible = false;
            groupBox_movimientosentrefechas.Visible = false;
            groupBox_facturapornumero.Visible = false;
            groupBox_facturasentrefechas.Visible = false;

            Class_bodega lg = new Class_bodega();
            lookUpEdit2.Properties.ValueMember = "id_bodega";
            lookUpEdit2.Properties.DisplayMember = "descripcion_bodega";
            lookUpEdit2.Refresh();
            lookUpEdit2.Properties.DataSource = lg.listabodega();

        }

        public void historialprecioproducto()
        {
            groupBox_productoenbodega.Visible = false;
            groupBox_historialcomprasaproveedor.Visible = false;
            groupBox_contactosdeunproveedor.Visible = false;
            groupBox_historialexistencia.Visible = false;
            groupBox_historialprecioproducto.Visible = true;
            groupBox_facturasauncliente.Visible = false;
            groupBox_comprapornumero.Visible = false;
            groupBox_comprasentrefechas.Visible = false;
            groupBox_movimientosentrefechas.Visible = false;
            groupBox_facturapornumero.Visible = false;
            groupBox_facturasentrefechas.Visible = false;
        }

        public void facturasdeuncliente()
        {
            groupBox_productoenbodega.Visible = false;
            groupBox_historialcomprasaproveedor.Visible = false;
            groupBox_contactosdeunproveedor.Visible = false;
            groupBox_historialexistencia.Visible = false;
            groupBox_historialprecioproducto.Visible = false;
            groupBox_facturasauncliente.Visible = true;
            groupBox_comprapornumero.Visible = false;
            groupBox_comprasentrefechas.Visible = false;
            groupBox_movimientosentrefechas.Visible = false;
            groupBox_facturapornumero.Visible = false;
            groupBox_facturasentrefechas.Visible = false;
        }

        public void comprapornumero()
        {
            groupBox_productoenbodega.Visible = false;
            groupBox_historialcomprasaproveedor.Visible = false;
            groupBox_contactosdeunproveedor.Visible = false;
            groupBox_historialexistencia.Visible = false;
            groupBox_historialprecioproducto.Visible = false;
            groupBox_facturasauncliente.Visible = false;
            groupBox_comprapornumero.Visible = true;
            groupBox_comprasentrefechas.Visible = false;
            groupBox_movimientosentrefechas.Visible = false;
            groupBox_facturapornumero.Visible = false;
            groupBox_facturasentrefechas.Visible = false;

            Class_serie lg = new Class_serie();
            lookUpEdit3.Properties.ValueMember = "id_serie_documento";
            lookUpEdit3.Properties.DisplayMember = "descripcion_serie_documento";
            lookUpEdit3.Refresh();
            lookUpEdit3.Properties.DataSource = lg.listaseriescompras();
        }


        public void comprasentrefechas()
        {
            groupBox_productoenbodega.Visible = false;
            groupBox_historialcomprasaproveedor.Visible = false;
            groupBox_contactosdeunproveedor.Visible = false;
            groupBox_historialexistencia.Visible = false;
            groupBox_historialprecioproducto.Visible = false;
            groupBox_facturasauncliente.Visible = false;
            groupBox_comprapornumero.Visible = false;
            groupBox_comprasentrefechas.Visible = true;
            groupBox_movimientosentrefechas.Visible = false;
            groupBox_facturapornumero.Visible = false;
            groupBox_facturasentrefechas.Visible = false;
        }

        public void movimientosentrefechas()
        {
            groupBox_productoenbodega.Visible = false;
            groupBox_historialcomprasaproveedor.Visible = false;
            groupBox_contactosdeunproveedor.Visible = false;
            groupBox_historialexistencia.Visible = false;
            groupBox_historialprecioproducto.Visible = false;
            groupBox_facturasauncliente.Visible = false;
            groupBox_comprapornumero.Visible = false;
            groupBox_comprasentrefechas.Visible = false;
            groupBox_movimientosentrefechas.Visible = true;
            groupBox_facturapornumero.Visible = false;
            groupBox_facturasentrefechas.Visible = false;
        }

        public void facturapornumero()
        {
            groupBox_productoenbodega.Visible = false;
            groupBox_historialcomprasaproveedor.Visible = false;
            groupBox_contactosdeunproveedor.Visible = false;
            groupBox_historialexistencia.Visible = false;
            groupBox_historialprecioproducto.Visible = false;
            groupBox_facturasauncliente.Visible = false;
            groupBox_comprapornumero.Visible = false;
            groupBox_comprasentrefechas.Visible = false;
            groupBox_movimientosentrefechas.Visible = false;
            groupBox_facturapornumero.Visible = true;
            groupBox_facturasentrefechas.Visible = false;

            Class_serie lg = new Class_serie();
            lookUpEdit4.Properties.ValueMember = "id_serie_documento";
            lookUpEdit4.Properties.DisplayMember = "descripcion_serie_documento";
            lookUpEdit4.Refresh();
            lookUpEdit4.Properties.DataSource = lg.listaseriesfacturas();
        }

        public void facturasentrefechas()
        {
            groupBox_productoenbodega.Visible = false;
            groupBox_historialcomprasaproveedor.Visible = false;
            groupBox_contactosdeunproveedor.Visible = false;
            groupBox_historialexistencia.Visible = false;
            groupBox_historialprecioproducto.Visible = false;
            groupBox_facturasauncliente.Visible = false;
            groupBox_comprapornumero.Visible = false;
            groupBox_comprasentrefechas.Visible = false;
            groupBox_movimientosentrefechas.Visible = false;
            groupBox_facturapornumero.Visible = false;
            groupBox_facturasentrefechas.Visible = true;
        }





        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (lookUpEdit1.Text != "[Vacío]")
            {
                F_reportes nf = new F_reportes();
                nf.productosenbodega(Convert.ToInt16(lookUpEdit1.EditValue));
                nf.ShowDialog();
            }
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarproveedor();
                nf.ShowDialog();
                textEdit1.Text = Variables.contexto;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if ((textEdit1.Text != "") && (Variables.encontrado == true))
            {
                F_reportes nf = new F_reportes();
                nf.comprasaunproveedor(Variables.indice);
                nf.ShowDialog();
                Variables.resetearvariables();
                textEdit1.Text = "";
            }
            else
                MessageBox.Show("Porfavor busque el proveedor, presionando ENTER en el campo PROVEEDOR", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarproveedor();
                nf.ShowDialog();
                textEdit2.Text = Variables.contexto;
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if ((textEdit2.Text != "") && (Variables.encontrado == true))
            {
                F_reportes nf = new F_reportes();
                nf.contactosdeproveedor(Variables.indice);
                nf.ShowDialog();
                Variables.resetearvariables();
                textEdit2.Text = "";
            }
            else
                MessageBox.Show("Porfavor busque el proveedor, presionando ENTER en el campo PROVEEDOR", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if ((textEdit3.Text != "") && (Variables.encontrado == true)&&(lookUpEdit2.Text!="[Vacío]"))
            {
                F_reportes nf = new F_reportes();
                nf.historialexistenciaproducto(Convert.ToInt16(lookUpEdit2.EditValue), Variables.indice);
                nf.ShowDialog();
                Variables.resetearvariables();
                textEdit3.Text = "";
            }
            else
                MessageBox.Show("Porfavor busque el producto, presionando ENTER en el campo PRODUCTO", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textEdit3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarproducto();
                nf.ShowDialog();
                textEdit3.Text = Variables.contexto;
            }
        }

        private void textEdit4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarproducto();
                nf.ShowDialog();
                textEdit4.Text = Variables.contexto;
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if ((textEdit4.Text != "") && (Variables.encontrado == true))
            {
                F_reportes nf = new F_reportes();
                nf.historialprecioproducto(Variables.indice);
                
                nf.ShowDialog();
                Variables.resetearvariables();
                textEdit4.Text = "";
            }
            else
                MessageBox.Show("Porfavor busque el producto, presionando ENTER en el campo PRODUCTO", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textEdit5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarclientes();
                nf.ShowDialog();

                textEdit5.Text = Variables.contexto;
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if ((textEdit5.Text != "") && (Variables.encontrado == true))
            {
                F_reportes nf = new F_reportes();
                nf.facturasparauncliente(Variables.indice);

                nf.ShowDialog();
                Variables.resetearvariables();
                textEdit5.Text = "";
            }
            else
                MessageBox.Show("Porfavor busque el cliente, presionando ENTER en el campo CLIENTE", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if ((textEdit6.Text != "") && (lookUpEdit3.Text != "[Vacío]"))
            {
                F_reportes nf = new F_reportes();
                nf.comprapornumero(Convert.ToInt16(lookUpEdit3.EditValue), Convert.ToInt16(textEdit6.Text));
                nf.ShowDialog();
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            F_reportes nf = new F_reportes();
            nf.comprasentrefechas(dateTimePicker1.Value, dateTimePicker2.Value);
            nf.ShowDialog();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            F_reportes nf = new F_reportes();
            nf.movimientosentrefechas(dateTimePicker4.Value, dateTimePicker3.Value);
            nf.ShowDialog();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            if ((textEdit7.Text != "") && (lookUpEdit4.Text != "[Vacío]"))
            {
                F_reportes nf = new F_reportes();
                
                nf.facturapornumero(Convert.ToInt16(lookUpEdit4.EditValue), Convert.ToInt16(textEdit7.Text));
                nf.ShowDialog();
            }
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            F_reportes nf = new F_reportes();
            nf.facturasentrefechas(dateTimePicker6.Value, dateTimePicker5.Value);
            nf.ShowDialog();
        }
    }
}
