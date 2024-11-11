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
            try
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
            }catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un Error: " + ex.Message);
                RespaldoCN respaldo = new RespaldoCN();
                respaldo.InsertarError(1, "frmBitacora de Errores", ex.Message);
            }
        }

        private void dtwBitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
