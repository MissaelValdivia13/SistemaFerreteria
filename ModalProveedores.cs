using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;

namespace SistemaFerreteria
{
    public partial class ModalProveedores : Form
    {
        private ProveedoresCN proveedores = new ProveedoresCN();
        string opcion = "id", id = "", nombre = "", empresa = "";

        public event Action<string, string, string> ProveedorSeleccionado;

        public ModalProveedores()
        {
            InitializeComponent();
        }

        private void RestablecerBotones()
        {
            btnIdProvedor.BackColor = Color.White;
            btnIdProvedor.ForeColor = Color.Black;

            btnEmpresa.BackColor = Color.White;
            btnEmpresa.ForeColor = Color.Black;

            btnContacto.BackColor = Color.White;
            btnContacto.ForeColor = Color.Black;
        }

        private void btnIdProvedor_Click(object sender, EventArgs e)
        {
            opcion = "id";
            activarBusqueda(true);
            RestablecerBotones(); 
            btnIdProvedor.BackColor = Color.FromArgb(101, 113, 117);
            btnIdProvedor.ForeColor = Color.FromArgb(229, 232, 232);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            opcion = "empresa";
            activarBusqueda(true);
            RestablecerBotones(); 
            btnEmpresa.BackColor = Color.FromArgb(101, 113, 117);
            btnEmpresa.ForeColor = Color.FromArgb(229, 232, 232);
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            opcion = "contacto";
            activarBusqueda(true);
            RestablecerBotones(); 
            btnContacto.BackColor = Color.FromArgb(101, 113, 117);
            btnContacto.ForeColor = Color.FromArgb(229, 232, 232);
        }


        private void activarBusqueda(Boolean opcion)
        {
            gbBusqueda.Enabled = opcion;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            llenarDtw(txtIdProducto.Text);  
        }

        private void llenarDtw(string valor)
        {
            DataSet ds = proveedores.consultaProveedor(opcion, valor);
            if (ds.Tables.Count > 0)
            {
                dtwProveedores.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar");
            }
            dtwProveedores.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void txtIdProducto_KeyUp(object sender, KeyEventArgs e)
        {
            llenarDtw(txtIdProducto.Text);
        }

        private void ModalProveedores_Load(object sender, EventArgs e)
        {
            llenarDtw(txtIdProducto.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtwProveedores.DataSource = null;
            txtIdProducto.Clear();
            RestablecerBotones();
            gbBusqueda.Enabled = false;
            btnAceptar.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ProveedorSeleccionado != null && !string.IsNullOrEmpty(id))
            {
                ProveedorSeleccionado(id, empresa, nombre);
            }

            this.Close();
        }

        private void dtwProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = dtwProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
                empresa = dtwProveedores.Rows[e.RowIndex].Cells[1].Value.ToString();
                nombre = dtwProveedores.Rows[e.RowIndex].Cells[2].Value.ToString();
                btnAceptar.Enabled = true;
            }
        }
    }
}
