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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEstadoRequision = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.lblOrdenID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtRequisicionID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRequisicionID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpFechaLimite = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnEscogerRequisicion = new Guna.UI2.WinForms.Guna2Button();
            this.cmbEstadoOrden = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.lblEstadoOrden = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFechaLimite = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOrdenCompra = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoRequision)).BeginInit();
            this.pnlSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEstadoRequision
            // 
            this.dgvEstadoRequision.AllowUserToAddRows = false;
            this.dgvEstadoRequision.AllowUserToDeleteRows = false;
            this.dgvEstadoRequision.AllowUserToResizeColumns = false;
            this.dgvEstadoRequision.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvEstadoRequision.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoRequision.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEstadoRequision.ColumnHeadersHeight = 4;
            this.dgvEstadoRequision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstadoRequision.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEstadoRequision.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEstadoRequision.Location = new System.Drawing.Point(448, 12);
            this.dgvEstadoRequision.Name = "dgvEstadoRequision";
            this.dgvEstadoRequision.RowHeadersVisible = false;
            this.dgvEstadoRequision.Size = new System.Drawing.Size(808, 632);
            this.dgvEstadoRequision.TabIndex = 0;
            this.dgvEstadoRequision.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstadoRequision.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEstadoRequision.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEstadoRequision.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEstadoRequision.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEstadoRequision.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstadoRequision.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEstadoRequision.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEstadoRequision.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEstadoRequision.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEstadoRequision.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEstadoRequision.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEstadoRequision.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvEstadoRequision.ThemeStyle.ReadOnly = false;
            this.dgvEstadoRequision.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstadoRequision.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEstadoRequision.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEstadoRequision.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEstadoRequision.ThemeStyle.RowsStyle.Height = 22;
            this.dgvEstadoRequision.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEstadoRequision.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEstadoRequision.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstadoRequision_CellDoubleClick);
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.pnlSubMenu.Controls.Add(this.txtOrdenCompra);
            this.pnlSubMenu.Controls.Add(this.lblOrdenID);
            this.pnlSubMenu.Controls.Add(this.txtRequisicionID);
            this.pnlSubMenu.Controls.Add(this.lblRequisicionID);
            this.pnlSubMenu.Controls.Add(this.dtpFechaLimite);
            this.pnlSubMenu.Controls.Add(this.btnEscogerRequisicion);
            this.pnlSubMenu.Controls.Add(this.cmbEstadoOrden);
            this.pnlSubMenu.Controls.Add(this.btnAceptar);
            this.pnlSubMenu.Controls.Add(this.lblEstadoOrden);
            this.pnlSubMenu.Controls.Add(this.lblFechaLimite);
            this.pnlSubMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSubMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(319, 663);
            this.pnlSubMenu.TabIndex = 1;
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
            // txtRequisicionID
            // 
            this.txtRequisicionID.BorderRadius = 15;
            this.txtRequisicionID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRequisicionID.DefaultText = "";
            this.txtRequisicionID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRequisicionID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRequisicionID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRequisicionID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRequisicionID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRequisicionID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRequisicionID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRequisicionID.Location = new System.Drawing.Point(61, 291);
            this.txtRequisicionID.Name = "txtRequisicionID";
            this.txtRequisicionID.PlaceholderText = "";
            this.txtRequisicionID.SelectedText = "";
            this.txtRequisicionID.Size = new System.Drawing.Size(200, 36);
            this.txtRequisicionID.TabIndex = 12;
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
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.BorderRadius = 15;
            this.dtpFechaLimite.Checked = true;
            this.dtpFechaLimite.FillColor = System.Drawing.Color.White;
            this.dtpFechaLimite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaLimite.Location = new System.Drawing.Point(61, 196);
            this.dtpFechaLimite.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaLimite.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(200, 36);
            this.dtpFechaLimite.TabIndex = 10;
            this.dtpFechaLimite.Value = new System.DateTime(2025, 3, 15, 0, 20, 34, 412);
            // 
            // btnEscogerRequisicion
            // 
            this.btnEscogerRequisicion.BorderRadius = 20;
            this.btnEscogerRequisicion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEscogerRequisicion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEscogerRequisicion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEscogerRequisicion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEscogerRequisicion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnEscogerRequisicion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEscogerRequisicion.ForeColor = System.Drawing.Color.White;
            this.btnEscogerRequisicion.Location = new System.Drawing.Point(12, 591);
            this.btnEscogerRequisicion.Name = "btnEscogerRequisicion";
            this.btnEscogerRequisicion.Size = new System.Drawing.Size(133, 53);
            this.btnEscogerRequisicion.TabIndex = 9;
            this.btnEscogerRequisicion.Text = "Escoger Requisicion";
            this.btnEscogerRequisicion.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // cmbEstadoOrden
            // 
            this.cmbEstadoOrden.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstadoOrden.BorderRadius = 10;
            this.cmbEstadoOrden.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstadoOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoOrden.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEstadoOrden.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEstadoOrden.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstadoOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEstadoOrden.ItemHeight = 30;
            this.cmbEstadoOrden.Items.AddRange(new object[] {
            "Aprobar",
            "Rechazar",
            "Pendiente",
            "Anular"});
            this.cmbEstadoOrden.Location = new System.Drawing.Point(93, 387);
            this.cmbEstadoOrden.Name = "cmbEstadoOrden";
            this.cmbEstadoOrden.Size = new System.Drawing.Size(140, 36);
            this.cmbEstadoOrden.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BorderRadius = 20;
            this.btnAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAceptar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(93, 484);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(140, 53);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Confirmar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            // lblFechaLimite
            // 
            this.lblFechaLimite.AutoSize = true;
            this.lblFechaLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFechaLimite.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaLimite.Location = new System.Drawing.Point(113, 163);
            this.lblFechaLimite.Name = "lblFechaLimite";
            this.lblFechaLimite.Size = new System.Drawing.Size(94, 20);
            this.lblFechaLimite.TabIndex = 0;
            this.lblFechaLimite.Text = "Fecha limite";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(753, 295);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(200, 36);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Visible = false;
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.BorderRadius = 15;
            this.txtOrdenCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrdenCompra.DefaultText = "";
            this.txtOrdenCompra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOrdenCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOrdenCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrdenCompra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrdenCompra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrdenCompra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOrdenCompra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrdenCompra.Location = new System.Drawing.Point(61, 113);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.PlaceholderText = "";
            this.txtOrdenCompra.SelectedText = "";
            this.txtOrdenCompra.Size = new System.Drawing.Size(200, 36);
            this.txtOrdenCompra.TabIndex = 15;
            // 
            // FrmOrdenCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1386, 663);
            this.Controls.Add(this.pnlSubMenu);
            this.Controls.Add(this.dgvEstadoRequision);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrdenCompras";
            this.Load += new System.EventHandler(this.FrmOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoRequision)).EndInit();
            this.pnlSubMenu.ResumeLayout(false);
            this.pnlSubMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSubMenu;
        private System.Windows.Forms.Label lblFechaLimite;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEstadoOrden;
        private Guna.UI2.WinForms.Guna2Button btnAceptar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEstadoOrden;
        private Guna.UI2.WinForms.Guna2Button btnEscogerRequisicion;
        public Guna.UI2.WinForms.Guna2DataGridView dgvEstadoRequision;
        public Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaLimite;
        private Guna.UI2.WinForms.Guna2TextBox txtRequisicionID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRequisicionID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOrdenID;
        private Guna.UI2.WinForms.Guna2TextBox txtOrdenCompra;
    }
}