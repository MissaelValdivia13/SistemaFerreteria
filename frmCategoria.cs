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

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            txtConcepto.Enabled = true;
            txtIdCategoria.Text =Convert.ToString(categoria.nuevaCategoria());
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
            frmCategoria_Load(sender, e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
