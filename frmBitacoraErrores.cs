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
    public partial class frmBitacoraErrores : Form
    {
        private ErroresCN error = new ErroresCN();

        public frmBitacoraErrores()
        {
            InitializeComponent();
        }

        private void frmBitacoraErrores_Load(object sender, EventArgs e)
        {
            llenarDetalleCompra();
        }

        public void llenarDetalleCompra()
        {
            DataSet ds = error.consultaClientes();
            if (ds.Tables.Count > 0)
            {
                dtwBitacora.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar");
            }
            dtwBitacora.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
