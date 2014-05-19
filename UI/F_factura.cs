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
    public partial class F_factura : Form
    {
        public F_factura()
        {
            InitializeComponent();
        }

        //variables globales de la factura
        int id_cli = 0;
        bool cliente_encontrado = false;

        int id_prod = 0;
        bool producto_encontrado = false;
        double t_precio_compra = 0;
        double t_precioventa = 0;
        int t_existencia = 0;
        //

        //
        void limpiarvariables()
        {
            Variables.resetearvariables();
            id_cli = 0;
            cliente_encontrado = false;

            id_prod = 0;
            producto_encontrado = false;
            
        }
        void limpiartextos()
        {
            textEdit_nitcliente.Text = "";
            textEdit_nombrecliente.Text = "";
            textEdit_codigoproducto.Text = "";
            textEdit_descripcionproducto.Text = "";
            textEdit_precioventaproducto.Text = "0.00";
            textEdit_cantidadproducto.Text = "1";
            dataGridView_detalle.Rows.Clear();
        }

        public void NuevaFactura()
        {
            Class_serie lg = new Class_serie();
            lookUpEdit_serie.Properties.DisplayMember = "descripcion_serie_documento";
            lookUpEdit_serie.Properties.ValueMember = "id_serie_documento";
            lookUpEdit_serie.Refresh();
            lookUpEdit_serie.Properties.DataSource = lg.listaseriesfacturas();

            Class_bodega lg1 = new Class_bodega();
            lookUpEdit_bodega.Properties.DisplayMember = "descripcion_bodega";
            lookUpEdit_bodega.Properties.ValueMember = "id_bodega";
            lookUpEdit_bodega.Refresh();
            lookUpEdit_bodega.Properties.DataSource = lg1.listabodega();
            limpiartextos();
            limpiarvariables();
            groupBox_datos.Enabled = true;
            groupBox_detalle.Enabled = false;
        }
        //

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textEdit_nitcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarclientes();
                nf.ShowDialog();
                textEdit_nombrecliente.Text = Variables.contexto;
                
                if (Variables.encontrado == true)
                {
                    Class_cliente lg = new Class_cliente();
                    textEdit_nitcliente.Text = lg.nitclienteporid(Variables.indice);
                    id_cli = Variables.indice;
                }
                cliente_encontrado = Variables.encontrado;
                Variables.resetearvariables();
            }
        }

        private void textEdit_nombrecliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarclientes();
                nf.ShowDialog();
                textEdit_nombrecliente.Text = Variables.contexto;

                if (Variables.encontrado == true)
                {
                    Class_cliente lg = new Class_cliente();
                    textEdit_nitcliente.Text = lg.nitclienteporid(Variables.indice);
                    id_cli = Variables.indice;
                }
                cliente_encontrado = Variables.encontrado;
                Variables.resetearvariables();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if ((lookUpEdit_serie.Text != "[Vacío]") && (lookUpEdit_bodega.Text != "[Vacío]") && (textEdit_nitcliente.Text != "") && (textEdit_nombrecliente.Text != "") && (lookUpEdit_serie.Text != "") && (lookUpEdit_bodega.Text != ""))
            {
                if (cliente_encontrado == true)
                {
                    groupBox_datos.Enabled = false;
                    groupBox_detalle.Enabled = true;
                }
                else if((textEdit_nitcliente.Text=="c/f")&&(cliente_encontrado==false))
                {
                    Class_cliente lg = new Class_cliente();
                    lg.ingresocliente(textEdit_nombrecliente.Text, "c/f", "", "", "", dateTimePicker_fechaUsuario.Value);

                    id_cli = lg.ultimocliente();
                    cliente_encontrado = true;
                    groupBox_datos.Enabled = false;
                    groupBox_detalle.Enabled = true;
                }
                else
                {
                    DialogResult yn = MessageBox.Show("Este cliente no existe actualmente, desea agregarlo?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (yn == DialogResult.Yes)
                    {
                        Class_cliente lg = new Class_cliente();
                        int t = lg.ingresocliente(textEdit_nombrecliente.Text, textEdit_nitcliente.Text, "", "", "", dateTimePicker_fechaUsuario.Value);
                        if (t == 1)
                        {
                            id_cli = lg.ultimocliente();
                            cliente_encontrado = true;
                            groupBox_datos.Enabled = false;
                            groupBox_detalle.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Este cliente ya existe, por favor presione la tecla ENTER en los campos NIT DEL CLIENTE o NOMBRE, y seleccione el cliente a quien desea facturar", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textEdit_nitcliente.Text = "";
                            textEdit_nitcliente.Focus();
                        }
                    }
                    else
                    {
                        textEdit_nitcliente.Text = "";
                        textEdit_nitcliente.Focus();
                    }
                }
            }
            else
                MessageBox.Show("Para poder facturar necesita seleccionar una serie de factura, la bodega e ingresar los datos del cliente", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if ((textEdit_codigoproducto.Text != "") && (textEdit_descripcionproducto.Text != "") && (textEdit_precioventaproducto.Text != "") && (textEdit_cantidadproducto.Text != ""))
            {
                if (producto_encontrado == true)
                {
                    int cont = dataGridView_detalle.Rows.Count;
                    bool productoyaexiste = false;

                    for (int i = 0; i < cont; i++)
                    {
                        if (dataGridView_detalle.Rows[i].Cells[0].Value.ToString() == textEdit_codigoproducto.Text)
                        {
                            productoyaexiste = true;
                        }
                    }

                    if (productoyaexiste == false)
                    {
                        double subtot = Convert.ToDouble(textEdit_precioventaproducto.Text) * Convert.ToDouble(textEdit_cantidadproducto.Text);
                        dataGridView_detalle.Rows.Add(textEdit_codigoproducto.Text, textEdit_descripcionproducto.Text, textEdit_precioventaproducto.Text, textEdit_cantidadproducto.Text, subtot.ToString(), id_prod.ToString());
                        producto_encontrado = false;
                        id_prod = 0;
                        textEdit_codigoproducto.Text = "";
                        textEdit_descripcionproducto.Text = "";
                        textEdit_precioventaproducto.Text = "";
                        textEdit_cantidadproducto.Text = "1";
                    }
                    else
                    {
                        MessageBox.Show("Este producto ya fue ingresado en la compra", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textEdit_codigoproducto.Text = "";
                        producto_encontrado = false;
                    }
                }
                else
                {
                    MessageBox.Show("Presione ENTER en el campo CODIGO DE PRODUCTO o DESCRIPCION, y seleccione el producto que desea cargar a la factura", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textEdit_codigoproducto.Text = "";
                    textEdit_codigoproducto.Focus();
                }

            }
            else
                MessageBox.Show("Los campos de CODIGO DE PRODUCTO, DESCRIPCION, PRECIO DE VENTA y CANTIDAD deben ser ingresados", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textEdit_codigoproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarproducto();
                nf.ShowDialog();
                if (Variables.encontrado == true)
                {
                    Class_producto lg = new Class_producto();
                    string[] r = new string[5];
                    r = lg.datosproductoporidparaventa(Variables.indice, Convert.ToInt16(lookUpEdit_bodega.EditValue));
                    if (r != null)
                    {
                        textEdit_codigoproducto.Text = r[0];
                        textEdit_descripcionproducto.Text = r[1];
                        t_precio_compra = Convert.ToDouble(r[2]);
                        t_precioventa = Convert.ToDouble(r[3]);
                        textEdit_precioventaproducto.Text = r[3];
                        t_existencia = Convert.ToInt16(r[4]);
                        id_prod = Variables.indice;
                    }
                    else
                    {
                        MessageBox.Show("Este producto no tiene existencia en la bodega " + lookUpEdit_bodega.Text, "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                producto_encontrado = Variables.encontrado;
            }
        }

        private void textEdit_precioventaproducto_Validated(object sender, EventArgs e)
        {
            if ((producto_encontrado == true)&&(textEdit_precioventaproducto.Text!=""))
            {
                if (Convert.ToDouble(textEdit_precioventaproducto.Text) <= t_precio_compra)
                {
                    MessageBox.Show("El precio al que desea vender es menor al precio de compra, esto no es permitido", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textEdit_precioventaproducto.Text = t_precioventa.ToString();
                }
            }
        }

        private void textEdit_cantidadproducto_Validated(object sender, EventArgs e)
        {
            if((producto_encontrado==true)&&(textEdit_cantidadproducto.Text!=""))
            {
                if(Convert.ToInt16(textEdit_cantidadproducto.Text)>t_existencia)
                {
                    MessageBox.Show("La cantidad de producto que desea vender es mayor a la existente en bodega", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textEdit_cantidadproducto.Text="1";
                }
            }
        }

        private void dataGridView_detalle_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = dataGridView_detalle.CurrentRow.Index;
            dataGridView_detalle.Rows.RemoveAt(fila);
        }

        private void dataGridView_detalle_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int con = dataGridView_detalle.Rows.Count;
            double actualtotal = 0;
            double temp = 0;
            for (int i = 0; i < con; i++)
            {
                temp = Convert.ToDouble(dataGridView_detalle.Rows[i].Cells[4].Value);
                actualtotal = actualtotal + temp;
            }
            label_total.Text = actualtotal.ToString();
        }

        private void dataGridView_detalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int con = dataGridView_detalle.Rows.Count;
            double actualtotal = 0;
            double temp = 0;
            for (int i = 0; i < con; i++)
            {
                temp = Convert.ToDouble(dataGridView_detalle.Rows[i].Cells[4].Value);
                actualtotal = actualtotal + temp;
            }
            label_total.Text = actualtotal.ToString();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (cliente_encontrado == true)
            {
                Class_factura lg = new Class_factura();
                int EncabezadoNo = lg.encabezdofactura(1, Convert.ToInt16(lookUpEdit_serie.EditValue), id_cli, dateTimePicker_fechaUsuario.Value, Convert.ToDouble(label_total.Text), "");

                int cont = dataGridView_detalle.Rows.Count;

                for (int i = 0; i < cont; i++)
                {
                    double pu = Convert.ToDouble(dataGridView_detalle.Rows[i].Cells[2].Value);
                    int c = Convert.ToInt16(dataGridView_detalle.Rows[i].Cells[3].Value);
                    double st = Convert.ToDouble(dataGridView_detalle.Rows[i].Cells[4].Value);
                    int cp = Convert.ToInt16(dataGridView_detalle.Rows[i].Cells[5].Value);
                    lg.detallefactura(EncabezadoNo, pu, c, st, Convert.ToInt16(lookUpEdit_bodega.EditValue), cp);
                }

                cliente_encontrado = false;
                id_cli = 0;
                F_reportes nf = new F_reportes();
                nf.factura(EncabezadoNo);
                nf.ShowDialog();
                this.Hide();

            }
        }

        private void textEdit_descripcionproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarproducto();
                nf.ShowDialog();
                if (Variables.encontrado == true)
                {
                    Class_producto lg = new Class_producto();
                    string[] r = new string[5];
                    r = lg.datosproductoporidparaventa(Variables.indice, Convert.ToInt16(lookUpEdit_bodega.EditValue));
                    if (r != null)
                    {
                        textEdit_codigoproducto.Text = r[0];
                        textEdit_descripcionproducto.Text = r[1];
                        t_precio_compra = Convert.ToDouble(r[2]);
                        t_precioventa = Convert.ToDouble(r[3]);
                        textEdit_precioventaproducto.Text = r[3];
                        t_existencia = Convert.ToInt16(r[4]);
                        id_prod = Variables.indice;
                    }
                    else
                    {
                        MessageBox.Show("Este producto no tiene existencia en la bodega " + lookUpEdit_bodega.Text, "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                producto_encontrado = Variables.encontrado;
            }
        }
    }
}
