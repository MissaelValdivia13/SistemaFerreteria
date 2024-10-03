using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using CapaNegocio;

namespace SistemaFerreteria
{
    public partial class frmCompras : Form
    {
        ComprasCN compra = new ComprasCN();
        double sub = 0, total = 0, iva = 0;
        public frmCompras()
        {
            InitializeComponent();
        }

        public frmCompras(string id, string contacto, string empresa)
        {
            InitializeComponent();
            txtIdProveedor.Text = id;
            txtEmpresa.Text = empresa;
            txtContacto.Text = contacto;
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ModalProveedores modal = new ModalProveedores();

            modal.ProveedorSeleccionado += (id, empresa, contacto) =>
            {
                txtIdProveedor.Text = id;
                txtEmpresa.Text = empresa;
                txtContacto.Text = contacto;
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
                    if ( valorId == txtIdProd.Text)
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
                    double subtotal = Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtCosto.Text);
                    dtwProducto.Rows.Add(txtIdProd.Text, txtNombre.Text, txtCantidad.Text, txtCosto.Text, subtotal, imagen);
                    sub = sub + (Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtCosto.Text));

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
            calcularTotales();
            limpiarCamposAñadir();
        }


        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            ModalProductos modal = new ModalProductos();
            modal.ProductoSeleccionado += (id, nombre) =>
            {
                txtIdProd.Text = id;
                txtNombre.Text = nombre;
                if(id != "" && nombre != "")
                {
                    txtCantidad.Enabled = true;
                    txtCosto.Enabled = true;
                }
            };
            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.ShowDialog();
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            activarAñadir();
        }

        private void activarAñadir()
        {
            var var = !string.IsNullOrEmpty(txtCantidad.Text) &&
                      !string.IsNullOrEmpty(txtCosto.Text);
            btnAñadir.Enabled = var;
        }

        private void txtCosto_KeyUp(object sender, KeyEventArgs e)
        {
            activarAñadir();
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
                    calcularTotales();
                }
            }
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            txtIdCompra.Text = Convert.ToString(compra.nuevaCompra());
            habilitarGb(true);
        }

        private void limpiarCamposAñadir()
        {
            txtIdProd.Text = "";
            txtCosto.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtCantidad.Enabled = false;
            txtCosto.Enabled = false;
            txtNombre.Enabled = false;
            txtIdProd.Enabled = false;
            btnAñadir.Enabled = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("IdProducto", typeof(int));
                dataTable.Columns.Add("Cantidad", typeof(int));
                dataTable.Columns.Add("Costo", typeof(decimal));

                foreach (DataGridViewRow row in dtwProducto.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataRow dataRow = dataTable.NewRow();

                        dataRow["IdProducto"] = row.Cells[0].Value ?? DBNull.Value;
                        dataRow["Cantidad"] = row.Cells[2].Value ?? DBNull.Value;
                        dataRow["Costo"] = row.Cells[3].Value ?? DBNull.Value;

                        dataTable.Rows.Add(dataRow);
                    }
                }

                string fecha = $"{dtpfecha.Value.Year}-{dtpfecha.Value.Month:D2}-{dtpfecha.Value.Day:D2}";
                int idCompra = Convert.ToInt32(txtIdCompra.Text);
                compra.EnviarCompraYDetalle(Convert.ToInt32(txtIdProveedor.Text), txtFactura.Text, fecha, Convert.ToDouble(txtIva.Text), Convert.ToDouble(txtSubtotal.Text), dataTable);

                limpiar();
                limpiarCamposAñadir();
                habilitarGb(false);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de SQL: {ex.Message}\nCódigo de error: {ex.Number}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void calcularTotales()
        {
            iva = sub * 0.16;
            total = iva + sub;
            txtSubtotal.Text = sub.ToString();
            txtIva.Text = iva.ToString();
            txtTotal.Text = total.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            limpiarCamposAñadir();
            habilitarGb(false);
        }

        private void habilitarGb(Boolean opcion)
        {
            gbCompra.Enabled = opcion;
            gbProducto.Enabled = opcion;
            gbProveedor.Enabled = opcion;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!EsCarácterVálido(e.KeyChar, sender as TextBox))
            {
                e.Handled = true; 
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!EsCarácterVálido(e.KeyChar, sender as TextBox))
            {
                e.Handled = true; 
            }
        }

        private void limpiar()
        {
            txtIdCompra.Text = "";
            txtFactura.Text = "";
            txtIdProveedor.Text = "";
            txtIva.Text = "";
            txtSubtotal.Text = "";
            txtTotal.Text = "";
            txtNombre.Text = "";
            txtEmpresa.Text = "";
            txtContacto.Text = "";
            dtwProducto.Rows.Clear();
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

    }
}
