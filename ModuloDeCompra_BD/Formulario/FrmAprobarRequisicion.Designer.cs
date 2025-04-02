namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmAprobarRequisicion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnListRequiPendientes = new Guna.UI2.WinForms.Guna2Button();
            this.txtIDRequisicionPendiente = new System.Windows.Forms.TextBox();
            this.dgvDetalleRequiPendiente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarCantidadRequi = new Guna.UI2.WinForms.Guna2Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAprobarRequi = new Guna.UI2.WinForms.Guna2Button();
            this.btnRechazarRequi = new Guna.UI2.WinForms.Guna2Button();
            this.btnRechazarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtIdServicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DgvRequisicionPendiente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRequiPendiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequisicionPendiente)).BeginInit();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListRequiPendientes
            // 
            this.btnListRequiPendientes.BorderRadius = 10;
            this.btnListRequiPendientes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListRequiPendientes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListRequiPendientes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListRequiPendientes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListRequiPendientes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnListRequiPendientes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnListRequiPendientes.ForeColor = System.Drawing.Color.White;
            this.btnListRequiPendientes.Location = new System.Drawing.Point(41, 46);
            this.btnListRequiPendientes.Name = "btnListRequiPendientes";
            this.btnListRequiPendientes.Size = new System.Drawing.Size(118, 31);
            this.btnListRequiPendientes.TabIndex = 0;
            this.btnListRequiPendientes.Text = "Ver Listado";
            this.btnListRequiPendientes.Click += new System.EventHandler(this.btnListRequiPendientes_Click);
            // 
            // txtIDRequisicionPendiente
            // 
            this.txtIDRequisicionPendiente.BackColor = System.Drawing.Color.White;
            this.txtIDRequisicionPendiente.Location = new System.Drawing.Point(51, 83);
            this.txtIDRequisicionPendiente.Name = "txtIDRequisicionPendiente";
            this.txtIDRequisicionPendiente.ReadOnly = true;
            this.txtIDRequisicionPendiente.Size = new System.Drawing.Size(92, 20);
            this.txtIDRequisicionPendiente.TabIndex = 1;
            this.txtIDRequisicionPendiente.TextChanged += new System.EventHandler(this.txtIDRequisicionPendiente_TextChanged);
            // 
            // dgvDetalleRequiPendiente
            // 
            this.dgvDetalleRequiPendiente.AllowUserToAddRows = false;
            this.dgvDetalleRequiPendiente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDetalleRequiPendiente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleRequiPendiente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleRequiPendiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleRequiPendiente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleRequiPendiente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalleRequiPendiente.Location = new System.Drawing.Point(205, 337);
            this.dgvDetalleRequiPendiente.Name = "dgvDetalleRequiPendiente";
            this.dgvDetalleRequiPendiente.RowHeadersVisible = false;
            this.dgvDetalleRequiPendiente.Size = new System.Drawing.Size(1139, 187);
            this.dgvDetalleRequiPendiente.TabIndex = 3;
            this.dgvDetalleRequiPendiente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalleRequiPendiente.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDetalleRequiPendiente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDetalleRequiPendiente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDetalleRequiPendiente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDetalleRequiPendiente.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalleRequiPendiente.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalleRequiPendiente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDetalleRequiPendiente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalleRequiPendiente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleRequiPendiente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetalleRequiPendiente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDetalleRequiPendiente.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvDetalleRequiPendiente.ThemeStyle.ReadOnly = false;
            this.dgvDetalleRequiPendiente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalleRequiPendiente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleRequiPendiente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleRequiPendiente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDetalleRequiPendiente.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDetalleRequiPendiente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalleRequiPendiente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDetalleRequiPendiente.DoubleClick += new System.EventHandler(this.dgvDetalleRequiPendiente_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(37, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modificar cantidad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnModificarCantidadRequi
            // 
            this.btnModificarCantidadRequi.Animated = true;
            this.btnModificarCantidadRequi.BorderRadius = 10;
            this.btnModificarCantidadRequi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarCantidadRequi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarCantidadRequi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificarCantidadRequi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificarCantidadRequi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnModificarCantidadRequi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificarCantidadRequi.ForeColor = System.Drawing.Color.White;
            this.btnModificarCantidadRequi.IndicateFocus = true;
            this.btnModificarCantidadRequi.Location = new System.Drawing.Point(41, 395);
            this.btnModificarCantidadRequi.Name = "btnModificarCantidadRequi";
            this.btnModificarCantidadRequi.Size = new System.Drawing.Size(118, 30);
            this.btnModificarCantidadRequi.TabIndex = 5;
            this.btnModificarCantidadRequi.Text = "Modificar";
            this.btnModificarCantidadRequi.Click += new System.EventHandler(this.btnModificarCantidadRequi_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(41, 431);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(118, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // btnAprobarRequi
            // 
            this.btnAprobarRequi.Animated = true;
            this.btnAprobarRequi.BorderRadius = 10;
            this.btnAprobarRequi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAprobarRequi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAprobarRequi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAprobarRequi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAprobarRequi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnAprobarRequi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAprobarRequi.ForeColor = System.Drawing.Color.White;
            this.btnAprobarRequi.IndicateFocus = true;
            this.btnAprobarRequi.Location = new System.Drawing.Point(864, 146);
            this.btnAprobarRequi.Name = "btnAprobarRequi";
            this.btnAprobarRequi.Size = new System.Drawing.Size(118, 44);
            this.btnAprobarRequi.TabIndex = 7;
            this.btnAprobarRequi.Text = "Aprobar";
            this.btnAprobarRequi.Click += new System.EventHandler(this.btnAprobarRequi_Click);
            // 
            // btnRechazarRequi
            // 
            this.btnRechazarRequi.Animated = true;
            this.btnRechazarRequi.BorderRadius = 10;
            this.btnRechazarRequi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRechazarRequi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRechazarRequi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRechazarRequi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRechazarRequi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnRechazarRequi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRechazarRequi.ForeColor = System.Drawing.Color.White;
            this.btnRechazarRequi.IndicateFocus = true;
            this.btnRechazarRequi.Location = new System.Drawing.Point(1012, 146);
            this.btnRechazarRequi.Name = "btnRechazarRequi";
            this.btnRechazarRequi.Size = new System.Drawing.Size(118, 44);
            this.btnRechazarRequi.TabIndex = 8;
            this.btnRechazarRequi.Text = "Rechazar";
            this.btnRechazarRequi.Click += new System.EventHandler(this.btnRechazarRequi_Click);
            // 
            // btnRechazarProducto
            // 
            this.btnRechazarProducto.Animated = true;
            this.btnRechazarProducto.BorderRadius = 10;
            this.btnRechazarProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRechazarProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRechazarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRechazarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRechazarProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnRechazarProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRechazarProducto.ForeColor = System.Drawing.Color.White;
            this.btnRechazarProducto.IndicateFocus = true;
            this.btnRechazarProducto.Location = new System.Drawing.Point(662, 539);
            this.btnRechazarProducto.Name = "btnRechazarProducto";
            this.btnRechazarProducto.Size = new System.Drawing.Size(166, 44);
            this.btnRechazarProducto.TabIndex = 10;
            this.btnRechazarProducto.Text = "Rechazar Producto/Servicio";
            this.btnRechazarProducto.Click += new System.EventHandler(this.btnRechazarProducto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.Location = new System.Drawing.Point(598, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Detalle de la Requisición";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BackColor = System.Drawing.Color.White;
            this.txtIdProducto.Location = new System.Drawing.Point(324, 542);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(58, 20);
            this.txtIdProducto.TabIndex = 13;
            // 
            // txtIdServicio
            // 
            this.txtIdServicio.BackColor = System.Drawing.Color.White;
            this.txtIdServicio.Location = new System.Drawing.Point(551, 541);
            this.txtIdServicio.Name = "txtIdServicio";
            this.txtIdServicio.ReadOnly = true;
            this.txtIdServicio.Size = new System.Drawing.Size(58, 20);
            this.txtIdServicio.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(453, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(218, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID Producto";
            // 
            // DgvRequisicionPendiente
            // 
            this.DgvRequisicionPendiente.AllowUserToAddRows = false;
            this.DgvRequisicionPendiente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DgvRequisicionPendiente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRequisicionPendiente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvRequisicionPendiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvRequisicionPendiente.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvRequisicionPendiente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvRequisicionPendiente.Location = new System.Drawing.Point(25, 19);
            this.DgvRequisicionPendiente.MultiSelect = false;
            this.DgvRequisicionPendiente.Name = "DgvRequisicionPendiente";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRequisicionPendiente.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvRequisicionPendiente.RowHeadersVisible = false;
            this.DgvRequisicionPendiente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvRequisicionPendiente.Size = new System.Drawing.Size(1105, 113);
            this.DgvRequisicionPendiente.TabIndex = 17;
            this.DgvRequisicionPendiente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvRequisicionPendiente.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvRequisicionPendiente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvRequisicionPendiente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvRequisicionPendiente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvRequisicionPendiente.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvRequisicionPendiente.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvRequisicionPendiente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvRequisicionPendiente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvRequisicionPendiente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvRequisicionPendiente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvRequisicionPendiente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvRequisicionPendiente.ThemeStyle.HeaderStyle.Height = 23;
            this.DgvRequisicionPendiente.ThemeStyle.ReadOnly = false;
            this.DgvRequisicionPendiente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvRequisicionPendiente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvRequisicionPendiente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvRequisicionPendiente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvRequisicionPendiente.ThemeStyle.RowsStyle.Height = 22;
            this.DgvRequisicionPendiente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvRequisicionPendiente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtIDRequisicionPendiente);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtIdServicio);
            this.panel2.Controls.Add(this.btnModificarCantidadRequi);
            this.panel2.Controls.Add(this.txtIdProducto);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnListRequiPendientes);
            this.panel2.Controls.Add(this.btnRechazarProducto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dgvDetalleRequiPendiente);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1362, 631);
            this.panel2.TabIndex = 19;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.DgvRequisicionPendiente);
            this.guna2Panel1.Controls.Add(this.btnAprobarRequi);
            this.guna2Panel1.Controls.Add(this.btnRechazarRequi);
            this.guna2Panel1.Location = new System.Drawing.Point(180, 46);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1164, 205);
            this.guna2Panel1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label9.Location = new System.Drawing.Point(539, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(422, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "APROBAR REQUISICIONES PENDIENTES";
            // 
            // FrmAprobarRequisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 655);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAprobarRequisicion";
            this.Text = "FrmAprobarRequisicion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRequiPendiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequisicionPendiente)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnListRequiPendientes;
        private System.Windows.Forms.TextBox txtIDRequisicionPendiente;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetalleRequiPendiente;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnModificarCantidadRequi;
        private System.Windows.Forms.TextBox txtCantidad;
        private Guna.UI2.WinForms.Guna2Button btnAprobarRequi;
        private Guna.UI2.WinForms.Guna2Button btnRechazarRequi;
        private Guna.UI2.WinForms.Guna2Button btnRechazarProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtIdServicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView DgvRequisicionPendiente;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label9;
    }
}