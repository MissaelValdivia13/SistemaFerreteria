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
    public partial class frmCliente : Form
    {
        ClienteCN cliente = new ClienteCN();

        public frmCliente()
        {
            InitializeComponent();
        }


        private void frmCliente_Load(object sender, EventArgs e)
        {
            DataSet ds = cliente.consultaClientes();

            if (ds.Tables.Count > 0)
            {
                dtwClientes.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar.");
            }
            dtwClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            cliente.insertaCliente(txtNombre.Text, txtTelefono.Text, txtEmail.Text, txtDomicilio.Text);
            frmCliente_Load(sender,e);
            habilitarDesabilitar(false);
            limpiarCampos();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            txtIdCliente.Text = Convert.ToString(cliente.nuevoCLiente());
            habilitarDesabilitar(true);
        }

        private void habilitarDesabilitar(Boolean opcion)
        {
            txtDomicilio.Enabled = opcion;
            txtEmail.Enabled = opcion;
            txtNombre.Enabled = opcion;
            txtTelefono.Enabled = opcion;
        }

        private void limpiarCampos()
        {
            txtDomicilio.Text = "";
            txtEmail.Text = "";
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
