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
    public partial class F_compra : Form
    {
        public F_compra()
        {
            InitializeComponent();
        }

        //variables globales de la compra
        int id_pro = 0;
        bool proveedor_encontrado = false;

        int id_prod = 0;
        bool producto_encontrado = false;
        //fin de variables globales de compra

        void limpiarvariables()
        {
            Variables.resetearvariables();
            id_pro = 0;
            proveedor_encontrado = false;
            id_prod = 0;
            producto_encontrado = false;
        }
        void limpiartextos()
        {
            textEdit_nitproveedor.Text = "";
            textEdit_descripcionproveedor.Text = "";
            textEdit_referencia.Text = "";
            textEdit_codigoproducto.Text = "";
            textEdit_descripcionproducto.Text = "";
            textEdit_preciocompraproducto.Text = "0.00";
            textEdit_cantidadproducto.Text = "1";
            dataGridView_detalle.Rows.Clear();
        }

        public void NuevaCompra()
        {
            Class_serie lg = new Class_serie();
            lookUpEdit_serie.Properties.DisplayMember = "descripcion_serie_documento";
            lookUpEdit_serie.Properties.ValueMember = "id_serie_documento";
            lookUpEdit_serie.Refresh();
            lookUpEdit_serie.Properties.DataSource = lg.listaseriescompras();

            Class_bodega lg1 = new Class_bodega();
            lookUpEdit_bodega.Properties.DisplayMember = "descripcion_bodega";
            lookUpEdit_bodega.Properties.ValueMember = "id_bodega";
            lookUpEdit_bodega.Refresh();
            lookUpEdit_bodega.Properties.DataSource = lg1.listabodega();
            limpiartextos();
            limpiarvariables();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textEdit_nitproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarproveedor();
                nf.ShowDialog();
                textEdit_descripcionproveedor.Text = Variables.contexto;

                if (Variables.encontrado == true)
                {
                    Class_proveedor lg = new Class_proveedor();
                    textEdit_nitproveedor.Text = lg.nitbuscadoporid(Variables.indice);
                    id_pro = Variables.indice;
                }
                proveedor_encontrado = Variables.encontrado;
            }
        }

        private void textEdit_descripcionproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarproveedor();
                nf.ShowDialog();
                textEdit_descripcionproveedor.Text = Variables.contexto;

                if (Variables.encontrado == true)
                {
                    Class_proveedor lg = new Class_proveedor();
                    textEdit_nitproveedor.Text = lg.nitbuscadoporid(Variables.indice);
                    id_pro = Variables.indice;
                }
                proveedor_encontrado = Variables.encontrado;
            }
        }

        private void textEdit_codigoproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarproducto();
                nf.ShowDialog();
                //textEdit_descripcionproducto.Text = Variables.contexto;
                if (Variables.encontrado == true)
                {
                    Class_producto lg = new Class_producto();
                    string[] r = new string[3];
                    r = lg.datosproductoporidparacompra(Variables.indice);
                    textEdit_codigoproducto.Text = r[0];
                    textEdit_descripcionproducto.Text = r[1];
                    textEdit_preciocompraproducto.Text = r[2];
                    id_prod = Variables.indice;
                }
                producto_encontrado = Variables.encontrado;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if ((textEdit_codigoproducto.Text != "") && (textEdit_descripcionproducto.Text != "") && (textEdit_preciocompraproducto.Text != "") && (textEdit_cantidadproducto.Text != ""))
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
                        double subtot = Convert.ToDouble(textEdit_preciocompraproducto.Text) * Convert.ToDouble(textEdit_cantidadproducto.Text);
                        dataGridView_detalle.Rows.Add(textEdit_codigoproducto.Text, textEdit_descripcionproducto.Text, textEdit_preciocompraproducto.Text, textEdit_cantidadproducto.Text, subtot.ToString(), id_prod.ToString());
                        producto_encontrado = false;
                        id_prod = 0;
                        textEdit_codigoproducto.Text = "";
                        textEdit_descripcionproducto.Text = "";
                        textEdit_preciocompraproducto.Text = "";
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
                    DialogResult yn = MessageBox.Show("Este producto no existe actualmente, desea agregarlo?", "Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (yn == DialogResult.Yes)
                    {
                        Class_producto lg = new Class_producto();
                        int t = lg.ingresoproducto(textEdit_descripcionproducto.Text, textEdit_codigoproducto.Text, 0.10, 1);
                        if (t == 1)
                        {
                            double subtot = Convert.ToDouble(textEdit_preciocompraproducto.Text) * Convert.ToDouble(textEdit_cantidadproducto.Text);
                            id_prod = lg.iddeproductobuscadoporsucodigo(textEdit_codigoproducto.Text);
                            dataGridView_detalle.Rows.Add(textEdit_codigoproducto.Text, textEdit_descripcionproducto.Text, textEdit_preciocompraproducto.Text, textEdit_cantidadproducto.Text, subtot.ToString(),id_prod.ToString());
                            producto_encontrado = false;
                            id_prod = 0;
                            textEdit_codigoproducto.Text = "";
                            textEdit_descripcionproducto.Text = "";
                            textEdit_preciocompraproducto.Text = "";
                            textEdit_cantidadproducto.Text = "1";
                        }
                        else
                        {
                            MessageBox.Show("Este producto ya existe, por favor presione la tecla ENTER en los campos CODIGO DE PRODUCTO o DESCRIPCION, y seleccione el producto que desea agregar a la compra", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                        textEdit_codigoproducto.Text = "";
                        textEdit_descripcionproducto.Text = "";
                        textEdit_preciocompraproducto.Text = "";
                        textEdit_cantidadproducto.Text = "1";
                    }
                    else
                    {
                        textEdit_codigoproducto.Text = "";
                        textEdit_codigoproducto.Focus();
                    }
                }
            }
            else
                MessageBox.Show("Los campos de CODIGO DE PRODUCTO, DESCRIPCION, PRECIO COSTO y CANTIDAD deben ser ingresados", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textEdit_descripcionproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarproducto();
                nf.ShowDialog();
                //textEdit_descripcionproducto.Text = Variables.contexto;
                if (Variables.encontrado == true)
                {
                    Class_producto lg = new Class_producto();
                    string[] r = new string[3];
                    r = lg.datosproductoporidparacompra(Variables.indice);
                    textEdit_codigoproducto.Text = r[0];
                    textEdit_descripcionproducto.Text = r[1];
                    textEdit_preciocompraproducto.Text = r[2];
                    id_prod = Variables.indice;
                }
                producto_encontrado = Variables.encontrado;
            }
        }

        private void dataGridView_detalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
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

        private void dataGridView_detalle_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_detalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView_detalle_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = dataGridView_detalle.CurrentRow.Index;
            dataGridView_detalle.Rows.RemoveAt(fila);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if ((lookUpEdit_serie.Text != "[Vacío]") && (lookUpEdit_bodega.Text != "[Vacío]") && (lookUpEdit_serie.Text != "") && (lookUpEdit_bodega.Text != ""))
            {
                if ((textEdit_nitproveedor.Text != "") && (textEdit_descripcionproveedor.Text != ""))
                {
                    if (proveedor_encontrado == true)
                    {
                        Class_compra lg = new Class_compra();
                        int EncabezadoNo = lg.encabezadocompra(1, Convert.ToInt16(lookUpEdit_serie.EditValue), id_pro, dateTimePicker_fechaUsuario.Value, Convert.ToDouble(label_total.Text), textEdit_referencia.Text);
                        //MessageBox.Show(compraNo.ToString());

                        int con = dataGridView_detalle.Rows.Count;

                        for (int i = 0; i < con; i++)
                        {
                            double pu = Convert.ToDouble(dataGridView_detalle.Rows[i].Cells[2].Value);
                            int c = Convert.ToInt16(dataGridView_detalle.Rows[i].Cells[3].Value);
                            double st = Convert.ToDouble(dataGridView_detalle.Rows[i].Cells[4].Value);
                            int cp = Convert.ToInt16(dataGridView_detalle.Rows[i].Cells[5].Value);
                            lg.detallecompra(EncabezadoNo, pu, c, st, Convert.ToInt16(lookUpEdit_bodega.EditValue), cp);
                        }

                        proveedor_encontrado = false;
                        id_pro = 0;

                        F_reportes nf = new F_reportes();
                        nf.compra(EncabezadoNo);
                        nf.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        DialogResult yn = MessageBox.Show("Este proveedor no existe actualmente, desea agregarlo?", "Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yn == DialogResult.Yes)
                        {
                            Class_proveedor lg = new Class_proveedor();
                            int r = lg.ingresoproveedor(textEdit_nitproveedor.Text, textEdit_descripcionproveedor.Text, "", "", "", "");

                            if (r == 1)
                            {
                                id_pro = lg.idproveedorporsunitydescripcion(textEdit_nitproveedor.Text, textEdit_descripcionproveedor.Text);
                                //aca tengo q copiar todo como si el proveedor ia existiera, tengo que devolver el id del proveedor para poder hacer las operaciones
                                Class_compra lg1 = new Class_compra();
                                int EncabezadoNo = lg1.encabezadocompra(1, Convert.ToInt16(lookUpEdit_serie.EditValue), id_pro, dateTimePicker_fechaUsuario.Value, Convert.ToDouble(label_total.Text), textEdit_referencia.Text);
                                //MessageBox.Show(compraNo.ToString());

                                int con = dataGridView_detalle.Rows.Count;

                                for (int i = 0; i < con; i++)
                                {
                                    double pu = Convert.ToDouble(dataGridView_detalle.Rows[i].Cells[2].Value);
                                    int c = Convert.ToInt16(dataGridView_detalle.Rows[i].Cells[3].Value);
                                    double st = Convert.ToDouble(dataGridView_detalle.Rows[i].Cells[4].Value);
                                    int cp = Convert.ToInt16(dataGridView_detalle.Rows[i].Cells[5].Value);
                                    lg1.detallecompra(EncabezadoNo, pu, c, st, Convert.ToInt16(lookUpEdit_bodega.EditValue), cp);
                                }

                                proveedor_encontrado = false;
                                id_pro = 0;

                                F_reportes nf = new F_reportes();
                                nf.compra(EncabezadoNo);
                                nf.ShowDialog();

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Este proveedor ya existe, por favor presione la tecla ENTER en los campos NIT DE PROVEEDOR o DESCRIPCION, y busque el proveedor que desee", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Porfavor seleccione un proveedor, presionando ENTER en los campos NIT DE PROVEEDOR o DESCRIPCION", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Por favor seleccion la SERIE de compra, y la BODEGA  a la cual desea ingresar", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
