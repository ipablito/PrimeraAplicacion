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
    public partial class F_contacto : Form
    {
        public F_contacto()
        {
            InitializeComponent();
        }
        void limpiartextos()
        {
            textEdit_nombre.Text = "";
            textEdit_telefono.Text = "";
            textEdit_direccion.Text = "";
            textEdit_contexto.Text = "";
        }

        void cargarproveedores()
        {
            Class_proveedor lg = new Class_proveedor();
            lookUpEdit_proveedores.Properties.ValueMember = "id_proveedor";
            lookUpEdit_proveedores.Properties.DisplayMember = "descripcion_proveedor";
            lookUpEdit_proveedores.Refresh();
            lookUpEdit_proveedores.Properties.DataSource = lg.listaproveedores();
        }

        //variable para el id_contacto 
        int t_idcon = 0;

        public void guardar()
        {
            cargarproveedores();
            groupBox_buscar.Visible = false;
            groupBox_Datos.Visible = true;

            simpleButton_guardar.Visible = true;
            simpleButton_editar.Visible = false;
            simpleButton_eliminar.Visible = false;
            limpiartextos();
        }

        public void editar()
        {
            

            groupBox_buscar.Visible = true;
            groupBox_Datos.Visible = false;

            simpleButton_guardar.Visible = false;
            simpleButton_editar.Visible = true;
            simpleButton_eliminar.Visible = false;
            limpiartextos();
            cargarproveedores();
        }

        public void eliminar()
        {
            
            groupBox_buscar.Visible = true;
            groupBox_Datos.Visible = false;

            simpleButton_guardar.Visible = false;
            simpleButton_editar.Visible = false;
            simpleButton_eliminar.Visible = true;
            limpiartextos();
            cargarproveedores();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void simpleButton_guardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lookUpEdit_proveedores.EditValue.ToString());
            if ((textEdit_nombre.Text != "") && (lookUpEdit_proveedores.Text != "[Vacío]"))
            {
                Class_contacto lg = new Class_contacto();
                int r = lg.ingresocontacto(textEdit_nombre.Text, textEdit_telefono.Text, textEdit_direccion.Text, Convert.ToInt16(lookUpEdit_proveedores.EditValue));
                if (r == 1)
                    this.Hide();
            }
            else
                MessageBox.Show("Los campos de NOMBRE y PROVEEDOR son obligatorios", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if ((textEdit_contexto.Text != "") && (Variables.encontrado == true))
            {
                string[] t = new string[4];
                Class_contacto lg = new Class_contacto();
                t = lg.datoscontacto(Variables.indice);

                groupBox_Datos.Visible = true;
                textEdit_nombre.Text = t[0];
                textEdit_telefono.Text = t[1];
                textEdit_direccion.Text = t[2];
                lookUpEdit_proveedores.Text = t[3];

                t_idcon = Variables.indice;
                Variables.resetearvariables();
            }
            else
                MessageBox.Show("Busque la marca, presionando ENTER en el campo MARCA", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textEdit_contexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarcontacto();
                nf.ShowDialog();

                textEdit_contexto.Text = Variables.contexto;
            }
        }

        private void simpleButton_editar_Click(object sender, EventArgs e)
        {
            Class_contacto lg = new Class_contacto();
            lg.editarcontacto(t_idcon, textEdit_nombre.Text, textEdit_telefono.Text, textEdit_direccion.Text, Convert.ToInt16(lookUpEdit_proveedores.EditValue));
            this.Hide();
        }

        private void simpleButton_eliminar_Click(object sender, EventArgs e)
        {
            Class_contacto lg = new Class_contacto();
            lg.eliminarcontacto(t_idcon);
            this.Hide();
        }
    }
}
