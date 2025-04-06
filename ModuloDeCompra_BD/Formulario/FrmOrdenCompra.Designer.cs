namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmOrdenCompra
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
            this.lblFechaLimite = new System.Windows.Forms.Label();
            this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEscogerRequisicion = new Guna.UI2.WinForms.Guna2Button();
            this.dtpFechaLimite = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtRequisicionID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProve = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEstadoOrden = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRequisicionID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblOrdenID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtProveedor = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRequisiciones = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisiciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaLimite
            // 
            this.lblFechaLimite.AutoSize = true;
            this.lblFechaLimite.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaLimite.ForeColor = System.Drawing.Color.White;
            this.lblFechaLimite.Location = new System.Drawing.Point(592, 27);
            this.lblFechaLimite.Name = "lblFechaLimite";
            this.lblFechaLimite.Size = new System.Drawing.Size(115, 22);
            this.lblFechaLimite.TabIndex = 0;
            this.lblFechaLimite.Text = "Fecha limite";
            this.lblFechaLimite.Click += new System.EventHandler(this.lblFechaLimite_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BorderRadius = 10;
            this.btnAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAceptar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnAceptar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(833, 77);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(180, 53);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Crear Orden Compra";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnEscogerRequisicion
            // 
            this.btnEscogerRequisicion.BorderRadius = 10;
            this.btnEscogerRequisicion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEscogerRequisicion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEscogerRequisicion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEscogerRequisicion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEscogerRequisicion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnEscogerRequisicion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscogerRequisicion.ForeColor = System.Drawing.Color.White;
            this.btnEscogerRequisicion.Location = new System.Drawing.Point(30, 112);
            this.btnEscogerRequisicion.Name = "btnEscogerRequisicion";
            this.btnEscogerRequisicion.Size = new System.Drawing.Size(160, 54);
            this.btnEscogerRequisicion.TabIndex = 9;
            this.btnEscogerRequisicion.Text = "Escoger Requisicion";
            this.btnEscogerRequisicion.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.BorderRadius = 10;
            this.dtpFechaLimite.Checked = true;
            this.dtpFechaLimite.FillColor = System.Drawing.Color.White;
            this.dtpFechaLimite.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaLimite.Location = new System.Drawing.Point(513, 59);
            this.dtpFechaLimite.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaLimite.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(266, 36);
            this.dtpFechaLimite.TabIndex = 10;
            this.dtpFechaLimite.Value = new System.DateTime(2025, 3, 15, 0, 20, 34, 412);
            this.dtpFechaLimite.ValueChanged += new System.EventHandler(this.dtpFechaLimite_ValueChanged);
            // 
            // txtRequisicionID
            // 
            this.txtRequisicionID.BorderRadius = 5;
            this.txtRequisicionID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRequisicionID.DefaultText = "";
            this.txtRequisicionID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRequisicionID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRequisicionID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRequisicionID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRequisicionID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRequisicionID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRequisicionID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRequisicionID.Location = new System.Drawing.Point(49, 59);
            this.txtRequisicionID.Name = "txtRequisicionID";
            this.txtRequisicionID.PlaceholderText = "";
            this.txtRequisicionID.ReadOnly = true;
            this.txtRequisicionID.SelectedText = "";
            this.txtRequisicionID.Size = new System.Drawing.Size(130, 36);
            this.txtRequisicionID.TabIndex = 12;
            // 
            // txtProve
            // 
            this.txtProve.BackColor = System.Drawing.Color.Transparent;
            this.txtProve.BorderRadius = 5;
            this.txtProve.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProve.DefaultText = "";
            this.txtProve.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProve.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProve.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProve.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProve.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProve.Location = new System.Drawing.Point(294, 59);
            this.txtProve.Name = "txtProve";
            this.txtProve.PlaceholderText = "";
            this.txtProve.ReadOnly = true;
            this.txtProve.SelectedText = "";
            this.txtProve.Size = new System.Drawing.Size(133, 36);
            this.txtProve.TabIndex = 15;
            // 
            // lblEstadoOrden
            // 
            this.lblEstadoOrden.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoOrden.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEstadoOrden.Location = new System.Drawing.Point(117, 345);
            this.lblEstadoOrden.Name = "lblEstadoOrden";
            this.lblEstadoOrden.Size = new System.Drawing.Size(102, 22);
            this.lblEstadoOrden.TabIndex = 5;
            this.lblEstadoOrden.Text = "Estado Orden";
            // 
            // lblRequisicionID
            // 
            this.lblRequisicionID.BackColor = System.Drawing.Color.Transparent;
            this.lblRequisicionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisicionID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRequisicionID.Location = new System.Drawing.Point(117, 254);
            this.lblRequisicionID.Name = "lblRequisicionID";
            this.lblRequisicionID.Size = new System.Drawing.Size(85, 22);
            this.lblRequisicionID.TabIndex = 11;
            this.lblRequisicionID.Text = "Requisición";
            // 
            // lblOrdenID
            // 
            this.lblOrdenID.BackColor = System.Drawing.Color.Transparent;
            this.lblOrdenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOrdenID.Location = new System.Drawing.Point(134, 75);
            this.lblOrdenID.Name = "lblOrdenID";
            this.lblOrdenID.Size = new System.Drawing.Size(68, 22);
            this.lblOrdenID.TabIndex = 13;
            this.lblOrdenID.Text = "Orden ID";
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.Color.Transparent;
            this.txtProveedor.BorderRadius = 10;
            this.txtProveedor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProveedor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtProveedor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.txtProveedor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.ForeColor = System.Drawing.Color.White;
            this.txtProveedor.Location = new System.Drawing.Point(284, 112);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(159, 54);
            this.txtProveedor.TabIndex = 16;
            this.txtProveedor.Text = "Escoger Proveedor";
            this.txtProveedor.Click += new System.EventHandler(this.txtProveedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(311, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID Requisicion";
            // 
            // dgvRequisiciones
            // 
            this.dgvRequisiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequisiciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRequisiciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequisiciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRequisiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisiciones.Location = new System.Drawing.Point(49, 37);
            this.dgvRequisiciones.Name = "dgvRequisiciones";
            this.dgvRequisiciones.RowHeadersVisible = false;
            this.dgvRequisiciones.Size = new System.Drawing.Size(1038, 181);
            this.dgvRequisiciones.TabIndex = 21;
            this.dgvRequisiciones.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvRequisiciones_DataError);
            this.dgvRequisiciones.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvRequisiciones_EditingControlShowing);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(479, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(491, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "ORDEN DE COMPRA POR REQUISICIÓN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.dgvRequisiciones);
            this.panel1.Location = new System.Drawing.Point(126, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 261);
            this.panel1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(171, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Detalle Requisición seleccionada";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.txtRequisicionID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnEscogerRequisicion);
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Controls.Add(this.txtProve);
            this.panel2.Controls.Add(this.dtpFechaLimite);
            this.panel2.Controls.Add(this.lblFechaLimite);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtProveedor);
            this.panel2.Location = new System.Drawing.Point(191, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 188);
            this.panel2.TabIndex = 25;
            // 
            // FrmOrdenCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1386, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrdenCompras";
            this.Load += new System.EventHandler(this.FrmOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisiciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFechaLimite;
        private Guna.UI2.WinForms.Guna2Button btnAceptar;
        private Guna.UI2.WinForms.Guna2Button btnEscogerRequisicion;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaLimite;
        private Guna.UI2.WinForms.Guna2TextBox txtRequisicionID;
        private Guna.UI2.WinForms.Guna2TextBox txtProve;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEstadoOrden;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRequisicionID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOrdenID;
        private Guna.UI2.WinForms.Guna2Button txtProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRequisiciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}