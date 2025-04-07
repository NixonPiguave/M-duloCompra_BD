namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmListadoDiario
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
            this.lblDiarioContable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvListadoDiario = new System.Windows.Forms.DataGridView();
            this.txtDiarioContable = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSeleccionarCatego = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDiario)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.guna2Panel1.Controls.Add(this.lblDiarioContable);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(739, 69);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblDiarioContable
            // 
            this.lblDiarioContable.BackColor = System.Drawing.Color.Transparent;
            this.lblDiarioContable.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiarioContable.ForeColor = System.Drawing.Color.White;
            this.lblDiarioContable.Location = new System.Drawing.Point(303, 21);
            this.lblDiarioContable.Name = "lblDiarioContable";
            this.lblDiarioContable.Size = new System.Drawing.Size(207, 24);
            this.lblDiarioContable.TabIndex = 0;
            this.lblDiarioContable.Text = "Listado Diario Contable";
            // 
            // dgvListadoDiario
            // 
            this.dgvListadoDiario.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListadoDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDiario.GridColor = System.Drawing.Color.Silver;
            this.dgvListadoDiario.Location = new System.Drawing.Point(54, 134);
            this.dgvListadoDiario.Name = "dgvListadoDiario";
            this.dgvListadoDiario.RowHeadersVisible = false;
            this.dgvListadoDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoDiario.Size = new System.Drawing.Size(643, 280);
            this.dgvListadoDiario.TabIndex = 1;
            // 
            // txtDiarioContable
            // 
            this.txtDiarioContable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiarioContable.DefaultText = "";
            this.txtDiarioContable.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiarioContable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiarioContable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiarioContable.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiarioContable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiarioContable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiarioContable.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiarioContable.Location = new System.Drawing.Point(54, 102);
            this.txtDiarioContable.Name = "txtDiarioContable";
            this.txtDiarioContable.PlaceholderText = "";
            this.txtDiarioContable.SelectedText = "";
            this.txtDiarioContable.Size = new System.Drawing.Size(136, 26);
            this.txtDiarioContable.TabIndex = 2;
            // 
            // btnSeleccionarCatego
            // 
            this.btnSeleccionarCatego.BorderRadius = 10;
            this.btnSeleccionarCatego.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarCatego.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarCatego.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeleccionarCatego.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeleccionarCatego.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnSeleccionarCatego.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarCatego.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarCatego.Location = new System.Drawing.Point(200, 102);
            this.btnSeleccionarCatego.Name = "btnSeleccionarCatego";
            this.btnSeleccionarCatego.Size = new System.Drawing.Size(123, 26);
            this.btnSeleccionarCatego.TabIndex = 3;
            this.btnSeleccionarCatego.Text = "Seleccionar";
            this.btnSeleccionarCatego.Click += new System.EventHandler(this.btnSeleccionarCatego_Click);
            // 
            // FrmListadoDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(739, 457);
            this.Controls.Add(this.btnSeleccionarCatego);
            this.Controls.Add(this.txtDiarioContable);
            this.Controls.Add(this.dgvListadoDiario);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FrmListadoDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListadoCategoria";
            this.Load += new System.EventHandler(this.FrmListadoCategoria_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDiario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDiarioContable;
        private System.Windows.Forms.DataGridView dgvListadoDiario;
        private Guna.UI2.WinForms.Guna2TextBox txtDiarioContable;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionarCatego;
    }
}