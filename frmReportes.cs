using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Microsoft.ReportingServices.Interfaces;
using System.Windows.Markup;

namespace SistemaFerreteria
{
    public partial class frmReportes : Form
    {
        ProductoCN producto = new ProductoCN();
        VentasCN venta = new VentasCN();
        ClienteCN cliente = new ClienteCN();
        ComprasCN compras = new ComprasCN();
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(pnVentas.Visible == true)
            {
                pnVentas.Visible = false;
            }
            else
            {
                pnVentas.Visible = true;
                pnClientes.Visible = false;
                pnCompras.Visible = false;
            }
        }

        private void btnRankingProductos_Click(object sender, EventArgs e)
        {
            DataSet dsRankingProductos = producto.ObtenerRankingProductos();
            rpv.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", dsRankingProductos.Tables[0]);
            rpv.LocalReport.DataSources.Add(rds);
            rpv.LocalReport.ReportPath = "C:\\Users\\missa\\OneDrive\\Documentos\\Semestre 7\\Sistemas Integrales de N Capas\\SistemaFerreteria\\Reportes\\Report1.rdlc";
            rpv.RefreshReport();
        }

        private void btnVentasPeriodo_Click_1(object sender, EventArgs e)
        {
            using (var fechaForm = new FechaSeleccionForm())
            {
                if (fechaForm.ShowDialog() == DialogResult.OK)
                {
                    string fechaInicio = fechaForm.FechaInicio.ToString("yyyy-MM-dd");
                    string fechaFin = fechaForm.FechaFin.ToString("yyyy-MM-dd");
                    ReportParameter inicio = new ReportParameter("F1", fechaInicio);
                    ReportParameter fin = new ReportParameter("F2", fechaFin);
                    DataSet dts = venta.reportePeriodo(fechaInicio, fechaFin);
                    rpv.LocalReport.DataSources.Clear();
                    ReportDataSource rds = new ReportDataSource("DataSet1", dts.Tables[0]);
                    rpv.LocalReport.DataSources.Add(rds);
                    rpv.LocalReport.ReportPath = "C:\\Users\\missa\\OneDrive\\Documentos\\Semestre 7\\Sistemas Integrales de N Capas\\SistemaFerreteria\\Reportes\\VentasPeriodo.rdlc";
                    rpv.LocalReport.SetParameters(new ReportParameter[] { inicio, fin });
                    rpv.RefreshReport();
                }
            }
        }
        //Necesita listo
        private void btnVentasEmpleadoPeriodo_Click(object sender, EventArgs e)
        {
            int idEmpleado = 0;
            string nombreEmpleado = "";
            ModalEmpleados modal = new ModalEmpleados();
            modal.ClienteSeleccionado += (id, nombre, telefono, domicilio) =>
            {
                idEmpleado = Convert.ToInt32(id);
                nombreEmpleado = nombre;

            };
            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.ShowDialog();
            if (idEmpleado != 0)
            {
                using (var fechaForm = new FechaSeleccionForm())
                {
                    if (fechaForm.ShowDialog() == DialogResult.OK)
                    {
                        string fechaInicio = fechaForm.FechaInicio.ToString("yyyy-MM-dd");
                        string fechaFin = fechaForm.FechaFin.ToString("yyyy-MM-dd");
                        ReportParameter empleado = new ReportParameter("Empleado", nombreEmpleado);
                        ReportParameter inicio = new ReportParameter("F1", fechaInicio);
                        ReportParameter fin = new ReportParameter("F2", fechaFin);
                        DataSet dts = venta.reporteEmpleadoPeriodo(nombreEmpleado, fechaInicio, fechaFin);
                        rpv.LocalReport.DataSources.Clear();
                        ReportDataSource rds = new ReportDataSource("DataSet1", dts.Tables[0]);
                        rpv.LocalReport.DataSources.Add(rds);
                        rpv.LocalReport.ReportPath = "C:\\Users\\missa\\OneDrive\\Documentos\\Semestre 7\\Sistemas Integrales de N Capas\\SistemaFerreteria\\Reportes\\VentasEmpleadoPeriodo.rdlc";
                        rpv.LocalReport.SetParameters(new ReportParameter[] { empleado, inicio, fin});
                        rpv.RefreshReport();
                    }
                }
            }
            else
            {
                MessageBox.Show("No se selecciono nigun cliente");
            }
        }

