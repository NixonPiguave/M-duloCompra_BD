namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmListadoProveedor
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvListadoProveedores = new System.Windows.Forms.DataGridView();
            this.txtBuscarProveedores = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSeleccionarProvee = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(7)))), ((int)(((byte)(109)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(-3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(335, 63);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(74, 22);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(211, 27);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Listado de Proveedores";
            // 
            // dgvListadoProveedores
            // 
            this.dgvListadoProveedores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListadoProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProveedores.GridColor = System.Drawing.Color.Silver;
            this.dgvListadoProveedores.Location = new System.Drawing.Point(48, 139);
            this.dgvListadoProveedores.Name = "dgvListadoProveedores";
            this.dgvListadoProveedores.RowHeadersVisible = false;
            this.dgvListadoProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoProveedores.Size = new System.Drawing.Size(258, 280);
            this.dgvListadoProveedores.TabIndex = 2;
            // 
            // txtBuscarProveedores
            // 
            this.txtBuscarProveedores.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarProveedores.DefaultText = "";
            this.txtBuscarProveedores.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarProveedores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarProveedores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarProveedores.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarProveedores.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarProveedores.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarProveedores.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarProveedores.Location = new System.Drawing.Point(48, 107);
            this.txtBuscarProveedores.Name = "txtBuscarProveedores";
            this.txtBuscarProveedores.PlaceholderText = "";
            this.txtBuscarProveedores.SelectedText = "";
            this.txtBuscarProveedores.Size = new System.Drawing.Size(136, 26);
            this.txtBuscarProveedores.TabIndex = 3;
            this.txtBuscarProveedores.TextChanged += new System.EventHandler(this.txtBuscarProveedores_TextChanged);
            this.txtBuscarProveedores.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProveedores_KeyUp);
            // 
            // btnSeleccionarProvee
            // 
            this.btnSeleccionarProvee.BorderRadius = 10;
            this.btnSeleccionarProvee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarProvee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarProvee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeleccionarProvee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeleccionarProvee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(170)))), ((int)(((byte)(239)))));
            this.btnSeleccionarProvee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSeleccionarProvee.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarProvee.Location = new System.Drawing.Point(213, 107);
            this.btnSeleccionarProvee.Name = "btnSeleccionarProvee";
            this.btnSeleccionarProvee.Size = new System.Drawing.Size(93, 26);
            this.btnSeleccionarProvee.TabIndex = 4;
            this.btnSeleccionarProvee.Text = "Seleccionar";
            this.btnSeleccionarProvee.Click += new System.EventHandler(this.btnSeleccionarProvee_Click);
            // 
            // FrmListadoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.btnSeleccionarProvee);
            this.Controls.Add(this.txtBuscarProveedores);
            this.Controls.Add(this.dgvListadoProveedores);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FrmListadoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListadoProveedor";
            this.Load += new System.EventHandler(this.FrmListadoProveedor_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridView dgvListadoProveedores;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarProveedores;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionarProvee;
    }
}