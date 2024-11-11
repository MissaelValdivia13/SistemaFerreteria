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
    public partial class ModalClientes : Form
    {
        ClienteCN cliente =  new ClienteCN();
        string opcion = "id", id = "", nombre = "", telefono= "", domicilio= "", saldo = "";
        public event Action<string, string, string, string, string> ClienteSeleccionado;

        private void RestablecerBotones()
        {
            btnIdCliente.BackColor = Color.White;
            btnIdCliente.ForeColor = Color.Black;

            btnNombre.BackColor = Color.White;
            btnNombre.ForeColor = Color.Black;

            btnTelefono.BackColor = Color.White;
            btnTelefono.ForeColor = Color.Black;
        }
        public ModalClientes()
        {
            InitializeComponent();

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            opcion = "proveedor";
            activarBusqueda(true);
            RestablecerBotones();
            btnNombre.BackColor = Color.FromArgb(101, 113, 117);
            btnNombre.ForeColor = Color.FromArgb(229, 232, 232);
        }

        private void btnIdCliente_Click(object sender, EventArgs e)
        {
            opcion = "id";
            activarBusqueda(true);
            RestablecerBotones();
            btnIdCliente.BackColor = Color.FromArgb(101, 113, 117);
            btnIdCliente.ForeColor = Color.FromArgb(229, 232, 232);
        }

        private void activarBusqueda(Boolean opcion)
        {
            gbBusqueda.Enabled = opcion;
        }

        private void ModalClientes_Load(object sender, EventArgs e)
        {
            llenarDtw("");
        }

        private void dtwCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtwCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = dtwCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
                nombre = dtwCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                telefono = dtwCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
                domicilio = dtwCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
                saldo = dtwCliente.Rows[e.RowIndex].Cells[5].Value.ToString();
                btnAceptar.Enabled = true;
            }
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            opcion = "factura";
            activarBusqueda(true);
            RestablecerBotones();
            btnTelefono.BackColor = Color.FromArgb(101, 113, 117);
            btnTelefono.ForeColor = Color.FromArgb(229, 232, 232);
        }

        private void txtIdProducto_KeyUp(object sender, KeyEventArgs e)
        {
            llenarDtw(txtIdProducto.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ClienteSeleccionado != null && !string.IsNullOrEmpty(id))
            {
                ClienteSeleccionado(id, nombre, telefono, domicilio, saldo);
            }

            this.Close();
        }

        private void llenarDtw(string valor)
        {
            //consultaClientesD
            //consultaClientesConSaldo
            //DataSet ds = cliente.consultaClientesD(opcion, valor);
            DataSet ds = cliente.consultaClientesConSaldo(opcion, valor);
            if (ds.Tables.Count > 0)
            {
                dtwCliente.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar");
            }
            dtwCliente.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
