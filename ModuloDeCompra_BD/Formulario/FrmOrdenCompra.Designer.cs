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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisiciones)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaLimite
            // 
            this.lblFechaLimite.AutoSize = true;
            this.lblFechaLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaLimite.ForeColor = System.Drawing.Color.White;
            this.lblFechaLimite.Location = new System.Drawing.Point(142, 301);
            this.lblFechaLimite.Name = "lblFechaLimite";
            this.lblFechaLimite.Size = new System.Drawing.Size(94, 20);
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
            this.btnAceptar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(100, 418);
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
            this.btnEscogerRequisicion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnEscogerRequisicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscogerRequisicion.ForeColor = System.Drawing.Color.White;
            this.btnEscogerRequisicion.Location = new System.Drawing.Point(85, 241);
            this.btnEscogerRequisicion.Name = "btnEscogerRequisicion";
            this.btnEscogerRequisicion.Size = new System.Drawing.Size(195, 39);
            this.btnEscogerRequisicion.TabIndex = 9;
            this.btnEscogerRequisicion.Text = "Escoger Requisicion";
            this.btnEscogerRequisicion.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.BorderRadius = 10;
            this.dtpFechaLimite.Checked = true;
            this.dtpFechaLimite.FillColor = System.Drawing.Color.White;
            this.dtpFechaLimite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaLimite.Location = new System.Drawing.Point(91, 333);
            this.dtpFechaLimite.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaLimite.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(200, 36);
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
            this.txtRequisicionID.Location = new System.Drawing.Point(121, 199);
            this.txtRequisicionID.Name = "txtRequisicionID";
            this.txtRequisicionID.PlaceholderText = "";
            this.txtRequisicionID.ReadOnly = true;
            this.txtRequisicionID.SelectedText = "";
            this.txtRequisicionID.Size = new System.Drawing.Size(130, 36);
            this.txtRequisicionID.TabIndex = 12;
            // 
            // txtProve
            // 
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
            this.txtProve.Location = new System.Drawing.Point(81, 57);
            this.txtProve.Name = "txtProve";
            this.txtProve.PlaceholderText = "";
            this.txtProve.ReadOnly = true;
            this.txtProve.SelectedText = "";
            this.txtProve.Size = new System.Drawing.Size(200, 36);
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
            this.txtProveedor.BorderRadius = 10;
            this.txtProveedor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProveedor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtProveedor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.ForeColor = System.Drawing.Color.White;
            this.txtProveedor.Location = new System.Drawing.Point(86, 99);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(194, 41);
            this.txtProveedor.TabIndex = 16;
            this.txtProveedor.Text = "Escoger Proveedor";
            this.txtProveedor.Click += new System.EventHandler(this.txtProveedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(133, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
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
            this.dgvRequisiciones.Location = new System.Drawing.Point(495, 129);
            this.dgvRequisiciones.Name = "dgvRequisiciones";
            this.dgvRequisiciones.Size = new System.Drawing.Size(836, 395);
            this.dgvRequisiciones.TabIndex = 21;
            this.dgvRequisiciones.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvRequisiciones_DataError);
            this.dgvRequisiciones.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvRequisiciones_EditingControlShowing);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(715, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Detalle Requisición Seleccionada";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.guna2Panel2.Controls.Add(this.txtProveedor);
            this.guna2Panel2.Controls.Add(this.txtProve);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.txtRequisicionID);
            this.guna2Panel2.Controls.Add(this.btnEscogerRequisicion);
            this.guna2Panel2.Controls.Add(this.btnAceptar);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.dtpFechaLimite);
            this.guna2Panel2.Controls.Add(this.lblFechaLimite);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(434, 663);
            this.guna2Panel2.TabIndex = 23;
            // 
            // FrmOrdenCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1386, 663);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvRequisiciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrdenCompras";
            this.Load += new System.EventHandler(this.FrmOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisiciones)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}