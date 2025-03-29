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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtIdServicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DgvRequisicionPendiente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRequiPendiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequisicionPendiente)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListRequiPendientes
            // 
            this.btnListRequiPendientes.BorderRadius = 20;
            this.btnListRequiPendientes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListRequiPendientes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListRequiPendientes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListRequiPendientes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListRequiPendientes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(92)))), ((int)(((byte)(197)))));
            this.btnListRequiPendientes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnListRequiPendientes.ForeColor = System.Drawing.Color.White;
            this.btnListRequiPendientes.Location = new System.Drawing.Point(75, 109);
            this.btnListRequiPendientes.Name = "btnListRequiPendientes";
            this.btnListRequiPendientes.Size = new System.Drawing.Size(118, 44);
            this.btnListRequiPendientes.TabIndex = 0;
            this.btnListRequiPendientes.Text = "Ver Listado";
            this.btnListRequiPendientes.Click += new System.EventHandler(this.btnListRequiPendientes_Click);
            // 
            // txtIDRequisicionPendiente
            // 
            this.txtIDRequisicionPendiente.Location = new System.Drawing.Point(87, 169);
            this.txtIDRequisicionPendiente.Name = "txtIDRequisicionPendiente";
            this.txtIDRequisicionPendiente.ReadOnly = true;
            this.txtIDRequisicionPendiente.Size = new System.Drawing.Size(92, 20);
            this.txtIDRequisicionPendiente.TabIndex = 1;
            // 
            // dgvDetalleRequiPendiente
            // 
            this.dgvDetalleRequiPendiente.AllowUserToAddRows = false;
            this.dgvDetalleRequiPendiente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgvDetalleRequiPendiente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleRequiPendiente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetalleRequiPendiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleRequiPendiente.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDetalleRequiPendiente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalleRequiPendiente.Location = new System.Drawing.Point(320, 331);
            this.dgvDetalleRequiPendiente.Name = "dgvDetalleRequiPendiente";
            this.dgvDetalleRequiPendiente.RowHeadersVisible = false;
            this.dgvDetalleRequiPendiente.Size = new System.Drawing.Size(878, 192);
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
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modificar cantidad";
            // 
            // btnModificarCantidadRequi
            // 
            this.btnModificarCantidadRequi.BorderRadius = 20;
            this.btnModificarCantidadRequi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarCantidadRequi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarCantidadRequi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificarCantidadRequi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificarCantidadRequi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(92)))), ((int)(((byte)(197)))));
            this.btnModificarCantidadRequi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificarCantidadRequi.ForeColor = System.Drawing.Color.White;
            this.btnModificarCantidadRequi.Location = new System.Drawing.Point(75, 416);
            this.btnModificarCantidadRequi.Name = "btnModificarCantidadRequi";
            this.btnModificarCantidadRequi.Size = new System.Drawing.Size(118, 44);
            this.btnModificarCantidadRequi.TabIndex = 5;
            this.btnModificarCantidadRequi.Text = "Modificar";
            this.btnModificarCantidadRequi.Click += new System.EventHandler(this.btnModificarCantidadRequi_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Control;
            this.txtCantidad.Location = new System.Drawing.Point(104, 477);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(58, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // btnAprobarRequi
            // 
            this.btnAprobarRequi.BorderRadius = 20;
            this.btnAprobarRequi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAprobarRequi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAprobarRequi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAprobarRequi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAprobarRequi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(83)))));
            this.btnAprobarRequi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAprobarRequi.ForeColor = System.Drawing.Color.White;
            this.btnAprobarRequi.Location = new System.Drawing.Point(886, 187);
            this.btnAprobarRequi.Name = "btnAprobarRequi";
            this.btnAprobarRequi.Size = new System.Drawing.Size(118, 44);
            this.btnAprobarRequi.TabIndex = 7;
            this.btnAprobarRequi.Text = "Aprobar";
            this.btnAprobarRequi.Click += new System.EventHandler(this.btnAprobarRequi_Click);
            // 
            // btnRechazarRequi
            // 
            this.btnRechazarRequi.BorderRadius = 20;
            this.btnRechazarRequi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRechazarRequi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRechazarRequi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRechazarRequi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRechazarRequi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btnRechazarRequi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRechazarRequi.ForeColor = System.Drawing.Color.White;
            this.btnRechazarRequi.Location = new System.Drawing.Point(1050, 187);
            this.btnRechazarRequi.Name = "btnRechazarRequi";
            this.btnRechazarRequi.Size = new System.Drawing.Size(118, 44);
            this.btnRechazarRequi.TabIndex = 8;
            this.btnRechazarRequi.Text = "Rechazar";
            this.btnRechazarRequi.Click += new System.EventHandler(this.btnRechazarRequi_Click);
            // 
            // btnRechazarProducto
            // 
            this.btnRechazarProducto.BorderRadius = 20;
            this.btnRechazarProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRechazarProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRechazarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRechazarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRechazarProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btnRechazarProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRechazarProducto.ForeColor = System.Drawing.Color.White;
            this.btnRechazarProducto.Location = new System.Drawing.Point(988, 539);
            this.btnRechazarProducto.Name = "btnRechazarProducto";
            this.btnRechazarProducto.Size = new System.Drawing.Size(129, 44);
            this.btnRechazarProducto.TabIndex = 10;
            this.btnRechazarProducto.Text = "Rechazar Producto/Servicio";
            this.btnRechazarProducto.Click += new System.EventHandler(this.btnRechazarProducto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(213)))), ((int)(((byte)(229)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Detalle de la Requisición";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(213)))), ((int)(((byte)(229)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 45);
            this.label3.TabIndex = 12;
            this.label3.Text = "Aprobar Requisiciones";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(464, 539);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(58, 20);
            this.txtIdProducto.TabIndex = 13;
            // 
            // txtIdServicio
            // 
            this.txtIdServicio.Location = new System.Drawing.Point(665, 540);
            this.txtIdServicio.Name = "txtIdServicio";
            this.txtIdServicio.ReadOnly = true;
            this.txtIdServicio.Size = new System.Drawing.Size(58, 20);
            this.txtIdServicio.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(213)))), ((int)(((byte)(229)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(579, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(213)))), ((int)(((byte)(229)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID Producto";
            // 
            // DgvRequisicionPendiente
            // 
            this.DgvRequisicionPendiente.AllowUserToAddRows = false;
            this.DgvRequisicionPendiente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.DgvRequisicionPendiente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRequisicionPendiente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvRequisicionPendiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvRequisicionPendiente.DefaultCellStyle = dataGridViewCellStyle13;
            this.DgvRequisicionPendiente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvRequisicionPendiente.Location = new System.Drawing.Point(320, 89);
            this.DgvRequisicionPendiente.MultiSelect = false;
            this.DgvRequisicionPendiente.Name = "DgvRequisicionPendiente";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRequisicionPendiente.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DgvRequisicionPendiente.RowHeadersVisible = false;
            this.DgvRequisicionPendiente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvRequisicionPendiente.Size = new System.Drawing.Size(878, 92);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.btnListRequiPendientes);
            this.panel1.Controls.Add(this.txtIDRequisicionPendiente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnModificarCantidadRequi);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 652);
            this.panel1.TabIndex = 18;
            // 
            // FrmAprobarRequisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvRequisicionPendiente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdServicio);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRechazarProducto);
            this.Controls.Add(this.btnRechazarRequi);
            this.Controls.Add(this.btnAprobarRequi);
            this.Controls.Add(this.dgvDetalleRequiPendiente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmAprobarRequisicion";
            this.Text = "FrmAprobarRequisicion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRequiPendiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequisicionPendiente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtIdServicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView DgvRequisicionPendiente;
        private System.Windows.Forms.Panel panel1;
    }
}