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
    public partial class F_buscar : Form
    {
        public F_buscar()
        {
            InitializeComponent();
        }


        public void buscarclientes()
        {
            Class_cliente lg = new Class_cliente();
            gridControl_busqueda.DataSource = lg.ListaClientesActivos();
            Variables.nombre_indice = "id_cliente";
            Variables.nombre_contexto = "nombre_cliente";
        }

        public void buscarmarca()
        {
            Class_marca lg = new Class_marca();
            gridControl_busqueda.DataSource = lg.listamarcasactivas();
            Variables.nombre_indice = "id_marca";
            Variables.nombre_contexto = "nombre_marca";
        }

        public void buscarproveedor()
        {
            Class_proveedor lg = new Class_proveedor();
            gridControl_busqueda.DataSource = lg.listaproveedores();
            Variables.nombre_indice = "id_proveedor";
            Variables.nombre_contexto = "descripcion_proveedor";
        }

        public void buscarcontacto()
        {
            Class_contacto lg = new Class_contacto();
            gridControl_busqueda.DataSource = lg.listacontactosactivos();
            Variables.nombre_indice = "id_contacto";
            Variables.nombre_contexto = "nombre_contacto";
        }

        public void buscarbodega()
        {
            Class_bodega lg = new Class_bodega();
            gridControl_busqueda.DataSource = lg.listabodega();
            Variables.nombre_indice = "id_bodega";
            Variables.nombre_contexto = "descripcion_bodega";
        }

        public void buscarserie()
        {
            Class_serie lg = new Class_serie();
            gridControl_busqueda.DataSource = lg.listaseries();
            Variables.nombre_indice = "id_serie_documento";
            Variables.nombre_contexto = "descripcion_serie_documento";
        }

        public void buscarproducto()
        {
            Class_producto lg = new Class_producto();
            gridControl_busqueda.DataSource = lg.listaproductos();
            Variables.nombre_indice = "id_producto";
            Variables.nombre_contexto = "descripcion_producto";
        }

        public void buscarusuario()
        {
            Class_usuario lg = new Class_usuario();
            gridControl_busqueda.DataSource = lg.listausuarios();
            Variables.nombre_indice = "id_usuario";
            Variables.nombre_contexto = "nombre_empleado";
        }


        public void buscarrol()
        {
            Class_rol lg = new Class_rol();
            gridControl_busqueda.DataSource = lg.listaroles();
            Variables.nombre_indice = "id_rol";
            Variables.nombre_contexto = "nombre_rol";
        }

        private void F_buscar_Load(object sender, EventArgs e)
        {
            
        }

        private void gridControl_busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                Variables.indice = Convert.ToInt16(gridView1.GetFocusedRowCellValue(Variables.nombre_indice));
                Variables.contexto = gridView1.GetFocusedRowCellValue(Variables.nombre_contexto).ToString();
                Variables.encontrado = true;
                this.Close();
            }
        }

        private void gridControl_busqueda_DoubleClick(object sender, EventArgs e)
        {
            Variables.indice = Convert.ToInt16(gridView1.GetFocusedRowCellValue(Variables.nombre_indice));
            Variables.contexto = gridView1.GetFocusedRowCellValue(Variables.nombre_contexto).ToString();
            Variables.encontrado = true;
            this.Close();
        }
    }
}
