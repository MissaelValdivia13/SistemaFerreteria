using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CapaNegocio;
using SistemaFerreteria;

namespace SistemaFerreteria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }


        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {
            Color fondoPanelColor = ColorTranslator.FromHtml("#242728");

            using (SolidBrush brush = new SolidBrush(fondoPanelColor))
            {
                Graphics g = e.Graphics;
                Rectangle rect = pnLogin.ClientRectangle;
                int radius = 20; 

                
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.StartFigure();
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); 
                    path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90); 
                    path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90); 
                    path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90); 
                    path.CloseFigure();
                    g.FillPath(brush, path); 
                }
            }
        }

        private GraphicsPath GetRoundRectPath(Rectangle rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Encriptacion encriptacion = new Encriptacion();
            string nombre = txtNombre.Text;
            string contraseña = encriptacion.Encriptar(txtContraseña.Text);

            EmpleadoNC empleadoDao = new EmpleadoNC();
            int idEmpleado = empleadoDao.ValidarEmpleado(nombre, contraseña);

            if (idEmpleado != -1)
            {
                this.Hide();

                try
                {
                    SistemaFerreteria ferreteria = new SistemaFerreteria(idEmpleado, nombre);
                    ferreteria.Show();

                    ferreteria.FormClosed += (s, args) => this.Dispose();
                }catch(Exception ex)
                {
                    MessageBox.Show("Ocurrio un Error: " + ex.Message);
                    RespaldoCN respaldo = new RespaldoCN();
                    respaldo.InsertarError(0, "Iniciar sesion", ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

    }
}
