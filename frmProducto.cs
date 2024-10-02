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

namespace SistemaFerreteria
{
    public partial class frmProducto : Form
    {
        private ProductoCN producto =  new ProductoCN();
        private CategoriaCN categoria = new CategoriaCN();
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            llenarDtwProducto();
            llenarCboCategorias();
        }
        
        //Agrega al txtIDProducto el id del nuevo producto
        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitarInhabilitar(true);
            txtIdProducto.Text = Convert.ToString(producto.nuevoProducto());
            btnGrabar.Enabled = true;
            btnModificar.Enabled = false;
        }

        //llena el data grid view de productos
        private void llenarDtwProducto()
        {
            DataSet data = producto.consultaProcutos();

            if(data.Tables.Count > 0)
            {
                dtwProductos.DataSource = data.Tables[0];
            }
            else
            {
                MessageBox.Show("No ay productos que mostrar");
            }
            dtwProductos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //Al presionar este boton limpia los campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            habilitarInhabilitar(false);
            limpiar();
            btnGrabar.Enabled = false;
            btnModificar.Enabled=false;
        }
        //habilita y desabilita los campos de texto
        private void habilitarInhabilitar(Boolean opcion)
        {
            txtCosto.Enabled = opcion;
            txtExistencia.Enabled = opcion;
            txtMaximo.Enabled = opcion;
            txtMinimo.Enabled = opcion;
            txtNombre.Enabled = opcion;
            txtPrecio.Enabled = opcion;
            cboCategoria.Enabled = opcion;
        }

        //Limpia los campos para que esten vacios
        private void limpiar()
        {
            txtCosto.Text = "";
            txtExistencia.Text = "";
            txtIdProducto.Text = "";
            txtMaximo.Text = "";
            txtMinimo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            cboCategoria.Text = "";
        }

        //Llena la combo de categorias con el concepto de cada categoria
        private void llenarCboCategorias()
        {
            DataSet data =  categoria.consultarCategoria();
            if (data != null && data.Tables.Count > 0)
            {
                cboCategoria.Items.Clear();

                foreach (DataRow row in data.Tables["SUBE"].Rows)
                {
                    cboCategoria.Items.Add(row[1].ToString());
                }
            }
        }

        //Graba producto en la base de datos
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            DataSet data = categoria.consultaCategoriaPorConcepto(cboCategoria.Text);
            if (data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0)
            {
                string idCategoria = Convert.ToString(data.Tables[0].Rows[0]["IdCategoria"]);
                producto.subeProducto(Convert.ToInt32(idCategoria), txtNombre.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToDouble(txtCosto.Text), Convert.ToInt32(txtExistencia.Text), Convert.ToInt32(txtMaximo.Text), Convert.ToInt32(txtMinimo.Text));
                limpiar();
                habilitarInhabilitar(false);
                llenarDtwProducto();
                btnGrabar.Enabled = false;
                btnNuevoProducto.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se encontró ninguna categoría con ese concepto.");
            }
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataSet data = categoria.consultaCategoriaPorConcepto(cboCategoria.Text);
            if (data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0)
            {
                string idCategoria = Convert.ToString(data.Tables[0].Rows[0]["IdCategoria"]);
                producto.actualizaProducto(Convert.ToInt32(txtIdProducto.Text), Convert.ToInt32(idCategoria), txtNombre.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtMaximo.Text), Convert.ToInt32(txtMinimo.Text));
                limpiar();
                habilitarInhabilitar(false);
                llenarDtwProducto();
                btnModificar.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se encontró ninguna categoría con ese concepto.");
            }
        }

        private void dtwProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                txtIdProducto.Text = dtwProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                cboCategoria.Text = dtwProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNombre.Text = dtwProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrecio.Text = dtwProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCosto.Text = dtwProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtExistencia.Text = dtwProductos.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtMaximo.Text = dtwProductos.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtMinimo.Text  = dtwProductos.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtNombre.Enabled = true;
                txtMaximo.Enabled = true;
                cboCategoria.Enabled = true;
                txtMinimo.Enabled = true;
                txtPrecio.Enabled = true;
                btnModificar.Enabled = true;
                btnGrabar.Enabled = false;
            }
        }
    }
}
