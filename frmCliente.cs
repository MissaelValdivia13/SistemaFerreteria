﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace SistemaFerreteria
{
    public partial class frmCliente : Form
    {
        ClienteCN cliente = new ClienteCN();

        public frmCliente()
        {
            InitializeComponent();
        }


        private void frmCliente_Load(object sender, EventArgs e)
        {
            llenarDtw();

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            cliente.insertaCliente(txtNombre.Text, txtTelefono.Text, txtEmail.Text, txtDomicilio.Text, 0);
            llenarDtw();
            habilitarDesabilitar(false);
            limpiarCampos();
            btnGrabar.Enabled = false;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            txtIdCliente.Text = Convert.ToString(cliente.nuevoCLiente());
            habilitarDesabilitar(true);
            btnModificar.Enabled = false;
            btnGrabar.Enabled = true;
        }

        private void habilitarDesabilitar(Boolean opcion)
        {
            txtDomicilio.Enabled = opcion;
            txtEmail.Enabled = opcion;
            txtNombre.Enabled = opcion;
            txtTelefono.Enabled = opcion;
        }

        private void limpiarCampos()
        {
            txtDomicilio.Text = "";
            txtEmail.Text = "";
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            habilitarDesabilitar(false);
            btnGrabar.Enabled = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void dtwClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                txtIdCliente.Text = dtwClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dtwClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTelefono.Text = dtwClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = dtwClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDomicilio.Text = dtwClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                btnModificar.Enabled = true;
                habilitarDesabilitar(true);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            cliente.actualizarCliente(Convert.ToInt32(txtIdCliente.Text), txtNombre.Text,txtTelefono.Text, txtEmail.Text,txtDomicilio.Text);
            llenarDtw();
            limpiarCampos();
            habilitarDesabilitar(false);
            btnModificar.Enabled = false;
        }

        private void llenarDtw()
        {
            try
            {
                DataSet ds = cliente.consultaClientes();

                if (ds.Tables.Count > 0)
                {
                    dtwClientes.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para mostrar.");
                }
                dtwClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error: " + ex.Message);
                RespaldoCN respaldo = new RespaldoCN();
                respaldo.InsertarError(1, "frmClientes", ex.Message);
            }

        }
    }
}
