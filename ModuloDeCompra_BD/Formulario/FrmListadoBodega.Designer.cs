namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmListadoBodega
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
            this.btnSeleccionarBodega = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarBodega = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvListadoUbiBodega = new System.Windows.Forms.DataGridView();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoUbiBodega)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(-12, 6);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(335, 63);
            this.guna2Panel1.TabIndex = 5;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(24, 22);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(295, 27);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Listado de Ubicación de Bodegas";
            // 
            // btnSeleccionarBodega
            // 
            this.btnSeleccionarBodega.BorderRadius = 10;
            this.btnSeleccionarBodega.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarBodega.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarBodega.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeleccionarBodega.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeleccionarBodega.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(170)))), ((int)(((byte)(239)))));
            this.btnSeleccionarBodega.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSeleccionarBodega.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarBodega.Location = new System.Drawing.Point(204, 111);
            this.btnSeleccionarBodega.Name = "btnSeleccionarBodega";
            this.btnSeleccionarBodega.Size = new System.Drawing.Size(93, 26);
            this.btnSeleccionarBodega.TabIndex = 8;
            this.btnSeleccionarBodega.Text = "Seleccionar";
            this.btnSeleccionarBodega.Click += new System.EventHandler(this.btnSeleccionarBodega_Click);
            // 
            // txtBuscarBodega
            // 
            this.txtBuscarBodega.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarBodega.DefaultText = "";
            this.txtBuscarBodega.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarBodega.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarBodega.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarBodega.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarBodega.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarBodega.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarBodega.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarBodega.Location = new System.Drawing.Point(39, 111);
            this.txtBuscarBodega.Name = "txtBuscarBodega";
            this.txtBuscarBodega.PlaceholderText = "";
            this.txtBuscarBodega.SelectedText = "";
            this.txtBuscarBodega.Size = new System.Drawing.Size(136, 26);
            this.txtBuscarBodega.TabIndex = 7;
            this.txtBuscarBodega.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarBodega_KeyUp);
            // 
            // dgvListadoUbiBodega
            // 
            this.dgvListadoUbiBodega.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListadoUbiBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoUbiBodega.GridColor = System.Drawing.Color.Silver;
            this.dgvListadoUbiBodega.Location = new System.Drawing.Point(39, 143);
            this.dgvListadoUbiBodega.Name = "dgvListadoUbiBodega";
            this.dgvListadoUbiBodega.RowHeadersVisible = false;
            this.dgvListadoUbiBodega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoUbiBodega.Size = new System.Drawing.Size(258, 280);
            this.dgvListadoUbiBodega.TabIndex = 6;
            // 
            // FrmListadoBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 429);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnSeleccionarBodega);
            this.Controls.Add(this.txtBuscarBodega);
            this.Controls.Add(this.dgvListadoUbiBodega);
            this.Name = "FrmListadoBodega";
            this.Text = "FrmListadoBodega";
            this.Load += new System.EventHandler(this.FrmListadoBodega_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoUbiBodega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionarBodega;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarBodega;
        private System.Windows.Forms.DataGridView dgvListadoUbiBodega;
    }
}