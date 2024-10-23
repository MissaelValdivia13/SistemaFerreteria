namespace SistemaFerreteria
{
    partial class SistemaFerreteria
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbEmpleado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCatalagos = new FontAwesome.Sharp.IconMenuItem();
            this.btnProductos = new FontAwesome.Sharp.IconMenuItem();
            this.btnClientes = new FontAwesome.Sharp.IconMenuItem();
            this.btnEmpleado = new FontAwesome.Sharp.IconMenuItem();
            this.btnCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.btnProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.btnRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.btnConsultarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.btnVentas = new FontAwesome.Sharp.IconMenuItem();
            this.btnRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.btnConsultarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.btnBitacoraErrores = new FontAwesome.Sharp.IconMenuItem();
            this.btnCobros = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.btnConsultarCobros = new FontAwesome.Sharp.IconMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lbNombre);
            this.panel1.Controls.Add(this.lbEmpleado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 41);
            this.panel1.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14.75F);
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(704, 8);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(56, 28);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "User:";
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.AutoSize = true;
            this.lbEmpleado.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14.75F);
            this.lbEmpleado.ForeColor = System.Drawing.Color.White;
            this.lbEmpleado.Location = new System.Drawing.Point(600, 9);
            this.lbEmpleado.Name = "lbEmpleado";
            this.lbEmpleado.Size = new System.Drawing.Size(40, 28);
            this.lbEmpleado.TabIndex = 1;
            this.lbEmpleado.Text = "Id: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Ferretería";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnPrincipal);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 617);
            this.panel2.TabIndex = 1;
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 69);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(1159, 548);
            this.pnPrincipal.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCatalagos,
            this.iconMenuItem1,
            this.btnVentas,
            this.btnCobros,
            this.btnBitacoraErrores});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 69);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCatalagos
            // 
            this.btnCatalagos.AutoSize = false;
            this.btnCatalagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.btnCatalagos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProductos,
            this.btnClientes,
            this.btnEmpleado,
            this.btnCategoria,
            this.btnProveedores});
            this.btnCatalagos.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.btnCatalagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnCatalagos.IconChar = FontAwesome.Sharp.IconChar.FileCircleQuestion;
            this.btnCatalagos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnCatalagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCatalagos.IconSize = 55;
            this.btnCatalagos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCatalagos.Margin = new System.Windows.Forms.Padding(50, 1, 1, 1);
            this.btnCatalagos.Name = "btnCatalagos";
            this.btnCatalagos.Size = new System.Drawing.Size(122, 70);
            this.btnCatalagos.Text = "Catálogos";
            this.btnCatalagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnProductos
            // 
            this.btnProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnProductos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.IconSize = 60;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(174, 28);
            this.btnProductos.Text = "Producto";
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnClientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 60;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(174, 28);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnEmpleado.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.btnEmpleado.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleado.IconSize = 60;
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(174, 28);
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnCategoria.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.btnCategoria.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategoria.IconSize = 60;
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(174, 28);
            this.btnCategoria.Text = "Categoría";
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.AutoSize = false;
            this.btnProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            this.btnProveedores.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedores.IconSize = 60;
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(180, 28);
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.AutoSize = false;
            this.iconMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.iconMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistrarCompra,
            this.btnConsultarCompra});
            this.iconMenuItem1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.iconMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.FileCircleQuestion;
            this.iconMenuItem1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 55;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Margin = new System.Windows.Forms.Padding(50, 1, 1, 1);
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(122, 70);
            this.iconMenuItem1.Text = "Compras";
            this.iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnRegistrarCompra.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarCompra.IconSize = 60;
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(152, 28);
            this.btnRegistrarCompra.Text = "Registrar";
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
            // 
            // btnConsultarCompra
            // 
            this.btnConsultarCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnConsultarCompra.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnConsultarCompra.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnConsultarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultarCompra.IconSize = 60;
            this.btnConsultarCompra.Name = "btnConsultarCompra";
            this.btnConsultarCompra.Size = new System.Drawing.Size(152, 28);
            this.btnConsultarCompra.Text = "Consultar";
            this.btnConsultarCompra.Click += new System.EventHandler(this.btnConsultarCompra_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.AutoSize = false;
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.btnVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistrarVenta,
            this.btnConsultarVenta});
            this.btnVentas.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.btnVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.FileCircleQuestion;
            this.btnVentas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 55;
            this.btnVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVentas.Margin = new System.Windows.Forms.Padding(50, 1, 1, 1);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(122, 70);
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnRegistrarVenta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarVenta.IconSize = 60;
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(180, 28);
            this.btnRegistrarVenta.Text = "Registrar";
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnConsultarVenta
            // 
            this.btnConsultarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnConsultarVenta.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnConsultarVenta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnConsultarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultarVenta.IconSize = 60;
            this.btnConsultarVenta.Name = "btnConsultarVenta";
            this.btnConsultarVenta.Size = new System.Drawing.Size(180, 28);
            this.btnConsultarVenta.Text = "Consultar";
            this.btnConsultarVenta.Click += new System.EventHandler(this.btnConsultarVenta_Click);
            // 
            // btnBitacoraErrores
            // 
            this.btnBitacoraErrores.AutoSize = false;
            this.btnBitacoraErrores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.btnBitacoraErrores.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10.5F);
            this.btnBitacoraErrores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnBitacoraErrores.IconChar = FontAwesome.Sharp.IconChar.FileCircleQuestion;
            this.btnBitacoraErrores.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnBitacoraErrores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBitacoraErrores.IconSize = 55;
            this.btnBitacoraErrores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBitacoraErrores.Margin = new System.Windows.Forms.Padding(50, 1, 1, 1);
            this.btnBitacoraErrores.Name = "btnBitacoraErrores";
            this.btnBitacoraErrores.Size = new System.Drawing.Size(122, 70);
            this.btnBitacoraErrores.Text = "Bitacora de Errores";
            this.btnBitacoraErrores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBitacoraErrores.Click += new System.EventHandler(this.btnBitacoraErrores_Click);
            // 
            // btnCobros
            // 
            this.btnCobros.AutoSize = false;
            this.btnCobros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.btnCobros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem3,
            this.btnConsultarCobros});
            this.btnCobros.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.btnCobros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnCobros.IconChar = FontAwesome.Sharp.IconChar.FileCircleQuestion;
            this.btnCobros.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnCobros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCobros.IconSize = 55;
            this.btnCobros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCobros.Margin = new System.Windows.Forms.Padding(50, 1, 1, 1);
            this.btnCobros.Name = "btnCobros";
            this.btnCobros.Size = new System.Drawing.Size(122, 70);
            this.btnCobros.Text = "Cobros";
            this.btnCobros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconMenuItem3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.IconSize = 60;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(180, 28);
            this.iconMenuItem3.Text = "Registrar";
            this.iconMenuItem3.Click += new System.EventHandler(this.iconMenuItem3_Click);
            // 
            // btnConsultarCobros
            // 
            this.btnConsultarCobros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnConsultarCobros.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnConsultarCobros.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnConsultarCobros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultarCobros.IconSize = 60;
            this.btnConsultarCobros.Name = "btnConsultarCobros";
            this.btnConsultarCobros.Size = new System.Drawing.Size(180, 28);
            this.btnConsultarCobros.Text = "Consultar";
            this.btnConsultarCobros.Click += new System.EventHandler(this.btnConsultarCobros_Click);
            // 
            // SistemaFerreteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SistemaFerreteria";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem btnCatalagos;
        private System.Windows.Forms.Panel pnPrincipal;
        private FontAwesome.Sharp.IconMenuItem btnClientes;
        private FontAwesome.Sharp.IconMenuItem btnProveedores;
        private FontAwesome.Sharp.IconMenuItem btnCategoria;
        private FontAwesome.Sharp.IconMenuItem btnEmpleado;
        private FontAwesome.Sharp.IconMenuItem btnProductos;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem btnRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem btnConsultarCompra;
        private System.Windows.Forms.Label lbEmpleado;
        private System.Windows.Forms.Label lbNombre;
        private FontAwesome.Sharp.IconMenuItem btnVentas;
        private FontAwesome.Sharp.IconMenuItem btnRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem btnConsultarVenta;
        private FontAwesome.Sharp.IconMenuItem btnBitacoraErrores;
        private FontAwesome.Sharp.IconMenuItem btnCobros;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem btnConsultarCobros;
    }
}

