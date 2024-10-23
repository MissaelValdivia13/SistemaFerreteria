using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace SistemaFerreteria
{
    public partial class Ventas : Form
    {
        private double sub = 0;
        private string opcion;
        private int idEmpleado;
        VentasCN venta = new VentasCN();

        public Ventas(string opcion, int idEmpleado)
        {
            InitializeComponent();
            this.opcion = opcion;
            this.idEmpleado = idEmpleado;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {

            ModalProductos modal = new ModalProductos();
            modal.ProductoSeleccionado += (id, nombre, precio) =>
            {
                txtIdProd.Text = id;
                txtNombre.Text = nombre;
                txtPrecio.Text = precio;
                if (id != "" && nombre != "" && precio != "")
                {
                    txtCantidad.Enabled = true;
                    txtPrecio.Enabled = true;
                }
            };
            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.ShowDialog();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
            txtIdVenta.Text =  venta.nuevaVenta().ToString();
            sub = 0;
        }

        private void habilitarCampos(Boolean opcion)
        {
            gbProducto.Enabled = opcion;
            gbCliente.Enabled = opcion;
            gbCompra.Enabled = opcion;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ModalClientes modal = new ModalClientes();
            modal.ClienteSeleccionado += (id, nombre, telefono, domicilio, saldo) =>
            {
                txtIdCliente.Text = id;
                txtContacto.Text = nombre;
                txtTelefono.Text = telefono;
                txtDomicilio.Text = domicilio;
                
            };
            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.ShowDialog();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            int posiciones = dtwProducto.Rows.Count - 1, auxiliar = -1;
            bool existe = false;

            if (posiciones != -1)
            {
                for (int i = 0; i < posiciones; i++)
                {
                    string valorId = dtwProducto.Rows[i].Cells[0].Value.ToString();
                    if (valorId == txtIdProd.Text)
                    {
                        existe = true;
                        auxiliar = i;
                        break;
                    }
                }
            }

            if (!existe)
            {
                DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)dtwProducto.Columns["Eliminar"];
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

                string rutaImagen = "C:\\Users\\missa\\Downloads\\delete.png";
                if (System.IO.File.Exists(rutaImagen))
                {
                    Image imagen = Image.FromFile(rutaImagen);
                    double subtotal = Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                    dtwProducto.Rows.Add(txtIdProd.Text, txtNombre.Text, txtCantidad.Text, txtPrecio.Text, subtotal, imagen);
                    sub = sub + (Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text));

                }
            }
            else if (existe)
            {
                int nuevaCantidad = Convert.ToInt32(dtwProducto.Rows[auxiliar].Cells[2].Value) + Convert.ToInt32(txtCantidad.Text);
                dtwProducto.Rows[auxiliar].Cells[2].Value = nuevaCantidad;

                double nuevoSubtotal = nuevaCantidad * Convert.ToDouble(dtwProducto.Rows[auxiliar].Cells[3].Value);
                dtwProducto.Rows[auxiliar].Cells[4].Value = nuevoSubtotal;
                sub = sub + (Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(dtwProducto.Rows[auxiliar].Cells[3].Value));
            }
            limpiarCamposAñadir();
            txtTotal.Text = Convert.ToString(sub);
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            activarAñadir();
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

        private void activarAñadir()
        {
            var var = !string.IsNullOrEmpty(txtCantidad.Text) &&
                      !string.IsNullOrEmpty(txtPrecio.Text);
            btnAñadir.Enabled = var;
        }

        private void txtCosto_KeyUp(object sender, KeyEventArgs e)
        {
            activarAñadir();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!EsCarácterVálido(e.KeyChar, sender as TextBox))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!EsCarácterVálido(e.KeyChar, sender as TextBox))
            {
                e.Handled = true;
            }
        }

        private void dtwProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("¿Deseas eliminar este producto de la compra?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    sub = sub - (Convert.ToInt32(dtwProducto.Rows[e.RowIndex].Cells[2].Value) * Convert.ToDouble(dtwProducto.Rows[e.RowIndex].Cells[3].Value));
                    dtwProducto.Rows.RemoveAt(e.RowIndex);
                    txtTotal.Text = sub.ToString();
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(txtTotal.Text);
            Char estado = 'C';
            FormPago formPago = new FormPago(total);
            var result = formPago.ShowDialog();

            double cambio = formPago.Cambio;

            if(cambio == 0)
            {
                estado = 'P';
            }
            MessageBox.Show("" + cambio);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("IdProducto", typeof(int));
            dataTable.Columns.Add("Cantidad", typeof(int));
            dataTable.Columns.Add("Precio", typeof(decimal));

            foreach (DataGridViewRow row in dtwProducto.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["IdProducto"] = row.Cells[0].Value ?? DBNull.Value;
                    dataRow["Cantidad"] = row.Cells[2].Value ?? DBNull.Value;
                    dataRow["Precio"] = row.Cells[3].Value ?? DBNull.Value;
                    dataTable.Rows.Add(dataRow);
                }
            }

            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            int idCliente = Convert.ToInt32(txtIdCliente.Text);

            Boolean aux = venta.EnviarVentaYDetalle(idCliente, idEmpleado, fecha, total,cambio,estado, dataTable, opcion);

            if (aux)
            {
                MessageBox.Show("No se pudo guardar correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se guardó correctamente la venta", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                limpiarCamposAñadir();
                habilitarGb(false);
            }
        }





        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!EsCarácterVálido(e.KeyChar, sender as TextBox))
            {
                e.Handled = true;
            }
        }

        private void limpiarCamposAñadir()
        {
            txtIdProd.Text = "";
            txtPrecio.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtCantidad.Enabled = false;
            txtPrecio.Enabled = false;
            txtNombre.Enabled = false;
            txtIdProd.Enabled = false;
            btnAñadir.Enabled = false;
        }

        private void limpiar()
        {
            txtCantidad.Text = "";
            txtContacto.Text = "";
            txtDomicilio.Text = "";
            txtIdCliente.Text = "";
            txtIdVenta.Text = "";
            txtIdProd.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtTelefono.Text = "";
            txtTotal.Text = "";
            dtwProducto.Rows.Clear();
        }

        private void habilitarGb(Boolean opcion)
        {
            gbCompra.Enabled = opcion;
            gbProducto.Enabled = opcion;
            gbCliente.Enabled = opcion;
        }
    }
}
