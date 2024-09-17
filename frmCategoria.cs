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
    public partial class frmCategoria : Form
    {
        CategoriaCN categoria = new CategoriaCN();
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            llenarDtw();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            txtConcepto.Enabled = true;
            txtIdCategoria.Text =Convert.ToString(categoria.nuevaCategoria());
            btnGrabar.Enabled = true;
            btnModificar.Enabled = false;
        }

        private void limpiarCampos()
        {
            txtConcepto.Text = "";
            txtIdCategoria.Text = "";
            txtConcepto.Enabled = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            categoria.subeCategoria(txtConcepto.Text);
            limpiarCampos();
            txtConcepto.Enabled = false;
            llenarDtw();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void dtwCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                txtIdCategoria.Text = dtwCategoria.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtConcepto.Text = dtwCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtConcepto.Enabled = true;
                btnModificar.Enabled = true;
                btnGrabar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            categoria.actualizaCategoria(Convert.ToInt32(txtIdCategoria.Text), txtConcepto.Text);
            limpiarCampos();
            txtConcepto.Enabled = false;
            btnModificar.Enabled = false;
            llenarDtw();
        }

        private void llenarDtw()
        {
            DataSet ds = categoria.consultarCategoria();

            if (ds.Tables.Count > 0)
            {
                dtwCategoria.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar.");
            }
            dtwCategoria.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
