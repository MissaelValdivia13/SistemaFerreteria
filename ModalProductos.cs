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
    public partial class ModalProductos : Form
    {
        private ProductoCN productoCN = new ProductoCN();
        private string opcion = "";
        string id = "", nombre = "";

        // Definir un evento que enviará los datos al formulario padre
        public event Action<string, string> ProductoSeleccionado;
        public ModalProductos()
        {
            InitializeComponent();
        }

        private void ModalProductos_Load(object sender, EventArgs e)
        {

        }

        private void RestablecerBotones()
        {
            // Restablecer el estilo de los botones
            btnIdProducto.BackColor = Color.White;
            btnIdProducto.ForeColor = Color.Black;

            btnCategoria.BackColor = Color.White;
            btnCategoria.ForeColor = Color.Black;

            btnNombre.BackColor = Color.White;
            btnNombre.ForeColor = Color.Black;
        }

        private void btnIdProvedor_Click(object sender, EventArgs e)
        {
            opcion = "id";
            activarBusqueda(true);
            RestablecerBotones(); 
            btnIdProducto.BackColor = Color.FromArgb(101, 113, 117);
            btnIdProducto.ForeColor = Color.FromArgb(229, 232, 232);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            opcion = "concepto";
            activarBusqueda(true);
            RestablecerBotones(); 
            btnCategoria.BackColor = Color.FromArgb(101, 113, 117);
            btnCategoria.ForeColor = Color.FromArgb(229, 232, 232);
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            opcion = "nombre";
            activarBusqueda(true);
            RestablecerBotones(); 
            btnNombre.BackColor = Color.FromArgb(101, 113, 117);
            btnNombre.ForeColor = Color.FromArgb(229, 232, 232);
        }

        private void activarBusqueda(Boolean opcion)
        {
            gbBusqueda.Enabled = opcion;
        }


        private void llenarDtw(string valor)
        {
            DataSet ds = productoCN.ConsultaProd(opcion, valor);
            if (ds.Tables.Count > 0)
            {
                dtwProducto.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar");
            }
            dtwProducto.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void txtIdProducto_KeyUp(object sender, KeyEventArgs e)
        {
            llenarDtw(txtIdProducto.Text);
        }

        private void dtwProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = dtwProducto.Rows[e.RowIndex].Cells[0].Value.ToString();
                nombre = dtwProducto.Rows[e.RowIndex].Cells[2].Value.ToString();
                btnAceptar.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtwProducto.DataSource = null;
            txtIdProducto.Clear();
            RestablecerBotones();
            gbBusqueda.Enabled = false;
            btnAceptar.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ProductoSeleccionado != null && !string.IsNullOrEmpty(id))
            {
                ProductoSeleccionado(id, nombre);
            }

            this.Close();
        }
    }
}
