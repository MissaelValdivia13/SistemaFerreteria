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
    public partial class frmProveedor : Form
    {
        ProveedoresCN proveedores = new ProveedoresCN();
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void limpiarCampos()
        {
            txtIdProveedor.Text = "";
            txtContacto.Text = "";
            txtDomicilio.Text = "";
            txtEmpresa.Text = "";
            txtTelefono.Text = "";
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            habilitarDeshabilitar(true);
            txtIdProveedor.Text = Convert.ToString(proveedores.nuevoProveedor());
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            proveedores.subeProveedor(txtEmpresa.Text, txtContacto.Text, txtTelefono.Text, txtDomicilio.Text);
            limpiarCampos();
            frmProveedor_Load(sender, e);
            habilitarDeshabilitar(false);
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            DataSet ds = proveedores.consultaProveedores();
            if(ds.Tables.Count > 0)
            {
                dtwProveedores.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar");
            }
            dtwProveedores.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void habilitarDeshabilitar(Boolean opcion)
        {
            txtContacto.Enabled = opcion;
            txtDomicilio.Enabled = opcion;
            txtEmpresa.Enabled = opcion;
            txtTelefono.Enabled = opcion;
        }
    }
}
