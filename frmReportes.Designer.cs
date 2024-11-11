namespace SistemaFerreteria
{
    partial class frmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rpv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.pnCompras = new System.Windows.Forms.Panel();
            this.txtComparacionCompras = new FontAwesome.Sharp.IconButton();
            this.btnComprasCategoria = new FontAwesome.Sharp.IconButton();
            this.btnComprasProveedor = new FontAwesome.Sharp.IconButton();
            this.btnCompras = new FontAwesome.Sharp.IconButton();
            this.pnClientes = new System.Windows.Forms.Panel();
            this.btnRankindDeClientes = new FontAwesome.Sharp.IconButton();
            this.btnClientesSaldo = new FontAwesome.Sharp.IconButton();
            this.txtCobrosoCliente = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.pnVentas = new System.Windows.Forms.Panel();
            this.txtProductosRentables = new FontAwesome.Sharp.IconButton();
            this.btnRankingEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnVentasEmpleadoPeriodo = new FontAwesome.Sharp.IconButton();
            this.btnVentasPeriodo = new FontAwesome.Sharp.IconButton();
            this.btnRankingProductos = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnComparcionVentas = new FontAwesome.Sharp.IconButton();
            this.pnPrincipal.SuspendLayout();
            this.pnCompras.SuspendLayout();
            this.pnClientes.SuspendLayout();
            this.pnVentas.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpv
            // 
            this.rpv.Dock = System.Windows.Forms.DockStyle.Left;
            this.rpv.Location = new System.Drawing.Point(0, 0);
            this.rpv.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.rpv.Name = "rpv";
            this.rpv.ServerReport.BearerToken = null;
            this.rpv.Size = new System.Drawing.Size(661, 685);
            this.rpv.TabIndex = 0;
            this.rpv.Load += new System.EventHandler(this.rpv_Load);
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.pnCompras);
            this.pnPrincipal.Controls.Add(this.btnCompras);
            this.pnPrincipal.Controls.Add(this.pnClientes);
            this.pnPrincipal.Controls.Add(this.btnClientes);
            this.pnPrincipal.Controls.Add(this.pnVentas);
            this.pnPrincipal.Controls.Add(this.iconButton1);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnPrincipal.Location = new System.Drawing.Point(120, 10);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(269, 665);
            this.pnPrincipal.TabIndex = 1;
            // 
            // pnCompras
            // 
            this.pnCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.pnCompras.Controls.Add(this.txtComparacionCompras);
            this.pnCompras.Controls.Add(this.btnComprasCategoria);
            this.pnCompras.Controls.Add(this.btnComprasProveedor);
            this.pnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCompras.Location = new System.Drawing.Point(0, 558);
            this.pnCompras.Name = "pnCompras";
            this.pnCompras.Size = new System.Drawing.Size(269, 195);
            this.pnCompras.TabIndex = 5;
            this.pnCompras.Visible = false;
            // 
            // txtComparacionCompras
            // 
            this.txtComparacionCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.txtComparacionCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtComparacionCompras.FlatAppearance.BorderSize = 0;
            this.txtComparacionCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtComparacionCompras.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.txtComparacionCompras.ForeColor = System.Drawing.Color.White;
            this.txtComparacionCompras.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.txtComparacionCompras.IconColor = System.Drawing.Color.White;
            this.txtComparacionCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txtComparacionCompras.IconSize = 30;
            this.txtComparacionCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtComparacionCompras.Location = new System.Drawing.Point(0, 115);
            this.txtComparacionCompras.Name = "txtComparacionCompras";
            this.txtComparacionCompras.Size = new System.Drawing.Size(269, 57);
            this.txtComparacionCompras.TabIndex = 3;
            this.txtComparacionCompras.Text = "Comparacion de Compras menusales";
            this.txtComparacionCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtComparacionCompras.UseVisualStyleBackColor = false;
            this.txtComparacionCompras.Click += new System.EventHandler(this.txtComparacionCompras_Click);
            // 
            // btnComprasCategoria
            // 
            this.btnComprasCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.btnComprasCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComprasCategoria.FlatAppearance.BorderSize = 0;
            this.btnComprasCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprasCategoria.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.btnComprasCategoria.ForeColor = System.Drawing.Color.White;
            this.btnComprasCategoria.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btnComprasCategoria.IconColor = System.Drawing.Color.White;
            this.btnComprasCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComprasCategoria.IconSize = 30;
            this.btnComprasCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprasCategoria.Location = new System.Drawing.Point(0, 60);
            this.btnComprasCategoria.Name = "btnComprasCategoria";
            this.btnComprasCategoria.Size = new System.Drawing.Size(269, 55);
            this.btnComprasCategoria.TabIndex = 2;
            this.btnComprasCategoria.Text = "Compras por Categoria en un Periodo";
            this.btnComprasCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComprasCategoria.UseVisualStyleBackColor = false;
            this.btnComprasCategoria.Click += new System.EventHandler(this.btnComprasCategoria_Click);
            // 
            // btnComprasProveedor
            // 
            this.btnComprasProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.btnComprasProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComprasProveedor.FlatAppearance.BorderSize = 0;
            this.btnComprasProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprasProveedor.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.btnComprasProveedor.ForeColor = System.Drawing.Color.White;
            this.btnComprasProveedor.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.btnComprasProveedor.IconColor = System.Drawing.Color.White;
            this.btnComprasProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComprasProveedor.IconSize = 30;
            this.btnComprasProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprasProveedor.Location = new System.Drawing.Point(0, 0);
            this.btnComprasProveedor.Name = "btnComprasProveedor";
            this.btnComprasProveedor.Size = new System.Drawing.Size(269, 60);
            this.btnComprasProveedor.TabIndex = 1;
            this.btnComprasProveedor.Text = "Compras a proveedor por periodo";
            this.btnComprasProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComprasProveedor.UseVisualStyleBackColor = false;
            this.btnComprasProveedor.Click += new System.EventHandler(this.btnComprasProveedor_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(81)))), ((int)(((byte)(83)))));
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.Nimblr;
            this.btnCompras.IconColor = System.Drawing.Color.White;
            this.btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompras.IconSize = 30;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompras.Location = new System.Drawing.Point(0, 525);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(269, 33);
            this.btnCompras.TabIndex = 4;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // pnClientes
            // 
            this.pnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.pnClientes.Controls.Add(this.btnRankindDeClientes);
            this.pnClientes.Controls.Add(this.btnClientesSaldo);
            this.pnClientes.Controls.Add(this.txtCobrosoCliente);
            this.pnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnClientes.Location = new System.Drawing.Point(0, 370);
            this.pnClientes.Name = "pnClientes";
            this.pnClientes.Size = new System.Drawing.Size(269, 155);
            this.pnClientes.TabIndex = 3;
            this.pnClientes.Visible = false;
            this.pnClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnClientes_Paint);
            // 
            // btnRankindDeClientes
            // 
            this.btnRankindDeClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.btnRankindDeClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRankindDeClientes.FlatAppearance.BorderSize = 0;
            this.btnRankindDeClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRankindDeClientes.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.btnRankindDeClientes.ForeColor = System.Drawing.Color.White;
            this.btnRankindDeClientes.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btnRankindDeClientes.IconColor = System.Drawing.Color.White;
            this.btnRankindDeClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRankindDeClientes.IconSize = 30;
            this.btnRankindDeClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRankindDeClientes.Location = new System.Drawing.Point(0, 98);
            this.btnRankindDeClientes.Name = "btnRankindDeClientes";
            this.btnRankindDeClientes.Size = new System.Drawing.Size(269, 49);
            this.btnRankindDeClientes.TabIndex = 3;
            this.btnRankindDeClientes.Text = "Ranking Clientes";
            this.btnRankindDeClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRankindDeClientes.UseVisualStyleBackColor = false;
            this.btnRankindDeClientes.Click += new System.EventHandler(this.btnRankindDeClientes_Click);
            // 
            // btnClientesSaldo
            // 
            this.btnClientesSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.btnClientesSaldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientesSaldo.FlatAppearance.BorderSize = 0;
            this.btnClientesSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientesSaldo.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.btnClientesSaldo.ForeColor = System.Drawing.Color.White;
            this.btnClientesSaldo.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btnClientesSaldo.IconColor = System.Drawing.Color.White;
            this.btnClientesSaldo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientesSaldo.IconSize = 30;
            this.btnClientesSaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientesSaldo.Location = new System.Drawing.Point(0, 49);
            this.btnClientesSaldo.Name = "btnClientesSaldo";
            this.btnClientesSaldo.Size = new System.Drawing.Size(269, 49);
            this.btnClientesSaldo.TabIndex = 2;
            this.btnClientesSaldo.Text = "Clientes con Saldo Pendiente";
            this.btnClientesSaldo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientesSaldo.UseVisualStyleBackColor = false;
            this.btnClientesSaldo.Click += new System.EventHandler(this.btnClientesSaldo_Click);
            // 
            // txtCobrosoCliente
            // 
            this.txtCobrosoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.txtCobrosoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCobrosoCliente.FlatAppearance.BorderSize = 0;
            this.txtCobrosoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCobrosoCliente.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.txtCobrosoCliente.ForeColor = System.Drawing.Color.White;
            this.txtCobrosoCliente.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.txtCobrosoCliente.IconColor = System.Drawing.Color.White;
            this.txtCobrosoCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txtCobrosoCliente.IconSize = 30;
            this.txtCobrosoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtCobrosoCliente.Location = new System.Drawing.Point(0, 0);
            this.txtCobrosoCliente.Name = "txtCobrosoCliente";
            this.txtCobrosoCliente.Size = new System.Drawing.Size(269, 49);
            this.txtCobrosoCliente.TabIndex = 1;
            this.txtCobrosoCliente.Text = "Cobros por Cliente";
            this.txtCobrosoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtCobrosoCliente.UseVisualStyleBackColor = false;
            this.txtCobrosoCliente.Click += new System.EventHandler(this.txtCobrosoCliente_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(81)))), ((int)(((byte)(83)))));
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Nimblr;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 30;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.Location = new System.Drawing.Point(0, 337);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(269, 33);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnVentas
            // 
            this.pnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.pnVentas.Controls.Add(this.btnComparcionVentas);
            this.pnVentas.Controls.Add(this.txtProductosRentables);
            this.pnVentas.Controls.Add(this.btnRankingEmpleados);
            this.pnVentas.Controls.Add(this.btnVentasEmpleadoPeriodo);
            this.pnVentas.Controls.Add(this.btnVentasPeriodo);
            this.pnVentas.Controls.Add(this.btnRankingProductos);
            this.pnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnVentas.Location = new System.Drawing.Point(0, 33);
            this.pnVentas.Name = "pnVentas";
            this.pnVentas.Size = new System.Drawing.Size(269, 304);
            this.pnVentas.TabIndex = 1;
            this.pnVentas.Visible = false;
            this.pnVentas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnVentas_Paint);
            // 
            // txtProductosRentables
            // 
            this.txtProductosRentables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.txtProductosRentables.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProductosRentables.FlatAppearance.BorderSize = 0;
            this.txtProductosRentables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtProductosRentables.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.txtProductosRentables.ForeColor = System.Drawing.Color.White;
            this.txtProductosRentables.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.txtProductosRentables.IconColor = System.Drawing.Color.White;
            this.txtProductosRentables.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txtProductosRentables.IconSize = 30;
            this.txtProductosRentables.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtProductosRentables.Location = new System.Drawing.Point(0, 196);
            this.txtProductosRentables.Name = "txtProductosRentables";
            this.txtProductosRentables.Size = new System.Drawing.Size(269, 47);
            this.txtProductosRentables.TabIndex = 5;
            this.txtProductosRentables.Text = "Productos mas Rentables";
            this.txtProductosRentables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtProductosRentables.UseVisualStyleBackColor = false;
            this.txtProductosRentables.Click += new System.EventHandler(this.txtProductosRentables_Click);
            // 
            // btnRankingEmpleados
            // 
            this.btnRankingEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.btnRankingEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRankingEmpleados.FlatAppearance.BorderSize = 0;
            this.btnRankingEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRankingEmpleados.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.btnRankingEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnRankingEmpleados.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.btnRankingEmpleados.IconColor = System.Drawing.Color.White;
            this.btnRankingEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRankingEmpleados.IconSize = 30;
            this.btnRankingEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRankingEmpleados.Location = new System.Drawing.Point(0, 147);
            this.btnRankingEmpleados.Name = "btnRankingEmpleados";
            this.btnRankingEmpleados.Size = new System.Drawing.Size(269, 49);
            this.btnRankingEmpleados.TabIndex = 4;
            this.btnRankingEmpleados.Text = "Ranking de Empleados";
            this.btnRankingEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRankingEmpleados.UseVisualStyleBackColor = false;
            this.btnRankingEmpleados.Click += new System.EventHandler(this.btnRankingEmpleados_Click);
            // 
            // btnVentasEmpleadoPeriodo
            // 
            this.btnVentasEmpleadoPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.btnVentasEmpleadoPeriodo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentasEmpleadoPeriodo.FlatAppearance.BorderSize = 0;
            this.btnVentasEmpleadoPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasEmpleadoPeriodo.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.btnVentasEmpleadoPeriodo.ForeColor = System.Drawing.Color.White;
            this.btnVentasEmpleadoPeriodo.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btnVentasEmpleadoPeriodo.IconColor = System.Drawing.Color.White;
            this.btnVentasEmpleadoPeriodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentasEmpleadoPeriodo.IconSize = 30;
            this.btnVentasEmpleadoPeriodo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentasEmpleadoPeriodo.Location = new System.Drawing.Point(0, 98);
            this.btnVentasEmpleadoPeriodo.Name = "btnVentasEmpleadoPeriodo";
            this.btnVentasEmpleadoPeriodo.Size = new System.Drawing.Size(269, 49);
            this.btnVentasEmpleadoPeriodo.TabIndex = 3;
            this.btnVentasEmpleadoPeriodo.Text = "Ventas por Empleado";
            this.btnVentasEmpleadoPeriodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentasEmpleadoPeriodo.UseVisualStyleBackColor = false;
            this.btnVentasEmpleadoPeriodo.Click += new System.EventHandler(this.btnVentasEmpleadoPeriodo_Click);
            // 
            // btnVentasPeriodo
            // 
            this.btnVentasPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.btnVentasPeriodo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentasPeriodo.FlatAppearance.BorderSize = 0;
            this.btnVentasPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasPeriodo.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.btnVentasPeriodo.ForeColor = System.Drawing.Color.White;
            this.btnVentasPeriodo.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btnVentasPeriodo.IconColor = System.Drawing.Color.White;
            this.btnVentasPeriodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentasPeriodo.IconSize = 30;
            this.btnVentasPeriodo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentasPeriodo.Location = new System.Drawing.Point(0, 49);
            this.btnVentasPeriodo.Name = "btnVentasPeriodo";
            this.btnVentasPeriodo.Size = new System.Drawing.Size(269, 49);
            this.btnVentasPeriodo.TabIndex = 2;
            this.btnVentasPeriodo.Text = "Ventas por Periodo";
            this.btnVentasPeriodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentasPeriodo.UseVisualStyleBackColor = false;
            this.btnVentasPeriodo.Click += new System.EventHandler(this.btnVentasPeriodo_Click_1);
            // 
            // btnRankingProductos
            // 
            this.btnRankingProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.btnRankingProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRankingProductos.FlatAppearance.BorderSize = 0;
            this.btnRankingProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRankingProductos.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.btnRankingProductos.ForeColor = System.Drawing.Color.White;
            this.btnRankingProductos.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.btnRankingProductos.IconColor = System.Drawing.Color.White;
            this.btnRankingProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRankingProductos.IconSize = 30;
            this.btnRankingProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRankingProductos.Location = new System.Drawing.Point(0, 0);
            this.btnRankingProductos.Name = "btnRankingProductos";
            this.btnRankingProductos.Size = new System.Drawing.Size(269, 49);
            this.btnRankingProductos.TabIndex = 1;
            this.btnRankingProductos.Text = "Ranking de Productos";
            this.btnRankingProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRankingProductos.UseVisualStyleBackColor = false;
            this.btnRankingProductos.Click += new System.EventHandler(this.btnRankingProductos_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(81)))), ((int)(((byte)(83)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Nimblr;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(269, 33);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Ventas";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnPrincipal);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMain.Location = new System.Drawing.Point(661, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnMain.Size = new System.Drawing.Size(409, 685);
            this.pnMain.TabIndex = 2;
            // 
            // btnComparcionVentas
            // 
            this.btnComparcionVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.btnComparcionVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComparcionVentas.FlatAppearance.BorderSize = 0;
            this.btnComparcionVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComparcionVentas.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.btnComparcionVentas.ForeColor = System.Drawing.Color.White;
            this.btnComparcionVentas.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btnComparcionVentas.IconColor = System.Drawing.Color.White;
            this.btnComparcionVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComparcionVentas.IconSize = 30;
            this.btnComparcionVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComparcionVentas.Location = new System.Drawing.Point(0, 243);
            this.btnComparcionVentas.Name = "btnComparcionVentas";
            this.btnComparcionVentas.Size = new System.Drawing.Size(269, 60);
            this.btnComparcionVentas.TabIndex = 6;
            this.btnComparcionVentas.Text = "Comparación de Ventas Mensuales";
            this.btnComparcionVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComparcionVentas.UseVisualStyleBackColor = false;
            this.btnComparcionVentas.Click += new System.EventHandler(this.btnComparcionVentas_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1082, 685);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.rpv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.pnPrincipal.ResumeLayout(false);
            this.pnCompras.ResumeLayout(false);
            this.pnClientes.ResumeLayout(false);
            this.pnVentas.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Panel pnVentas;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnRankingProductos;
        private System.Windows.Forms.Panel pnMain;
        private FontAwesome.Sharp.IconButton btnVentasPeriodo;
        private FontAwesome.Sharp.IconButton btnVentasEmpleadoPeriodo;
        private FontAwesome.Sharp.IconButton btnRankingEmpleados;
        private System.Windows.Forms.Panel pnClientes;
        private FontAwesome.Sharp.IconButton btnRankindDeClientes;
        private FontAwesome.Sharp.IconButton btnClientesSaldo;
        private FontAwesome.Sharp.IconButton txtCobrosoCliente;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnCompras;
        private System.Windows.Forms.Panel pnCompras;
        private FontAwesome.Sharp.IconButton btnComprasCategoria;
        private FontAwesome.Sharp.IconButton btnComprasProveedor;
        private FontAwesome.Sharp.IconButton txtProductosRentables;
        private FontAwesome.Sharp.IconButton txtComparacionCompras;
        private FontAwesome.Sharp.IconButton btnComparcionVentas;
    }
}