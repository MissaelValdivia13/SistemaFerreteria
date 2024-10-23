using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFerreteria
{
    public partial class frmCobros : Form
    {
        CobroCN cobro = new CobroCN();
        VentasCN venta = new VentasCN();
        string total = "";
        private int idEmpleado;
        public frmCobros(int idEmpleado)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                ModalClientes modal = new ModalClientes();
                modal.ClienteSeleccionado += (id, nombre, telefono, domicilio, saldo) =>
                {
                    txtIdCliente.Text = id;
                    txtContacto.Text = nombre;
                    txtTelefono.Text = telefono;
                    txtDomicilio.Text = domicilio;
                    txtSaldoCliente.Text = saldo;
                    if (id != "" && nombre != "")
                    {
                        txtCantidad.Enabled = true;
                    }
                };
                modal.StartPosition = FormStartPosition.CenterScreen;
                modal.ShowDialog();
                gbProducto.Enabled = true;
                LlenarComboBoxVentas(Convert.ToInt32(txtIdCliente.Text));
            }catch(Exception ex)
            {

            }
        }

        private void frmCobros_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            habilitarGb(true);
            txtIdVenta.Text = cobro.nuevaCobro().ToString();
        }

        private void habilitarGb(Boolean opcion)
        {
            gbCompra.Enabled = opcion;
            gbCliente.Enabled = opcion;
        }

        public void LlenarComboBoxVentas(int idCliente)
        {
            DataSet ds = cobro.ObtenerVentasPorCliente(idCliente);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                cboIdVenta.DataSource = ds.Tables[0];
                cboIdVenta.DisplayMember = "IdVenta";
                cboIdVenta.ValueMember = "IdVenta"; 
            }
            else
            {
                MessageBox.Show("No se encontraron ventas para el cliente seleccionado.");
            }
        }

        private void cboIdVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarDatos();
        }


        private void llenarDatos()
        {
            DataSet ds = venta.ObtenerVentaPorId(Convert.ToInt32(cboIdVenta.Text));

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                txtEmpleado.Text = row["Nombre"].ToString();  
                txtFecha.Text = row["Fecha"].ToString();
                txtTotal.Text = row["Total"].ToString();
                txtSaldo.Text = row["Saldo"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar");
            }
            llenarDtw();
        }

        private void llenarDtw()
        {
            dtwProveedores.DataSource = null;
            DataSet dsx = venta.consultaDetalleVenta(Convert.ToInt32(cboIdVenta.Text));
            if (dsx.Tables.Count > 0)
            {
                dtwProveedores.DataSource = dsx.Tables[0];
                
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar");
            }
            dtwProveedores.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            double Total = 0;
            Total = Convert.ToDouble(txtSaldo.Text);
            double cambio = 0;
            if (double.TryParse(txtCantidad.Text, out double cantidadPagada))
            {
                if (cantidadPagada >= Total)
                {
                    cambio = cantidadPagada - Total;
                    MessageBox.Show("Cambio: " + cambio);
                    cambio = 0;
                }
                else
                {
                    cambio = Total - cantidadPagada;
                }
            }
            Total = Convert.ToDouble(txtTotal.Text);
            Char estado = 'C';

            if (cambio == 0)
            {
                estado = 'P';
                cambio = Convert.ToDouble(txtSaldo.Text);
                MessageBox.Show("" + cambio);
            }
            try
            {
                cobro.RealizarCobro(Convert.ToInt32(txtIdCliente.Text), Convert.ToInt32(cboIdVenta.Text), cambio,Convert.ToDouble(txtCantidad.Text), idEmpleado);
                limpiarCampos();
                habilitarGb(false);
                gbProducto.Enabled = false;
                MessageBox.Show("Se guardó correctamente el cobro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex){
                MessageBox.Show("No se pudo guardar correctamente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void limpiarCampos()
        {
            txtCantidad.Text = "";
            txtContacto.Text = "";
            txtDomicilio.Text = "";
            txtIdCliente.Text = "";
            txtIdVenta.Text = "";
            cboIdVenta.Text = "";
            txtSaldo.Text = "";
            txtTelefono.Text = "";
            txtTotal.Text = "";
            dtwProveedores.DataSource = null;
            txtSaldoCliente.Text = "";
            txtFecha.Text = "";
            txtEmpleado.Text = "";
        }

        private void gbCliente_Enter(object sender, EventArgs e)
        {

        }

        private bool EsCarácterVálido(char caracter, TextBox textBox)
        {
            if (char.IsControl(caracter) || char.IsDigit(caracter) || caracter == '.')
            {
                if (caracter == '.' && textBox.Text.IndexOf('.') > -1)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!EsCarácterVálido(e.KeyChar, sender as TextBox))
            {
                e.Handled = true;
            }
        }
    }
}
