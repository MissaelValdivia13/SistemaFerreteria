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
    public partial class frmConsultarVentas : Form
    {
        string opcion = "id";

        private VentasCN VentasCN = new VentasCN();
        public frmConsultarVentas()
        {
            InitializeComponent();
        }

        private void btnIdProducto_Click(object sender, EventArgs e)
        {
            opcion = "id";
            activarBusqueda(true);
            RestablecerBotones();
            btnIdProducto.BackColor = Color.FromArgb(101, 113, 117);
            btnIdProducto.ForeColor = Color.FromArgb(229, 232, 232);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            opcion = "cliente";
            activarBusqueda(true);
            RestablecerBotones();
            btnEmpresa.BackColor = Color.FromArgb(101, 113, 117);
            btnEmpresa.ForeColor = Color.FromArgb(229, 232, 232);
        }

        private void Fecha_Click(object sender, EventArgs e)
        {
            opcion = "empleado";
            activarBusqueda(true);
            RestablecerBotones();
            Fecha.BackColor = Color.FromArgb(101, 113, 117);
            Fecha.ForeColor = Color.FromArgb(229, 232, 232);
        }

        private void activarBusqueda(Boolean opcion)
        {
            gbBusqueda.Enabled = opcion;
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

        private void llenarDtw(string valor)
        {
            try
            {
                DataSet ds = VentasCN.consultaVentas(opcion, valor);
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error: " + ex.Message);
                RespaldoCN respaldo = new RespaldoCN();
                respaldo.InsertarError(1, "frmConsultarVenta", ex.Message);
            }
        }

        private void frmConsultarVentas_Load(object sender, EventArgs e)
        {
            llenarDtw("");
        }

        private void txtIdProducto_KeyUp(object sender, KeyEventArgs e)
        {
            llenarDtw(txtIdProducto.Text);
        }

        private void dtwCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = Convert.ToInt32(dtwCompra.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTotal.Text = dtwCompra.Rows[e.RowIndex].Cells[4].Value.ToString();
                llenarDetalleCompra(id);
                dtwDetalleCompra.Visible = true;
            }
        }

        public void llenarDetalleCompra(int id)
        {
            DataSet ds = VentasCN.consultaDetalleVenta(id);
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

        private void dtwCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbBusqueda_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
