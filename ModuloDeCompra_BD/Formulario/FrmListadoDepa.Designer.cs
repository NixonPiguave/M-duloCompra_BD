namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmListadoDepa
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
            this.dgvListadoCategoria = new System.Windows.Forms.DataGridView();
            this.txtBuscarCategoria = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSeleccionarCatego = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(7)))), ((int)(((byte)(109)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(333, 69);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(66, 24);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(209, 27);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Listado Departamentos";
            // 
            // dgvListadoCategoria
            // 
            this.dgvListadoCategoria.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListadoCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoCategoria.GridColor = System.Drawing.Color.Silver;
            this.dgvListadoCategoria.Location = new System.Drawing.Point(54, 134);
            this.dgvListadoCategoria.Name = "dgvListadoCategoria";
            this.dgvListadoCategoria.RowHeadersVisible = false;
            this.dgvListadoCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoCategoria.Size = new System.Drawing.Size(239, 280);
            this.dgvListadoCategoria.TabIndex = 1;
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarCategoria.DefaultText = "";
            this.txtBuscarCategoria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarCategoria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarCategoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarCategoria.Location = new System.Drawing.Point(54, 102);
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.PlaceholderText = "";
            this.txtBuscarCategoria.SelectedText = "";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(136, 26);
            this.txtBuscarCategoria.TabIndex = 2;
            this.txtBuscarCategoria.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarCategoria_KeyUp);
            // 
            // btnSeleccionarCatego
            // 
            this.btnSeleccionarCatego.BorderRadius = 10;
            this.btnSeleccionarCatego.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarCatego.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarCatego.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeleccionarCatego.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeleccionarCatego.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(170)))), ((int)(((byte)(239)))));
            this.btnSeleccionarCatego.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSeleccionarCatego.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarCatego.Location = new System.Drawing.Point(200, 102);
            this.btnSeleccionarCatego.Name = "btnSeleccionarCatego";
            this.btnSeleccionarCatego.Size = new System.Drawing.Size(93, 26);
            this.btnSeleccionarCatego.TabIndex = 3;
            this.btnSeleccionarCatego.Text = "Seleccionar";
            this.btnSeleccionarCatego.Click += new System.EventHandler(this.btnSeleccionarCatego_Click);
            // 
            // FrmListadoDepa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.btnSeleccionarCatego);
            this.Controls.Add(this.txtBuscarCategoria);
            this.Controls.Add(this.dgvListadoCategoria);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FrmListadoDepa";
            this.Text = "FrmListadoCategoria";
            this.Load += new System.EventHandler(this.FrmListadoCategoria_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridView dgvListadoCategoria;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarCategoria;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionarCatego;
    }
}