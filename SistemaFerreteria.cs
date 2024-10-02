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
    public partial class SistemaFerreteria : Form
    {
        public SistemaFerreteria()
        {
            InitializeComponent();
        }

        private void catalagosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Abre form clientes dentro del panel principal
        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            AbrirFrom(cliente);
        }

        //Permite 
        public void AbrirFrom(Object form)
        {
            if (this.pnPrincipal.Controls.Count > 0)
                this.pnPrincipal.Controls.RemoveAt(0);
            Form fn = form as Form;
            fn.TopLevel = false; fn.Dock
            = DockStyle.Fill;
            this.pnPrincipal.Controls.Add(fn);
            this.pnPrincipal.Tag = fn;
            fn.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedor proveedor = new frmProveedor();
            AbrirFrom(proveedor);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria categoria = new frmCategoria();
            AbrirFrom(categoria);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleado empleado = new frmEmpleado();
            AbrirFrom(empleado);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProducto producto = new frmProducto();
            AbrirFrom(producto);
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            frmCompras frmCompras = new frmCompras();
            AbrirFrom(frmCompras);
        }
    }
}
