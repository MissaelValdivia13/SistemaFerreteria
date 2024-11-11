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
    public partial class ModalEmpleados : Form
    {
        EmpleadoNC empleado = new EmpleadoNC();
        public ModalEmpleados()
        {
            InitializeComponent();
        }
        string opcion = "id", id = "", nombre = "", telefono = "", domicilio = "";
        public event Action<string, string, string, string> ClienteSeleccionado;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ClienteSeleccionado != null && !string.IsNullOrEmpty(id))
            {
                ClienteSeleccionado(id, nombre, telefono, domicilio);
            }

            this.Close();
        }

        private void ModalEmpleados_Load(object sender, EventArgs e)
        {
            llenarDtw();
        }
        private void llenarDtw()
        {
            DataSet ds = empleado.consultaEmpleados();
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

        private void dtwCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = dtwCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
                nombre = dtwCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                telefono = dtwCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
                domicilio = dtwCliente.Rows[e.RowIndex].Cells[3].Value.ToString();
                btnAceptar.Enabled = true;
            }
        }
    }
}
