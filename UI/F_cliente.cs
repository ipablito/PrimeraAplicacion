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
    public partial class F_cliente : Form
    {

        int t_id = 0;//variable temporal para guardar el id del cliente mientras se edita o elimina

        public F_cliente()
        {
            InitializeComponent();
        }

        void limpiarttextos()
        {
            textEdit_nombre.Text = "";
            textEdit_nit.Text = "";
            textEdit_direccion.Text = "";
            textEdit_telefono.Text = "";
            textEdit_correo.Text = "";
            textEdit_mostrarContexto.Text = "";
        }

        public void guardar()
        {
            groupBox_buscar.Visible = false;
            groupBox_Datos.Visible = true;

            simpleButton_guardar.Visible = true;
            simpleButton_editar.Visible = false;
            simpleButton_eliminar.Visible = false;

            limpiarttextos();
        }

        public void editar()
        {
            groupBox_buscar.Visible = true;
            groupBox_Datos.Visible = false;

            simpleButton_guardar.Visible = false;
            simpleButton_editar.Visible = true;
            simpleButton_eliminar.Visible = false;

            limpiarttextos();
        }

        public void eliminar()
        {
            groupBox_buscar.Visible = true;
            groupBox_Datos.Visible = false;
            simpleButton_guardar.Visible = false;
            simpleButton_editar.Visible = false;
            simpleButton_eliminar.Visible = true;
            limpiarttextos();
        }
        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textEdit_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                F_buscar nf = new F_buscar();
                nf.buscarclientes();
                nf.ShowDialog();

                textEdit_mostrarContexto.Text = Variables.contexto;
            }
        }

        private void simpleButton_guardar_Click(object sender, EventArgs e)
        {
            if (textEdit_nit.Text != "")
            {
                Class_cliente lg = new Class_cliente();
                int res = lg.ingresocliente(textEdit_nombre.Text, textEdit_nit.Text, textEdit_direccion.Text, textEdit_telefono.Text, textEdit_correo.Text, dateTimePicker_fecha.Value);

                if (res ==1)
                    this.Hide();
                else
                    MessageBox.Show("Es probable que este cliente ya exista,verifique porfavor", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if ((textEdit_mostrarContexto.Text != "")&&(Variables.encontrado==true))
            {
                string[] t = new string[6];
                Class_cliente lg = new Class_cliente();
                t = lg.datoscliente(Variables.indice);
                if (t != null)
                {
                    groupBox_Datos.Visible = true;
                    textEdit_nombre.Text = t[0];
                    textEdit_nit.Text = t[1];
                    textEdit_direccion.Text = t[2];
                    textEdit_telefono.Text = t[3];
                    textEdit_correo.Text = t[4];
                    dateTimePicker_fecha.Text = t[5];
                    t_id = Variables.indice;
                    Variables.resetearvariables();
                    textEdit_mostrarContexto.Text = "";
                }

                else
                    MessageBox.Show("Este cliente no existe", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Porfavor busque el cliente, presionando ENTER en el campo CLIENTE", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void simpleButton_editar_Click(object sender, EventArgs e)
        {
            Class_cliente lg = new Class_cliente();
            lg.editarcliente(t_id, textEdit_nombre.Text, textEdit_nit.Text, textEdit_direccion.Text, textEdit_telefono.Text, textEdit_correo.Text, dateTimePicker_fecha.Value);
            this.Hide();
        }

        private void simpleButton_eliminar_Click(object sender, EventArgs e)
        {
            Class_cliente lg = new Class_cliente();
            lg.eliminarcliente(t_id);
            this.Hide();
        }
    }
}
