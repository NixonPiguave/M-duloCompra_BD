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
            this.btnRechazarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDerivar = new Guna.UI2.WinForms.Guna2Button();
            this.DgvRequisicionPendiente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAprobarRequi = new Guna.UI2.WinForms.Guna2Button();
            this.btnRechazarRequi = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRequiPendiente)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequisicionPendiente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListRequiPendientes
            // 
            this.btnListRequiPendientes.BorderRadius = 10;
            this.btnListRequiPendientes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListRequiPendientes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListRequiPendientes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListRequiPendientes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListRequiPendientes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnListRequiPendientes.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListRequiPendientes.ForeColor = System.Drawing.Color.White;
            this.btnListRequiPendientes.Location = new System.Drawing.Point(22, 47);
            this.btnListRequiPendientes.Name = "btnListRequiPendientes";
            this.btnListRequiPendientes.Size = new System.Drawing.Size(121, 39);
            this.btnListRequiPendientes.TabIndex = 0;
            this.btnListRequiPendientes.Text = "Listado";
            this.btnListRequiPendientes.Click += new System.EventHandler(this.btnListRequiPendientes_Click);
            // 
            // txtIDRequisicionPendiente
            // 
            this.txtIDRequisicionPendiente.BackColor = System.Drawing.Color.White;
            this.txtIDRequisicionPendiente.Location = new System.Drawing.Point(43, 104);
            this.txtIDRequisicionPendiente.Name = "txtIDRequisicionPendiente";
            this.txtIDRequisicionPendiente.ReadOnly = true;
            this.txtIDRequisicionPendiente.Size = new System.Drawing.Size(92, 20);
            this.txtIDRequisicionPendiente.TabIndex = 1;
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
            this.dgvDetalleRequiPendiente.Location = new System.Drawing.Point(22, 69);
            this.dgvDetalleRequiPendiente.Name = "dgvDetalleRequiPendiente";
            this.dgvDetalleRequiPendiente.RowHeadersVisible = false;
            this.dgvDetalleRequiPendiente.Size = new System.Drawing.Size(921, 153);
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
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modificar cantidad";
            // 
            // btnModificarCantidadRequi
            // 
            this.btnModificarCantidadRequi.Animated = true;
            this.btnModificarCantidadRequi.BorderRadius = 10;
            this.btnModificarCantidadRequi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarCantidadRequi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarCantidadRequi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificarCantidadRequi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificarCantidadRequi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnModificarCantidadRequi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCantidadRequi.ForeColor = System.Drawing.Color.White;
            this.btnModificarCantidadRequi.IndicateFocus = true;
            this.btnModificarCantidadRequi.Location = new System.Drawing.Point(248, 25);
            this.btnModificarCantidadRequi.Name = "btnModificarCantidadRequi";
            this.btnModificarCantidadRequi.Size = new System.Drawing.Size(163, 38);
            this.btnModificarCantidadRequi.TabIndex = 5;
            this.btnModificarCantidadRequi.Text = "Modificar";
            this.btnModificarCantidadRequi.Click += new System.EventHandler(this.btnModificarCantidadRequi_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(91, 34);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(118, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // btnRechazarProducto
            // 
            this.btnRechazarProducto.Animated = true;
            this.btnRechazarProducto.BorderRadius = 10;
            this.btnRechazarProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRechazarProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRechazarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRechazarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRechazarProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnRechazarProducto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazarProducto.ForeColor = System.Drawing.Color.White;
            this.btnRechazarProducto.IndicateFocus = true;
            this.btnRechazarProducto.Location = new System.Drawing.Point(404, 287);
            this.btnRechazarProducto.Name = "btnRechazarProducto";
            this.btnRechazarProducto.Size = new System.Drawing.Size(166, 44);
            this.btnRechazarProducto.TabIndex = 10;
            this.btnRechazarProducto.Text = "Rechazar Producto";
            this.btnRechazarProducto.Click += new System.EventHandler(this.btnRechazarProducto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(935, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Detalle de la Requisición";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BackColor = System.Drawing.Color.White;
            this.txtIdProducto.Location = new System.Drawing.Point(348, 588);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(58, 20);
            this.txtIdProducto.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 588);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID Producto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.btnRechazarProducto);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtIdProducto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1362, 631);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnListRequiPendientes);
            this.panel3.Controls.Add(this.txtIDRequisicionPendiente);
            this.panel3.Location = new System.Drawing.Point(41, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 148);
            this.panel3.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ver Listado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnModificarCantidadRequi);
            this.panel1.Controls.Add(this.dgvDetalleRequiPendiente);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Location = new System.Drawing.Point(217, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 245);
            this.panel1.TabIndex = 17;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.btnDerivar);
            this.guna2Panel1.Controls.Add(this.DgvRequisicionPendiente);
            this.guna2Panel1.Controls.Add(this.btnAprobarRequi);
            this.guna2Panel1.Controls.Add(this.btnRechazarRequi);
            this.guna2Panel1.Location = new System.Drawing.Point(217, 60);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(970, 212);
            this.guna2Panel1.TabIndex = 3;
            // 
            // btnDerivar
            // 
            this.btnDerivar.Animated = true;
            this.btnDerivar.BorderRadius = 10;
            this.btnDerivar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDerivar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDerivar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDerivar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDerivar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnDerivar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerivar.ForeColor = System.Drawing.Color.White;
            this.btnDerivar.IndicateFocus = true;
            this.btnDerivar.Location = new System.Drawing.Point(825, 154);
            this.btnDerivar.Name = "btnDerivar";
            this.btnDerivar.Size = new System.Drawing.Size(118, 44);
            this.btnDerivar.TabIndex = 18;
            this.btnDerivar.Text = "Derivar";
            this.btnDerivar.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.DgvRequisicionPendiente.Location = new System.Drawing.Point(22, 21);
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
            this.DgvRequisicionPendiente.Size = new System.Drawing.Size(921, 127);
            this.DgvRequisicionPendiente.TabIndex = 17;
            this.DgvRequisicionPendiente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvRequisicionPendiente.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvRequisicionPendiente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvRequisicionPendiente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvRequisicionPendiente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvRequisicionPendiente.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvRequisicionPendiente.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvRequisicionPendiente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.DgvRequisicionPendiente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvRequisicionPendiente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvRequisicionPendiente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvRequisicionPendiente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvRequisicionPendiente.ThemeStyle.HeaderStyle.Height = 23;
            this.DgvRequisicionPendiente.ThemeStyle.ReadOnly = false;
            this.DgvRequisicionPendiente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvRequisicionPendiente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvRequisicionPendiente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvRequisicionPendiente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.DgvRequisicionPendiente.ThemeStyle.RowsStyle.Height = 22;
            this.DgvRequisicionPendiente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.DgvRequisicionPendiente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            // 
            // btnAprobarRequi
            // 
            this.btnAprobarRequi.Animated = true;
            this.btnAprobarRequi.BorderRadius = 10;
            this.btnAprobarRequi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAprobarRequi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAprobarRequi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAprobarRequi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAprobarRequi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnAprobarRequi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobarRequi.ForeColor = System.Drawing.Color.White;
            this.btnAprobarRequi.IndicateFocus = true;
            this.btnAprobarRequi.Location = new System.Drawing.Point(498, 154);
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
            this.btnRechazarRequi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnRechazarRequi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazarRequi.ForeColor = System.Drawing.Color.White;
            this.btnRechazarRequi.IndicateFocus = true;
            this.btnRechazarRequi.Location = new System.Drawing.Point(667, 154);
            this.btnRechazarRequi.Name = "btnRechazarRequi";
            this.btnRechazarRequi.Size = new System.Drawing.Size(118, 44);
            this.btnRechazarRequi.TabIndex = 8;
            this.btnRechazarRequi.Text = "Rechazar";
            this.btnRechazarRequi.Click += new System.EventHandler(this.btnRechazarRequi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(444, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(505, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "APROBAR REQUISICIONES PENDIENTES";
            // 
            // FrmAprobarRequisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1386, 655);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAprobarRequisicion";
            this.Text = "FrmAprobarRequisicion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRequiPendiente)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequisicionPendiente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnListRequiPendientes;
        private System.Windows.Forms.TextBox txtIDRequisicionPendiente;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetalleRequiPendiente;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnModificarCantidadRequi;
        private System.Windows.Forms.TextBox txtCantidad;
        private Guna.UI2.WinForms.Guna2Button btnRechazarProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DgvRequisicionPendiente;
        private Guna.UI2.WinForms.Guna2Button btnAprobarRequi;
        private Guna.UI2.WinForms.Guna2Button btnRechazarRequi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnDerivar;
    }
}