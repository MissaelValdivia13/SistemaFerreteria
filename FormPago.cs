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
    public partial class FormPago : Form
    {
        public double Total { get; set; }  
        public double CantidadPagada { get; set; }  
        public double Cambio { get; set; }
        public FormPago(double total)
        {
            InitializeComponent();
            Total = total;
            lblTotal.Text = $"Total a pagar: {Total:C}";
        }

        private void FormPago_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCantidadPagada.Text, out double cantidadPagada))
            {
                if (cantidadPagada >= Total)
                {
                    Cambio = cantidadPagada - Total;
                    MessageBox.Show("Cambio: " + Cambio);
                    Cambio = 0;
                }
                else
                {
                    Cambio = Total - cantidadPagada;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese un monto válido.");
            }
        }
    }
}
