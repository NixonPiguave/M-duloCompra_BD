namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmListadoRequisicion
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
            this.lblListadoRequisicion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvListadoRequisicion = new System.Windows.Forms.DataGridView();
            this.txtRequisicionID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSeleccionarCatego = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoRequisicion)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.guna2Panel1.Controls.Add(this.lblListadoRequisicion);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(438, 69);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblListadoRequisicion
            // 
            this.lblListadoRequisicion.BackColor = System.Drawing.Color.Transparent;
            this.lblListadoRequisicion.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoRequisicion.ForeColor = System.Drawing.Color.White;
            this.lblListadoRequisicion.Location = new System.Drawing.Point(152, 23);
            this.lblListadoRequisicion.Name = "lblListadoRequisicion";
            this.lblListadoRequisicion.Size = new System.Drawing.Size(174, 24);
            this.lblListadoRequisicion.TabIndex = 0;
            this.lblListadoRequisicion.Text = "Listado Requisicion";
            // 
            // dgvListadoRequisicion
            // 
            this.dgvListadoRequisicion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListadoRequisicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoRequisicion.GridColor = System.Drawing.Color.Silver;
            this.dgvListadoRequisicion.Location = new System.Drawing.Point(54, 134);
            this.dgvListadoRequisicion.Name = "dgvListadoRequisicion";
            this.dgvListadoRequisicion.RowHeadersVisible = false;
            this.dgvListadoRequisicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoRequisicion.Size = new System.Drawing.Size(348, 280);
            this.dgvListadoRequisicion.TabIndex = 1;
            // 
            // txtRequisicionID
            // 
            this.txtRequisicionID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRequisicionID.DefaultText = "";
            this.txtRequisicionID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRequisicionID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRequisicionID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRequisicionID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRequisicionID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRequisicionID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRequisicionID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRequisicionID.Location = new System.Drawing.Point(54, 102);
            this.txtRequisicionID.Name = "txtRequisicionID";
            this.txtRequisicionID.PlaceholderText = "";
            this.txtRequisicionID.SelectedText = "";
            this.txtRequisicionID.Size = new System.Drawing.Size(225, 26);
            this.txtRequisicionID.TabIndex = 2;
            this.txtRequisicionID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarCategoria_KeyUp);
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
            this.btnSeleccionarCatego.Location = new System.Drawing.Point(285, 102);
            this.btnSeleccionarCatego.Name = "btnSeleccionarCatego";
            this.btnSeleccionarCatego.Size = new System.Drawing.Size(117, 26);
            this.btnSeleccionarCatego.TabIndex = 3;
            this.btnSeleccionarCatego.Text = "Seleccionar";
            this.btnSeleccionarCatego.Click += new System.EventHandler(this.btnSeleccionarCatego_Click);
            // 
            // FrmListadoRequisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.btnSeleccionarCatego);
            this.Controls.Add(this.txtRequisicionID);
            this.Controls.Add(this.dgvListadoRequisicion);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FrmListadoRequisicion";
            this.Text = "FrmListadoRequisicion";
            this.Load += new System.EventHandler(this.FrmListadoRequisicion_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoRequisicion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblListadoRequisicion;
        private System.Windows.Forms.DataGridView dgvListadoRequisicion;
        private Guna.UI2.WinForms.Guna2TextBox txtRequisicionID;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionarCatego;
    }
}