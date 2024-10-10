using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using CapaNegocio;
using Color = System.Drawing.Color;

namespace SistemaFerreteria
{
    public partial class frmConsultaCompras : Form
    {
        string opcion = "id";
        private ComprasCN compra = new ComprasCN();

        public frmConsultaCompras()
        {
            InitializeComponent();
        }

        private void frmConsultaCompras_Load(object sender, EventArgs e)
        {
            llenarDtw(txtIdProducto.Text);
        }

        private void RestablecerBotones()
        {
            btnIdProducto.BackColor = System.Drawing.Color.White;
            btnIdProducto.ForeColor = Color.Black;

            Fecha.BackColor = Color.White;
            Fecha.ForeColor = Color.Black;

            btnEmpresa.BackColor = Color.White;
            btnEmpresa.ForeColor = Color.Black;
        }

        

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            opcion = "fecha";
            activarBusqueda(true);
            RestablecerBotones();
            Fecha.BackColor = Color.FromArgb(101, 113, 117);
            Fecha.ForeColor = Color.FromArgb(229, 232, 232);
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            opcion = "proveedor";
            activarBusqueda(true);
            RestablecerBotones();
            btnEmpresa.BackColor = Color.FromArgb(101, 113, 117);
            btnEmpresa.ForeColor = Color.FromArgb(229, 232, 232);
        }

        private void activarBusqueda(Boolean opcion)
        {
            gbBusqueda.Enabled = opcion;
        }

        private void btnIdProducto_Click(object sender, EventArgs e)
        {
            opcion = "id";
            activarBusqueda(true);
            RestablecerBotones();
            btnIdProducto.BackColor = Color.FromArgb(101, 113, 117);
            btnIdProducto.ForeColor = Color.FromArgb(229, 232, 232);
        }

        private void txtIdProducto_KeyUp(object sender, KeyEventArgs e)
        {
            llenarDtw(txtIdProducto.Text);
        }

        private void llenarDtw(string valor)
        {
            DataSet ds = compra.consultaCompra(opcion, valor);
            if (ds.Tables.Count > 0)
            {
                dtwCompra.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar");
            }
            dtwCompra.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
                dtwCompra.DataSource = null;
                txtIdProducto.Clear();
                RestablecerBotones();
                gbBusqueda.Enabled = false;
        }

        private void dtwCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                int id = Convert.ToInt32(dtwCompra.Rows[e.RowIndex].Cells[0].Value.ToString());
                llenarDetalleCompra(id);
                dtwDetalleCompra.Visible = true;
            }
        }

        public void llenarDetalleCompra(int id)
        {
            DataSet ds = compra.consultaDetalleCompra(id);
            if (ds.Tables.Count > 0)
            {
                dtwDetalleCompra.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar");
            }
            dtwCompra.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
