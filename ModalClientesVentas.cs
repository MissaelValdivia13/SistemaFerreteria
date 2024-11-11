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
    public partial class ModalClientesVentas : Form
    {
        ClienteCN cliente = new ClienteCN();
        string opcion = "id", id = "", nombre = "", telefono = "", domicilio = "", saldo = "";

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ClienteSeleccionado != null && !string.IsNullOrEmpty(id))
            {
                ClienteSeleccionado(id, nombre, telefono, domicilio, saldo);
            }

            this.Close();
        }

        public event Action<string, string, string, string, string> ClienteSeleccionado;
        public ModalClientesVentas()
        {
            InitializeComponent();
        }

        private void ModalClientesVentas_Load(object sender, EventArgs e)
        {
            llenarDtw("");
        }
        private void llenarDtw(string valor)
        {
            //consultaClientesD
            //consultaClientesConSaldo
            DataSet ds = cliente.consultaClientesD(opcion, valor);
            //DataSet ds = cliente.consultaClientesConSaldo(opcion, valor);
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
