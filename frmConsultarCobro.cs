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
    public partial class frmConsultarCobro : Form
    {
        string opcion = "idCobro";
        private CobroCN cobro = new CobroCN();
        public frmConsultarCobro()
        {
            InitializeComponent();
        }

        private void btnIdProducto_Click(object sender, EventArgs e)
        {
            opcion = "idCobro";
            activarBusqueda(true);
            RestablecerBotones();
            btnIdProducto.BackColor = Color.FromArgb(101, 113, 117);
            btnIdProducto.ForeColor = Color.FromArgb(229, 232, 232);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            opcion = "fecha";
            activarBusqueda(true);
            RestablecerBotones();
            btnEmpresa.BackColor = Color.FromArgb(101, 113, 117);
            btnEmpresa.ForeColor = Color.FromArgb(229, 232, 232);
        }

        private void Fecha_Click(object sender, EventArgs e)
        {
            opcion = "nombreCliente";
            activarBusqueda(true);
            RestablecerBotones();
            Fecha.BackColor = Color.FromArgb(101, 113, 117);
            Fecha.ForeColor = Color.FromArgb(229, 232, 232);
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

        private void activarBusqueda(Boolean opcion)
        {
            gbBusqueda.Enabled = opcion;
        }

        private void txtIdProducto_KeyUp(object sender, KeyEventArgs e)
        {
            llenarDtw(txtIdProducto.Text);

        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {
        }

        private void llenarDtw(string valor)
        {
            DataSet ds = cobro.ConsultarCobrosDinamicamente(opcion,valor);
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

        private void frmConsultarCobro_Load(object sender, EventArgs e)
        {
            llenarDtw(txtIdProducto.Text);
        }
    }
}
