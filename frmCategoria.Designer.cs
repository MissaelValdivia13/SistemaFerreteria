namespace SistemaFerreteria
{
    partial class frmCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtwCategoria = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnNuevoCliente = new FontAwesome.Sharp.IconButton();
            this.btnGrabar = new FontAwesome.Sharp.IconButton();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtwCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 72);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(878, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 539);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 543);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(878, 68);
            this.panel3.TabIndex = 2;
            // 
            // dtwCategoria
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.dtwCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtwCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtwCategoria.ColumnHeadersHeight = 35;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9.75F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(141)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtwCategoria.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtwCategoria.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtwCategoria.EnableHeadersVisualStyles = false;
            this.dtwCategoria.Location = new System.Drawing.Point(524, 72);
            this.dtwCategoria.Name = "dtwCategoria";
            this.dtwCategoria.RowHeadersVisible = false;
            this.dtwCategoria.RowTemplate.Height = 30;
            this.dtwCategoria.Size = new System.Drawing.Size(354, 471);
            this.dtwCategoria.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(117)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14.75F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 30;
            this.btnLimpiar.Location = new System.Drawing.Point(60, 353);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(323, 38);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(117)))));
            this.btnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14.75F);
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnNuevoCliente.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnNuevoCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnNuevoCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoCliente.IconSize = 30;
            this.btnNuevoCliente.Location = new System.Drawing.Point(60, 285);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(145, 38);
            this.btnNuevoCliente.TabIndex = 28;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(117)))));
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14.75F);
            this.btnGrabar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnGrabar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnGrabar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnGrabar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGrabar.IconSize = 30;
            this.btnGrabar.Location = new System.Drawing.Point(238, 285);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(145, 38);
            this.btnGrabar.TabIndex = 27;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtConcepto
            // 
            this.txtConcepto.Enabled = false;
            this.txtConcepto.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtConcepto.Location = new System.Drawing.Point(184, 187);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(199, 29);
            this.txtConcepto.TabIndex = 25;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Enabled = false;
            this.txtIdCategoria.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtIdCategoria.Location = new System.Drawing.Point(184, 104);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(111, 29);
            this.txtIdCategoria.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14.75F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.label6.Location = new System.Drawing.Point(66, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Concepto";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.label3.Location = new System.Drawing.Point(66, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "IdCategoria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1122, 611);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtwCategoria);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategoria";
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtwCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtwCategoria;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnNuevoCliente;
        private FontAwesome.Sharp.IconButton btnGrabar;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}