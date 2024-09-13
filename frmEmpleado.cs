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
    public partial class frmEmpleado : Form
    {
        EmpleadoNC empleado = new EmpleadoNC();

        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            llenarData();
        }

        private void llenarData()
        {
            DataSet ds = empleado.consultaEmpleados();

            if (ds.Tables.Count > 0)
            {
                dtwEmpleado.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar.");
            }
            dtwEmpleado.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            cboPuesto.Text = "";
            txtIdEmpleado.Text = "";
        }
        private void habilitarDesabilitar(Boolean opcion)
        {
            txtTelefono.Enabled = opcion;
            txtNombre.Enabled = opcion;
            cboPuesto.Enabled = opcion;
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            habilitarDesabilitar(true);
            txtIdEmpleado.Text = Convert.ToString(empleado.nuevoEmpleado());
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (cboPuesto.Text != "" || cboPuesto.Text != null)
            {
                empleado.subeEmpleado(txtNombre.Text, cboPuesto.Text, txtTelefono.Text);
                limpiarCampos();
                habilitarDesabilitar(false);
                llenarData();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            habilitarDesabilitar(false);
        }
    }
}
