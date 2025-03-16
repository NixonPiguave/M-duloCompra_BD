namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmListadoOrdenCompra
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
            this.lblListadoOrden = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvListadoOrdenCompra = new System.Windows.Forms.DataGridView();
            this.txtOrdenCompraID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSeleccionarOrdenCompra = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoOrdenCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(7)))), ((int)(((byte)(109)))));
            this.guna2Panel1.Controls.Add(this.lblListadoOrden);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(333, 69);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblListadoOrden
            // 
            this.lblListadoOrden.BackColor = System.Drawing.Color.Transparent;
            this.lblListadoOrden.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoOrden.ForeColor = System.Drawing.Color.White;
            this.lblListadoOrden.Location = new System.Drawing.Point(61, 24);
            this.lblListadoOrden.Name = "lblListadoOrden";
            this.lblListadoOrden.Size = new System.Drawing.Size(231, 27);
            this.lblListadoOrden.TabIndex = 0;
            this.lblListadoOrden.Text = "Listado Orden de Compra";
            // 
            // dgvListadoOrdenCompra
            // 
            this.dgvListadoOrdenCompra.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListadoOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoOrdenCompra.GridColor = System.Drawing.Color.Silver;
            this.dgvListadoOrdenCompra.Location = new System.Drawing.Point(54, 134);
            this.dgvListadoOrdenCompra.Name = "dgvListadoOrdenCompra";
            this.dgvListadoOrdenCompra.RowHeadersVisible = false;
            this.dgvListadoOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoOrdenCompra.Size = new System.Drawing.Size(239, 280);
            this.dgvListadoOrdenCompra.TabIndex = 1;
            // 
            // txtOrdenCompraID
            // 
            this.txtOrdenCompraID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrdenCompraID.DefaultText = "";
            this.txtOrdenCompraID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOrdenCompraID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOrdenCompraID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrdenCompraID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrdenCompraID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrdenCompraID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOrdenCompraID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrdenCompraID.Location = new System.Drawing.Point(54, 102);
            this.txtOrdenCompraID.Name = "txtOrdenCompraID";
            this.txtOrdenCompraID.PlaceholderText = "";
            this.txtOrdenCompraID.SelectedText = "";
            this.txtOrdenCompraID.Size = new System.Drawing.Size(136, 26);
            this.txtOrdenCompraID.TabIndex = 2;
            this.txtOrdenCompraID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarCategoria_KeyUp);
            // 
            // btnSeleccionarOrdenCompra
            // 
            this.btnSeleccionarOrdenCompra.BorderRadius = 10;
            this.btnSeleccionarOrdenCompra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarOrdenCompra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarOrdenCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeleccionarOrdenCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeleccionarOrdenCompra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(170)))), ((int)(((byte)(239)))));
            this.btnSeleccionarOrdenCompra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSeleccionarOrdenCompra.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarOrdenCompra.Location = new System.Drawing.Point(200, 102);
            this.btnSeleccionarOrdenCompra.Name = "btnSeleccionarOrdenCompra";
            this.btnSeleccionarOrdenCompra.Size = new System.Drawing.Size(93, 26);
            this.btnSeleccionarOrdenCompra.TabIndex = 3;
            this.btnSeleccionarOrdenCompra.Text = "Seleccionar";
            this.btnSeleccionarOrdenCompra.Click += new System.EventHandler(this.btnSeleccionarCatego_Click);
            // 
            // FrmListadoOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.btnSeleccionarOrdenCompra);
            this.Controls.Add(this.txtOrdenCompraID);
            this.Controls.Add(this.dgvListadoOrdenCompra);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FrmListadoOrdenCompra";
            this.Text = "FrmListadoOrdenCompra";
            this.Load += new System.EventHandler(this.FrmListadoOrdenCompra_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoOrdenCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblListadoOrden;
        private System.Windows.Forms.DataGridView dgvListadoOrdenCompra;
        private Guna.UI2.WinForms.Guna2TextBox txtOrdenCompraID;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionarOrdenCompra;
    }
}