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
    public partial class F_reportes : Form
    {
        public F_reportes()
        {
            InitializeComponent();
        }

        private void F_reportes_Load(object sender, EventArgs e)
        {

        }

        public void ClientesActivos()
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.clienteTableAdapter lg = new DataSet1TableAdapters.clienteTableAdapter();
            R_ClientesActivos reporte = new R_ClientesActivos();
            res = lg.GetData_listaclientesactivos();
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void MarcasActivas()
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.marcaTableAdapter lg = new DataSet1TableAdapters.marcaTableAdapter();
            R_marcasactivas reporte = new R_marcasactivas();
            res = lg.GetData_listamarcasactivas();
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void productosexistentes()
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.ProductoExistenteTableAdapter lg = new DataSet1TableAdapters.ProductoExistenteTableAdapter();
            R_productoexistente reporte = new R_productoexistente();
            res = lg.GetData_productosexistentes();
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void proveedoresactivos()
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.proveedorTableAdapter lg = new DataSet1TableAdapters.proveedorTableAdapter();
            R_proveedoresactivos reporte = new R_proveedoresactivos();
            res = lg.GetData_proveedoresactivos();
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void bodegasactivas()
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.bodegaTableAdapter lg = new DataSet1TableAdapters.bodegaTableAdapter();
            R_bodegasactivas reporte = new R_bodegasactivas();
            res = lg.GetData_bodegasactivas();
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void seriesactivas()
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.SeriesActivasTableAdapter lg = new DataSet1TableAdapters.SeriesActivasTableAdapter();
            R_seriesactivas reporte = new R_seriesactivas();
            res = lg.GetData_seriesactivas();
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void productosenbodega(int nomBo)
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.ListadeProductosenBodegaTableAdapter lg = new DataSet1TableAdapters.ListadeProductosenBodegaTableAdapter();
            R_productosenbodega reporte = new R_productosenbodega();
            res = lg.GetData_listadeproductosenbodega(nomBo);
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void comprasaunproveedor(int id)
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.ComprasaunProveedorTableAdapter lg = new DataSet1TableAdapters.ComprasaunProveedorTableAdapter();
            R_Comprasaunproveedor reporte = new R_Comprasaunproveedor();
            res = lg.GetData_compraaproveedor(id);
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void contactosdeproveedor(int id)
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.ContactodeproveedorTableAdapter lg = new DataSet1TableAdapters.ContactodeproveedorTableAdapter();
            R_contactodeproveedor reporte = new R_contactodeproveedor();
            res = lg.GetData_contactosdeproveedor(id);
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void historialexistenciaproducto(int bo, int pro)
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.HistorialexistenciaProductoenBodegaTableAdapter lg = new DataSet1TableAdapters.HistorialexistenciaProductoenBodegaTableAdapter();
            R_historialexistenciaproductoenbodega reporte = new R_historialexistenciaproductoenbodega();
            res = lg.GetData_historialexistenciaproducto(bo, pro);
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void historialprecioproducto(int idpro)
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.historialprecioproductoTableAdapter lg = new DataSet1TableAdapters.historialprecioproductoTableAdapter();
            R_historialprecioproducto reporte = new R_historialprecioproducto();
            res = lg.GetData_historialprecioproducto(idpro);
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void facturasparauncliente(int idcli)
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.facturasdeunclienteTableAdapter lg = new DataSet1TableAdapters.facturasdeunclienteTableAdapter();
            
            R_facturasdeuncliente reporte = new R_facturasdeuncliente();

            res = lg.GetData_facturasdeuncliente(idcli);
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void compra(int iden)
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.CompraTableAdapter lg = new DataSet1TableAdapters.CompraTableAdapter();
            R_compra reporte = new R_compra();
            res = lg.GetData_compra(iden);
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void comprapornumero(int idbod, int noDo)
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.ComprapornumeroTableAdapter lg = new DataSet1TableAdapters.ComprapornumeroTableAdapter();
            R_compra reporte = new R_compra();
            res = lg.GetData_comprapornumero(idbod, noDo);
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void comprasentrefechas(DateTime f_i, DateTime f_f)
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.ComprasentrefechasTableAdapter lg = new DataSet1TableAdapters.ComprasentrefechasTableAdapter();
            R_comprasentrefechas reporte = new R_comprasentrefechas();
            res = lg.GetData_comprasentrefehas(f_i, f_f);
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void movimientosentrefechas(DateTime f_i, DateTime f_f)
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.movimientosentrefechasTableAdapter lg = new DataSet1TableAdapters.movimientosentrefechasTableAdapter();
            R_movimientosentrefechas reporte = new R_movimientosentrefechas();
            res = lg.GetData_movimientosentrefechas(f_i, f_f);
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void factura(int iden)
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.FacturaTableAdapter lg = new DataSet1TableAdapters.FacturaTableAdapter();
            R_factura reporte = new R_factura();
            res = lg.GetData_factura(iden);
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void facturapornumero(int idse, int nodo)
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.facturapornumeroTableAdapter lg = new DataSet1TableAdapters.facturapornumeroTableAdapter();
            R_factura reporte = new R_factura();
            res = lg.GetData_facturapornumero(idse, nodo);
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void facturasentrefechas(DateTime f_i, DateTime f_f)
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.FacturasentrefechasTableAdapter lg = new DataSet1TableAdapters.FacturasentrefechasTableAdapter();
            R_facturasentrefechas reporte = new R_facturasentrefechas();
            res = lg.GetData_facturaentrefechas(f_i, f_f);
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }

        public void cortedecaja()
        {
            DataTable res = new DataTable();
            DataSet1TableAdapters.CorteDeCajaTableAdapter lg = new DataSet1TableAdapters.CorteDeCajaTableAdapter();
            R_CorteDeCaja reporte = new R_CorteDeCaja();
            res = lg.GetData_cortedecaja();
            reporte.SetDataSource(res);
            crystalReportViewer_reportes.ReportSource = reporte;
        }
    }
}
