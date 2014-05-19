using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    
    public partial class F_menu : Form
    {

        public void FuncionMostrarOcultar(string NombrePer, bool EstadoPer)
        {
            if (p_salaprincipal_ventas.Name == NombrePer)
                p_salaprincipal_ventas.Visible = EstadoPer;

            else if (p_salaprincipal_compras.Name == NombrePer)
                p_salaprincipal_compras.Visible = EstadoPer;

            else if (p_salaprincipal_reportes.Name == NombrePer)
                p_salaprincipal_reportes.Visible = EstadoPer;

            else if (p_cliente_mantenimiento.Name == NombrePer)
                p_cliente_mantenimiento.Visible = EstadoPer;

            else if (p_cliente_reportes.Name == NombrePer)
                p_cliente_reportes.Visible = EstadoPer;

            else if (p_producto_mantenimiento.Name == NombrePer)
                p_producto_mantenimiento.Visible = EstadoPer;

            else if (p_producto_marca.Name == NombrePer)
                p_producto_marca.Visible = EstadoPer;

            else if (p_producto_reportes.Name == NombrePer)
                p_producto_reportes.Visible = EstadoPer;

            else if (p_proveedor_mantenimiento.Name == NombrePer)
                p_proveedor_mantenimiento.Visible = EstadoPer;

            else if (p_proveedor_contacto.Name == NombrePer)
                p_proveedor_contacto.Visible = EstadoPer;

            else if (p_proveedor_reportes.Name == NombrePer)
                p_proveedor_reportes.Visible = EstadoPer;

            else if (p_bodega_mantenimiento.Name == NombrePer)
                p_bodega_mantenimiento.Visible = EstadoPer;

            else if (p_bodega_reportes.Name == NombrePer)
                p_bodega_reportes.Visible = EstadoPer;

            else if (p_documento_serie.Name == NombrePer)
                p_documento_serie.Visible = EstadoPer;

            else if (p_documento_reportes.Name == NombrePer)
                p_documento_reportes.Visible = EstadoPer;

            else if (p_usuarios_mantenimiento.Name == NombrePer)
                p_usuarios_mantenimiento.Visible = EstadoPer;
        }


        //inicializar formularios
        F_cliente fcliente = new F_cliente();
        F_marca fmarca = new F_marca();
        F_proveedor fproveedor = new F_proveedor();
        F_contacto fcontacto = new F_contacto();
        F_bodega fbodega = new F_bodega();
        F_serie fserie = new F_serie();
        F_usuario fusuario = new F_usuario();
        F_producto fproducto = new F_producto();
        F_rol frol = new F_rol();
        F_rolPermiso frolpermiso = new F_rolPermiso();
        F_usuarioRol fusuariorol = new F_usuarioRol();
        F_busquedas fbusquedas = new F_busquedas();
        F_modificarprecioproducto fmodificarprecioproducto = new F_modificarprecioproducto();
        F_compra fcompra = new F_compra();
        F_factura ffactura = new F_factura();
        public F_menu()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fcliente.MdiParent = this;
            fcliente.guardar();
            fcliente.Show();
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fcliente.MdiParent = this;
            fcliente.editar();
            fcliente.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fcliente.MdiParent = this;
            fcliente.eliminar();
            fcliente.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmarca.MdiParent = this;
            fmarca.guardar();
            fmarca.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmarca.MdiParent = this;
            fmarca.editar();
            fmarca.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fproveedor.MdiParent = this;
            fproveedor.guardar();
            fproveedor.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fproveedor.MdiParent = this;
            fproveedor.editar();
            fproveedor.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fproveedor.MdiParent = this;
            fproveedor.eliminar();
            fproveedor.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fcontacto.MdiParent = this;
            fcontacto.guardar();
            fcontacto.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fcontacto.MdiParent = this;
            fcontacto.editar();
            fcontacto.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fcontacto.MdiParent = this;
            fcontacto.eliminar();
            fcontacto.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fbodega.MdiParent = this;
            fbodega.guardar();
            fbodega.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fbodega.MdiParent = this;
            fbodega.editar();
            fbodega.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fbodega.MdiParent = this;
            fbodega.eliminar();
            fbodega.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fserie.MdiParent = this;
            fserie.guardar();
            fserie.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fserie.MdiParent = this;
            fserie.editar();
            fserie.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fserie.MdiParent = this;
            fserie.eliminar();
            fserie.Show();
        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fusuario.MdiParent = this;
            fusuario.guardar();
            fusuario.Show();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fusuario.MdiParent = this;
            fusuario.editar();
            fusuario.Show();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fusuario.MdiParent = this;
            fusuario.eliminar();
            fusuario.Show();
        }

        private void barButtonItem48_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fproducto.MdiParent = this;
            fproducto.guardar();
            fproducto.Show();
        }

        private void barButtonItem49_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fproducto.MdiParent = this;
            fproducto.editar();
            fproducto.Show();
        }

        private void barButtonItem50_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fproducto.MdiParent = this;
            fproducto.eliminar();
            fproducto.Show();
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frol.MdiParent = this;
            frol.guardar();
            frol.Show();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frol.MdiParent = this;
            frol.editar();
            frol.Show();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frol.MdiParent = this;
            frol.eliminar();
            frol.Show();
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            F_reportes nf = new F_reportes();
            nf.ClientesActivos();
            nf.ShowDialog();
        }

        private void barButtonItem52_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            F_reportes nf = new F_reportes();
            nf.MarcasActivas();
            nf.ShowDialog();
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            F_reportes nf = new F_reportes();
            nf.productosexistentes();
            nf.ShowDialog();
        }

        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            F_reportes nf = new F_reportes();
            nf.proveedoresactivos();
            nf.ShowDialog();
        }

        private void barButtonItem45_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            F_reportes nf = new F_reportes();
            nf.bodegasactivas();
            nf.ShowDialog();
        }

        private void barButtonItem47_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            F_reportes nf = new F_reportes();
            nf.seriesactivas();
            nf.ShowDialog();
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frolpermiso.MdiParent = this;
            frolpermiso.asignar();
            frolpermiso.Show();
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fusuariorol.MdiParent = this;
            fusuariorol.asignar();
            fusuariorol.Show();
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            F_loggin fl = new F_loggin();
            fl.ShowDialog();
        }

        private void barButtonItem46_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fbusquedas.MdiParent = this;
            fbusquedas.listaproductosenbodega();
            fbusquedas.Show();
        }

        private void barButtonItem51_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmodificarprecioproducto.MdiParent = this;
            fmodificarprecioproducto.nuevoprecio();
            fmodificarprecioproducto.Show();
        }

        private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fbusquedas.MdiParent = this;
            fbusquedas.comprasaunproveedor();
            fbusquedas.Show();
        }

        private void barButtonItem44_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fbusquedas.MdiParent = this;
            fbusquedas.contactodeproveedor();
            fbusquedas.Show();
        }

        private void barButtonItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fbusquedas.MdiParent = this;
            fbusquedas.historialexistenciaproductoenbodega();
            fbusquedas.Show();
        }

        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fbusquedas.MdiParent = this;
            fbusquedas.historialprecioproducto();
            fbusquedas.Show();
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fbusquedas.MdiParent = this;
            fbusquedas.facturasdeuncliente();
            fbusquedas.Show();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fcompra.MdiParent = this;
            fcompra.NuevaCompra();
            fcompra.Show();
        }

        private void barButtonItem53_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fbusquedas.MdiParent = this;
            fbusquedas.comprapornumero();
            fbusquedas.Show();
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fbusquedas.MdiParent = this;
            fbusquedas.comprasentrefechas();
            fbusquedas.Show();
        }

        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fbusquedas.MdiParent = this;
            fbusquedas.movimientosentrefechas();
            fbusquedas.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ffactura.MdiParent = this;
            ffactura.NuevaFactura();
            ffactura.Show();
        }

        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fbusquedas.MdiParent = this;
            fbusquedas.facturapornumero();
            fbusquedas.Show();
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fbusquedas.MdiParent = this;
            fbusquedas.facturasentrefechas();
            fbusquedas.Show();
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            F_reportes nf = new F_reportes();
            nf.cortedecaja();
            nf.ShowDialog();
        }
    }
}
