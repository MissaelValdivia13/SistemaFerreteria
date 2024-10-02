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
            btnGrabar.Enabled = true;
            btnModificar.Enabled = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            proveedores.subeProveedor(txtEmpresa.Text, txtContacto.Text, txtTelefono.Text, txtDomicilio.Text);
            limpiarCampos();
            llenarDtw();
            habilitarDeshabilitar(false);
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            llenarDtw();
        }

        private void habilitarDeshabilitar(Boolean opcion)
        {
            txtContacto.Enabled = opcion;
            txtDomicilio.Enabled = opcion;
            txtEmpresa.Enabled = opcion;
            txtTelefono.Enabled = opcion;
        }

        private void dtwProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                txtIdProveedor.Text = dtwProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtEmpresa.Text = dtwProveedores.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtContacto.Text = dtwProveedores.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTelefono.Text = dtwProveedores.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDomicilio.Text = dtwProveedores.Rows[e.RowIndex].Cells[4].Value.ToString();
                btnModificar.Enabled = true;
                habilitarDeshabilitar(true);
                btnGrabar.Enabled = false; 
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            proveedores.actualizaProveedor(Convert.ToInt32(txtIdProveedor.Text), txtEmpresa.Text,txtContacto.Text, txtTelefono.Text, txtDomicilio.Text);
            llenarDtw();
            limpiarCampos();
            habilitarDeshabilitar(false);
            btnModificar.Enabled = false;
        }

        private void llenarDtw()
        {
            DataSet ds = proveedores.consultaProveedores();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
