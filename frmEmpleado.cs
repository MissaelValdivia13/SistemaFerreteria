﻿using System;
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error: " + ex.Message);
                RespaldoCN respaldo = new RespaldoCN();
                respaldo.InsertarError(1, "frmEmpleado", ex.Message);
            }
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            cboPuesto.Text = "";
            txtIdEmpleado.Text = "";
            txtContra.Text = "";
        }
        private void habilitarDesabilitar(Boolean opcion)
        {
            txtTelefono.Enabled = opcion;
            txtNombre.Enabled = opcion;
            cboPuesto.Enabled = opcion;
            txtContra.Enabled = opcion;
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            habilitarDesabilitar(true);
            txtIdEmpleado.Text = Convert.ToString(empleado.nuevoEmpleado());
            btnGrabar.Enabled = true;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (cboPuesto.Text != "" || cboPuesto.Text != null)
            {
                Encriptacion encripta = new Encriptacion();
                string encriptada = encripta.Encriptar(txtContra.Text);
                empleado.subeEmpleado(txtNombre.Text, cboPuesto.Text, txtTelefono.Text, encriptada);
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

        private void dtwEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                txtIdEmpleado.Text = dtwEmpleado.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dtwEmpleado.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboPuesto.Text = dtwEmpleado.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTelefono.Text = dtwEmpleado.Rows[e.RowIndex].Cells[3].Value.ToString();
                btnModificar.Enabled = true;
                btnGrabar.Enabled = false;
                habilitarDesabilitar(true);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           // empleado.actualizaEmpleado(Convert.ToInt32(txtIdEmpleado.Text), txtNombre.Text, cboPuesto.Text, txtTelefono.Text);
            habilitarDesabilitar(false);
            limpiarCampos();
            llenarData();
            btnModificar.Enabled = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
