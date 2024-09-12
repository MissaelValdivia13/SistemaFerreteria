namespace SistemaFerreteria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catalagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCatalagos = new FontAwesome.Sharp.IconMenuItem();
            this.btnClientes = new FontAwesome.Sharp.IconMenuItem();
            this.btnProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.btnCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 47);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(480, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Ferreteria ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnPrincipal);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 611);
            this.panel2.TabIndex = 1;
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 81);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(1159, 530);
            this.pnPrincipal.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalagosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.btnCatalagos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 81);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catalagosToolStripMenuItem
            // 
            this.catalagosToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalagosToolStripMenuItem.Name = "catalagosToolStripMenuItem";
            this.catalagosToolStripMenuItem.Size = new System.Drawing.Size(12, 77);
            this.catalagosToolStripMenuItem.Click += new System.EventHandler(this.catalagosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold);
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(12, 77);
            // 
            // btnCatalagos
            // 
            this.btnCatalagos.AutoSize = false;
            this.btnCatalagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.btnCatalagos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientes,
            this.btnCategoria,
            this.btnProveedores});
            this.btnCatalagos.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.5F);
            this.btnCatalagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnCatalagos.IconChar = FontAwesome.Sharp.IconChar.FileCircleQuestion;
            this.btnCatalagos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnCatalagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCatalagos.IconSize = 55;
            this.btnCatalagos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCatalagos.Margin = new System.Windows.Forms.Padding(1);
            this.btnCatalagos.Name = "btnCatalagos";
            this.btnCatalagos.Size = new System.Drawing.Size(122, 70);
            this.btnCatalagos.Text = "Catálogos";
            this.btnCatalagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnClientes
            // 
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnClientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 60;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(180, 28);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
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
            // btnCategoria
            // 
            this.btnCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnCategoria.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.btnCategoria.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategoria.IconSize = 60;
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(180, 28);
            this.btnCategoria.Text = "Categoría";
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem catalagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem btnCatalagos;
        private System.Windows.Forms.Panel pnPrincipal;
        private FontAwesome.Sharp.IconMenuItem btnClientes;
        private FontAwesome.Sharp.IconMenuItem btnProveedores;
        private FontAwesome.Sharp.IconMenuItem btnCategoria;
    }
}