        private void btnRankingEmpleados_Click(object sender, EventArgs e)
        {
            using (var fechaForm = new FechaSeleccionForm())
            {
                if (fechaForm.ShowDialog() == DialogResult.OK)
                {
                    string fechaInicio = fechaForm.FechaInicio.ToString("yyyy-MM-dd");
                    string fechaFin = fechaForm.FechaFin.ToString("yyyy-MM-dd");
                    ReportParameter inicio = new ReportParameter("F1", fechaInicio);
                    ReportParameter fin = new ReportParameter("F2", fechaFin);
                    DataSet dts = venta.rankingVentasCliente(fechaInicio, fechaFin);
                    rpv.LocalReport.DataSources.Clear();
                    ReportDataSource rds = new ReportDataSource("DataSet1", dts.Tables[0]);
                    rpv.LocalReport.DataSources.Add(rds);
                    rpv.LocalReport.ReportPath = "C:\\Users\\missa\\OneDrive\\Documentos\\Semestre 7\\Sistemas Integrales de N Capas\\SistemaFerreteria\\Reportes\\RankingEmpleadosPeriodo.rdlc";
                    rpv.LocalReport.SetParameters(new ReportParameter[] { inicio, fin });
                    rpv.RefreshReport();
                }
            }
        }

        private void pnClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (pnClientes.Visible == true)
            {
                pnClientes.Visible = false;
            }
            else
            {
                pnClientes.Visible = true;
                pnCompras.Visible = false;
                pnVentas.Visible = false;
            }
        }

        //Necesita listo
        private void txtCobrosoCliente_Click(object sender, EventArgs e)
        {
            int idCliente = 0;
            string nomb = "", telef, domici;
            ModalClientes modal = new ModalClientes();
            modal.ClienteSeleccionado += (id, nombre, telefono, domicilio, saldo) =>
            {
                idCliente = Convert.ToInt32(id);
                nomb = nombre;
                telef = telefono;
                domici = domicilio;

            };
            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.ShowDialog();
            if (idCliente != 0)
            {
                DataSet dts = cliente.ObtenerCobrosPorCliente(idCliente);
                rpv.LocalReport.DataSources.Clear();
                ReportParameter idtxt = new ReportParameter("idCliente", idCliente.ToString());
                ReportParameter ombre = new ReportParameter("Nombre", nomb);
                ReportDataSource rds = new ReportDataSource("DataSet1", dts.Tables[0]);
                rpv.LocalReport.DataSources.Add(rds);
                rpv.LocalReport.ReportPath = "C:\\Users\\missa\\OneDrive\\Documentos\\Semestre 7\\Sistemas Integrales de N Capas\\SistemaFerreteria\\Reportes\\CobrosPorCliente.rdlc";
                rpv.LocalReport.SetParameters(new ReportParameter[] { idtxt, ombre });
                rpv.RefreshReport();
            }
        }

        private void btnClientesSaldo_Click(object sender, EventArgs e)
        {
            DataSet dts = cliente.ReporteClientesConSaldoPendiente();
            rpv.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", dts.Tables[0]);
            rpv.LocalReport.DataSources.Add(rds);
            rpv.LocalReport.ReportPath = "C:\\Users\\missa\\OneDrive\\Documentos\\Semestre 7\\Sistemas Integrales de N Capas\\SistemaFerreteria\\Reportes\\ReporteClientesSaldoP.rdlc";
            rpv.RefreshReport();
        }

        private void btnRankindDeClientes_Click(object sender, EventArgs e)
        {
            DataSet dts = cliente.RankingClientesPorTotalVentas();
            rpv.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", dts.Tables[0]);
            rpv.LocalReport.DataSources.Add(rds);
            rpv.LocalReport.ReportPath = "C:\\Users\\missa\\OneDrive\\Documentos\\Semestre 7\\Sistemas Integrales de N Capas\\SistemaFerreteria\\Reportes\\RankingClientes.rdlc";
            rpv.RefreshReport();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            if (pnCompras.Visible == true)
            {
                pnCompras.Visible = false;
            }
            else
            {
                pnCompras.Visible = true;
                pnVentas.Visible = false;
                pnClientes.Visible = false;
            }
        }

        private void btnComprasCategoria_Click(object sender, EventArgs e)
        {
            using (var fechaForm = new FechaSeleccionForm())
            {
                if (fechaForm.ShowDialog() == DialogResult.OK)
                {
                    string fechaInicio = fechaForm.FechaInicio.ToString("yyyy-MM-dd");
                    string fechaFin = fechaForm.FechaFin.ToString("yyyy-MM-dd");
                    ReportParameter inicio = new ReportParameter("F1", fechaInicio);
                    ReportParameter fin = new ReportParameter("F2", fechaFin);
                    DataSet dts = compras.ComprasPorCategoria(fechaInicio, fechaFin);
                    rpv.LocalReport.DataSources.Clear();
                    ReportDataSource rds = new ReportDataSource("DataSet1", dts.Tables[0]);
                    rpv.LocalReport.DataSources.Add(rds);
                    rpv.LocalReport.ReportPath = "C:\\Users\\missa\\OneDrive\\Documentos\\Semestre 7\\Sistemas Integrales de N Capas\\SistemaFerreteria\\Reportes\\ReporteComprasCategoria.rdlc";
                    rpv.LocalReport.SetParameters(new ReportParameter[] { inicio, fin });
                    rpv.RefreshReport();
                }
            }

        }

        private void btnComprasProveedor_Click(object sender, EventArgs e)
        {
            int idProveedor = 0;
            string emp = "";
            ModalProveedores modal = new ModalProveedores();

            modal.ProveedorSeleccionado += (id, empresa, contacto) =>
            {
                idProveedor = Convert.ToInt32(id);
                emp = empresa;
            };

            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.ShowDialog();
            if (idProveedor != 0)
            {
                using (var fechaForm = new FechaSeleccionForm())
                {
                    if (fechaForm.ShowDialog() == DialogResult.OK)
                    {
                        string fechaInicio = fechaForm.FechaInicio.ToString("yyyy-MM-dd");
                        string fechaFin = fechaForm.FechaFin.ToString("yyyy-MM-dd");
                        ReportParameter inicio = new ReportParameter("F1", fechaInicio);
                        ReportParameter fin = new ReportParameter("F2", fechaFin);
                        ReportParameter id = new ReportParameter("Id", idProveedor.ToString());
                        ReportParameter empres = new ReportParameter("Empresa", emp);
                        DataSet dts = compras.ComprasPorProveedor(fechaInicio, fechaFin, idProveedor);
                        rpv.LocalReport.DataSources.Clear();
                        ReportDataSource rds = new ReportDataSource("DataSet1", dts.Tables[0]);
                        rpv.LocalReport.DataSources.Add(rds);
                        rpv.LocalReport.ReportPath = "C:\\Users\\missa\\OneDrive\\Documentos\\Semestre 7\\Sistemas Integrales de N Capas\\SistemaFerreteria\\Reportes\\ComprasProveedor.rdlc";
                        rpv.LocalReport.SetParameters(new ReportParameter[] { inicio, fin, id, empres });
                        rpv.RefreshReport();
                    }
                }
            }
        }

        private void rpv_Load(object sender, EventArgs e)
        {

        }

        private void pnVentas_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txtProductosRentables_Click(object sender, EventArgs e)
        {
            DataSet dsRankingProductos = producto.ObtenerProductosMasRentables();
            rpv.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", dsRankingProductos.Tables[0]);
            rpv.LocalReport.DataSources.Add(rds);
            rpv.LocalReport.ReportPath = "C:\\Users\\missa\\OneDrive\\Documentos\\Semestre 7\\Sistemas Integrales de N Capas\\SistemaFerreteria\\Reportes\\ReporteProductosRentables.rdlc";
            rpv.RefreshReport();
        }

        private void txtComparacionCompras_Click(object sender, EventArgs e)
        {
            DataSet dsRankingProductos = compras.ComparacionComprasMensuales();
            rpv.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", dsRankingProductos.Tables[0]);
            rpv.LocalReport.DataSources.Add(rds);
            rpv.LocalReport.ReportPath = "C:\\Users\\missa\\OneDrive\\Documentos\\Semestre 7\\Sistemas Integrales de N Capas\\SistemaFerreteria\\Reportes\\ReporteComparacionCompras.rdlc";
            rpv.RefreshReport();
        }

        private void btnComparcionVentas_Click(object sender, EventArgs e)
        {
            DataSet dsRankingProductos = venta.ObtenerComparacionVentasMensuales();
            rpv.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", dsRankingProductos.Tables[0]);
            rpv.LocalReport.DataSources.Add(rds);
            rpv.LocalReport.ReportPath = "C:\\Users\\missa\\OneDrive\\Documentos\\Semestre 7\\Sistemas Integrales de N Capas\\SistemaFerreteria\\Reportes\\ReporteComparacionVentas.rdlc";
            rpv.RefreshReport();
        }
    }
}
