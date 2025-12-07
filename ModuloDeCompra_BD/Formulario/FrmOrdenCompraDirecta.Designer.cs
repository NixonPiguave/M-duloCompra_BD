namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmOrdenCompraDirecta
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
            this.dtpFechaLimite = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtProveedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEstadoOrden = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRequisicionID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblOrdenID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnProveedor = new Guna.UI2.WinForms.Guna2Button();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.pnlSeleccion = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.dgvListadoProductos = new System.Windows.Forms.DataGridView();
            this.txtFiltroProduc = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.btnProducto = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSeleccionarProductoServicio = new System.Windows.Forms.Panel();
            this.pnlProductosSelect = new System.Windows.Forms.Panel();
            this.btnAgregarP = new Guna.UI2.WinForms.Guna2Button();
            this.txtProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbProduc = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.pnlServiciosSelect = new System.Windows.Forms.Panel();
            this.txtServicio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbIDserv = new System.Windows.Forms.Label();
            this.btnAgregarS = new Guna.UI2.WinForms.Guna2Button();
            this.txtIDServi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbServi = new System.Windows.Forms.Label();
            this.lbCanServ = new System.Windows.Forms.Label();
            this.nudServicio = new System.Windows.Forms.NumericUpDown();
            this.lblProductosSeleccionados = new System.Windows.Forms.Label();
            this.dgvProductosAgregados = new System.Windows.Forms.DataGridView();
            this.pnlSeleccionados = new System.Windows.Forms.Panel();
            this.btnGenerarDocumento = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSeleccion.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).BeginInit();
            this.pnlSeleccionarProductoServicio.SuspendLayout();
            this.pnlProductosSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.pnlServiciosSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAgregados)).BeginInit();
            this.pnlSeleccionados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaLimite
            // 
            this.lblFechaLimite.AutoSize = true;
            this.lblFechaLimite.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaLimite.ForeColor = System.Drawing.Color.White;
            this.lblFechaLimite.Location = new System.Drawing.Point(645, 82);
            this.lblFechaLimite.Name = "lblFechaLimite";
            this.lblFechaLimite.Size = new System.Drawing.Size(115, 22);
            this.lblFechaLimite.TabIndex = 0;
            this.lblFechaLimite.Text = "Fecha limite";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BorderRadius = 10;
            this.btnAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAceptar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnAceptar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(900, 115);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(180, 53);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Crear Orden Compra";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.BorderRadius = 10;
            this.dtpFechaLimite.Checked = true;
            this.dtpFechaLimite.FillColor = System.Drawing.Color.White;
            this.dtpFechaLimite.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaLimite.Location = new System.Drawing.Point(577, 115);
            this.dtpFechaLimite.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaLimite.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(268, 36);
            this.dtpFechaLimite.TabIndex = 10;
            this.dtpFechaLimite.Value = new System.DateTime(2025, 3, 15, 0, 20, 34, 412);
            this.dtpFechaLimite.ValueChanged += new System.EventHandler(this.dtpFechaLimite_ValueChanged);
            // 
            // txtProveedor
            // 
            this.txtProveedor.BorderRadius = 15;
            this.txtProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProveedor.DefaultText = "";
            this.txtProveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProveedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProveedor.Location = new System.Drawing.Point(42, 81);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.PlaceholderText = "";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.SelectedText = "";
            this.txtProveedor.Size = new System.Drawing.Size(181, 36);
            this.txtProveedor.TabIndex = 15;
            this.txtProveedor.TextChanged += new System.EventHandler(this.txtProveedor_TextChanged);
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
            // btnProveedor
            // 
            this.btnProveedor.BorderRadius = 10;
            this.btnProveedor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProveedor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProveedor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnProveedor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnProveedor.ForeColor = System.Drawing.Color.White;
            this.btnProveedor.Location = new System.Drawing.Point(42, 134);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(170, 45);
            this.btnProveedor.TabIndex = 16;
            this.btnProveedor.Text = "Escoger Proveedor";
            this.btnProveedor.Click += new System.EventHandler(this.txtProveedor_Click);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lblProveedor.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.White;
            this.lblProveedor.Location = new System.Drawing.Point(72, 36);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(102, 22);
            this.lblProveedor.TabIndex = 17;
            this.lblProveedor.Text = "Proveedor";
            // 
            // pnlSeleccion
            // 
            this.pnlSeleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlSeleccion.Controls.Add(this.pnlProductos);
            this.pnlSeleccion.Controls.Add(this.txtFiltroProduc);
            this.pnlSeleccion.Controls.Add(this.lblProductos);
            this.pnlSeleccion.Controls.Add(this.btnProducto);
            this.pnlSeleccion.Controls.Add(this.pnlSeleccionarProductoServicio);
            this.pnlSeleccion.Controls.Add(this.pnlProductosSelect);
            this.pnlSeleccion.Controls.Add(this.pnlServiciosSelect);
            this.pnlSeleccion.Location = new System.Drawing.Point(2, 0);
            this.pnlSeleccion.Name = "pnlSeleccion";
            this.pnlSeleccion.Size = new System.Drawing.Size(1372, 388);
            this.pnlSeleccion.TabIndex = 24;
            // 
            // pnlProductos
            // 
            this.pnlProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.pnlProductos.Controls.Add(this.dgvListadoProductos);
            this.pnlProductos.Location = new System.Drawing.Point(382, 138);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(447, 198);
            this.pnlProductos.TabIndex = 30;
            // 
            // dgvListadoProductos
            // 
            this.dgvListadoProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProductos.Location = new System.Drawing.Point(23, 19);
            this.dgvListadoProductos.Name = "dgvListadoProductos";
            this.dgvListadoProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListadoProductos.RowHeadersVisible = false;
            this.dgvListadoProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoProductos.Size = new System.Drawing.Size(391, 154);
            this.dgvListadoProductos.TabIndex = 4;
            // 
            // txtFiltroProduc
            // 
            this.txtFiltroProduc.BorderRadius = 5;
            this.txtFiltroProduc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroProduc.DefaultText = "";
            this.txtFiltroProduc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltroProduc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltroProduc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltroProduc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltroProduc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltroProduc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltroProduc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltroProduc.IconRight = global::ModuloDeCompra_BD.Properties.Resources.brows_browsing_find_search_seo_web_zoom_icon_123196;
            this.txtFiltroProduc.Location = new System.Drawing.Point(381, 98);
            this.txtFiltroProduc.Name = "txtFiltroProduc";
            this.txtFiltroProduc.PlaceholderText = "";
            this.txtFiltroProduc.SelectedText = "";
            this.txtFiltroProduc.Size = new System.Drawing.Size(200, 36);
            this.txtFiltroProduc.TabIndex = 29;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(377, 73);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(168, 22);
            this.lblProductos.TabIndex = 28;
            this.lblProductos.Text = "Listado Productos";
            // 
            // btnProducto
            // 
            this.btnProducto.BorderRadius = 10;
            this.btnProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnProducto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Location = new System.Drawing.Point(669, 87);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(134, 45);
            this.btnProducto.TabIndex = 27;
            this.btnProducto.Text = "Seleccionar productos";
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click_1);
            // 
            // pnlSeleccionarProductoServicio
            // 
            this.pnlSeleccionarProductoServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.pnlSeleccionarProductoServicio.Controls.Add(this.txtProveedor);
            this.pnlSeleccionarProductoServicio.Controls.Add(this.lblProveedor);
            this.pnlSeleccionarProductoServicio.Controls.Add(this.btnProveedor);
            this.pnlSeleccionarProductoServicio.Location = new System.Drawing.Point(96, 98);
            this.pnlSeleccionarProductoServicio.Name = "pnlSeleccionarProductoServicio";
            this.pnlSeleccionarProductoServicio.Size = new System.Drawing.Size(256, 238);
            this.pnlSeleccionarProductoServicio.TabIndex = 26;
            // 
            // pnlProductosSelect
            // 
            this.pnlProductosSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.pnlProductosSelect.Controls.Add(this.btnAgregarP);
            this.pnlProductosSelect.Controls.Add(this.txtProducto);
            this.pnlProductosSelect.Controls.Add(this.lbID);
            this.pnlProductosSelect.Controls.Add(this.txtID);
            this.pnlProductosSelect.Controls.Add(this.lbCantidad);
            this.pnlProductosSelect.Controls.Add(this.lbProduc);
            this.pnlProductosSelect.Controls.Add(this.nudCantidad);
            this.pnlProductosSelect.Location = new System.Drawing.Point(930, 121);
            this.pnlProductosSelect.Name = "pnlProductosSelect";
            this.pnlProductosSelect.Size = new System.Drawing.Size(341, 215);
            this.pnlProductosSelect.TabIndex = 31;
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.BorderRadius = 10;
            this.btnAgregarP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnAgregarP.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarP.ForeColor = System.Drawing.Color.White;
            this.btnAgregarP.Location = new System.Drawing.Point(205, 93);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(120, 45);
            this.btnAgregarP.TabIndex = 25;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click_1);
            // 
            // txtProducto
            // 
            this.txtProducto.BorderRadius = 5;
            this.txtProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProducto.DefaultText = "";
            this.txtProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProducto.Location = new System.Drawing.Point(13, 93);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PlaceholderText = "";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.SelectedText = "";
            this.txtProducto.Size = new System.Drawing.Size(162, 33);
            this.txtProducto.TabIndex = 7;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(74, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(30, 22);
            this.lbID.TabIndex = 18;
            this.lbID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BorderRadius = 5;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(66, 22);
            this.txtID.Name = "txtID";
            this.txtID.PlaceholderText = "";
            this.txtID.ReadOnly = true;
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(49, 36);
            this.txtID.TabIndex = 17;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.Color.White;
            this.lbCantidad.Location = new System.Drawing.Point(57, 153);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(87, 22);
            this.lbCantidad.TabIndex = 11;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbProduc
            // 
            this.lbProduc.AutoSize = true;
            this.lbProduc.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduc.ForeColor = System.Drawing.Color.White;
            this.lbProduc.Location = new System.Drawing.Point(50, 70);
            this.lbProduc.Name = "lbProduc";
            this.lbProduc.Size = new System.Drawing.Size(91, 22);
            this.lbProduc.TabIndex = 9;
            this.lbProduc.Text = "Producto";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(35, 175);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 10;
            // 
            // pnlServiciosSelect
            // 
            this.pnlServiciosSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.pnlServiciosSelect.Controls.Add(this.txtServicio);
            this.pnlServiciosSelect.Controls.Add(this.lbIDserv);
            this.pnlServiciosSelect.Controls.Add(this.btnAgregarS);
            this.pnlServiciosSelect.Controls.Add(this.txtIDServi);
            this.pnlServiciosSelect.Controls.Add(this.lbServi);
            this.pnlServiciosSelect.Controls.Add(this.lbCanServ);
            this.pnlServiciosSelect.Controls.Add(this.nudServicio);
            this.pnlServiciosSelect.Location = new System.Drawing.Point(930, 121);
            this.pnlServiciosSelect.Name = "pnlServiciosSelect";
            this.pnlServiciosSelect.Size = new System.Drawing.Size(341, 215);
            this.pnlServiciosSelect.TabIndex = 30;
            // 
            // txtServicio
            // 
            this.txtServicio.BorderRadius = 5;
            this.txtServicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServicio.DefaultText = "";
            this.txtServicio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServicio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServicio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtServicio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServicio.Location = new System.Drawing.Point(31, 91);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.PlaceholderText = "";
            this.txtServicio.ReadOnly = true;
            this.txtServicio.SelectedText = "";
            this.txtServicio.Size = new System.Drawing.Size(162, 33);
            this.txtServicio.TabIndex = 19;
            // 
            // lbIDserv
            // 
            this.lbIDserv.AutoSize = true;
            this.lbIDserv.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDserv.ForeColor = System.Drawing.Color.White;
            this.lbIDserv.Location = new System.Drawing.Point(96, 0);
            this.lbIDserv.Name = "lbIDserv";
            this.lbIDserv.Size = new System.Drawing.Size(30, 22);
            this.lbIDserv.TabIndex = 24;
            this.lbIDserv.Text = "ID";
            // 
            // btnAgregarS
            // 
            this.btnAgregarS.BorderRadius = 10;
            this.btnAgregarS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnAgregarS.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarS.ForeColor = System.Drawing.Color.White;
            this.btnAgregarS.Location = new System.Drawing.Point(205, 93);
            this.btnAgregarS.Name = "btnAgregarS";
            this.btnAgregarS.Size = new System.Drawing.Size(120, 45);
            this.btnAgregarS.TabIndex = 16;
            this.btnAgregarS.Text = "Agregar";
            this.btnAgregarS.Click += new System.EventHandler(this.btnAgregarS_Click_1);
            // 
            // txtIDServi
            // 
            this.txtIDServi.BorderRadius = 5;
            this.txtIDServi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDServi.DefaultText = "";
            this.txtIDServi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDServi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDServi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDServi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDServi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDServi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDServi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDServi.Location = new System.Drawing.Point(79, 25);
            this.txtIDServi.Name = "txtIDServi";
            this.txtIDServi.PlaceholderText = "";
            this.txtIDServi.ReadOnly = true;
            this.txtIDServi.SelectedText = "";
            this.txtIDServi.Size = new System.Drawing.Size(49, 36);
            this.txtIDServi.TabIndex = 23;
            // 
            // lbServi
            // 
            this.lbServi.AutoSize = true;
            this.lbServi.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServi.ForeColor = System.Drawing.Color.White;
            this.lbServi.Location = new System.Drawing.Point(75, 69);
            this.lbServi.Name = "lbServi";
            this.lbServi.Size = new System.Drawing.Size(81, 22);
            this.lbServi.TabIndex = 20;
            this.lbServi.Text = "Servicio";
            // 
            // lbCanServ
            // 
            this.lbCanServ.AutoSize = true;
            this.lbCanServ.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCanServ.ForeColor = System.Drawing.Color.White;
            this.lbCanServ.Location = new System.Drawing.Point(57, 153);
            this.lbCanServ.Name = "lbCanServ";
            this.lbCanServ.Size = new System.Drawing.Size(87, 22);
            this.lbCanServ.TabIndex = 22;
            this.lbCanServ.Text = "Cantidad";
            // 
            // nudServicio
            // 
            this.nudServicio.Location = new System.Drawing.Point(35, 175);
            this.nudServicio.Name = "nudServicio";
            this.nudServicio.Size = new System.Drawing.Size(120, 20);
            this.nudServicio.TabIndex = 21;
            // 
            // lblProductosSeleccionados
            // 
            this.lblProductosSeleccionados.AutoSize = true;
            this.lblProductosSeleccionados.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosSeleccionados.ForeColor = System.Drawing.Color.White;
            this.lblProductosSeleccionados.Location = new System.Drawing.Point(31, 29);
            this.lblProductosSeleccionados.Name = "lblProductosSeleccionados";
            this.lblProductosSeleccionados.Size = new System.Drawing.Size(227, 22);
            this.lblProductosSeleccionados.TabIndex = 7;
            this.lblProductosSeleccionados.Text = "Productos Seleccionados";
            // 
            // dgvProductosAgregados
            // 
            this.dgvProductosAgregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosAgregados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductosAgregados.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductosAgregados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductosAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosAgregados.Location = new System.Drawing.Point(28, 52);
            this.dgvProductosAgregados.Name = "dgvProductosAgregados";
            this.dgvProductosAgregados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductosAgregados.RowHeadersVisible = false;
            this.dgvProductosAgregados.Size = new System.Drawing.Size(534, 140);
            this.dgvProductosAgregados.TabIndex = 7;
            // 
            // pnlSeleccionados
            // 
            this.pnlSeleccionados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.pnlSeleccionados.Controls.Add(this.btnGenerarDocumento);
            this.pnlSeleccionados.Controls.Add(this.dgvProductosAgregados);
            this.pnlSeleccionados.Controls.Add(this.dtpFechaLimite);
            this.pnlSeleccionados.Controls.Add(this.lblFechaLimite);
            this.pnlSeleccionados.Controls.Add(this.lblProductosSeleccionados);
            this.pnlSeleccionados.Controls.Add(this.btnAceptar);
            this.pnlSeleccionados.Location = new System.Drawing.Point(98, 412);
            this.pnlSeleccionados.Name = "pnlSeleccionados";
            this.pnlSeleccionados.Size = new System.Drawing.Size(1175, 224);
            this.pnlSeleccionados.TabIndex = 25;
            // 
            // btnGenerarDocumento
            // 
            this.btnGenerarDocumento.Animated = true;
            this.btnGenerarDocumento.BorderRadius = 10;
            this.btnGenerarDocumento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarDocumento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarDocumento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerarDocumento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerarDocumento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnGenerarDocumento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerarDocumento.ForeColor = System.Drawing.Color.White;
            this.btnGenerarDocumento.IndicateFocus = true;
            this.btnGenerarDocumento.Location = new System.Drawing.Point(901, 42);
            this.btnGenerarDocumento.Name = "btnGenerarDocumento";
            this.btnGenerarDocumento.Size = new System.Drawing.Size(180, 50);
            this.btnGenerarDocumento.TabIndex = 27;
            this.btnGenerarDocumento.Text = "Generar documento";
            this.btnGenerarDocumento.Visible = false;
            this.btnGenerarDocumento.Click += new System.EventHandler(this.btnGenerarDocumento_Click);
            // 
            // FrmOrdenCompraDirecta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1386, 663);
            this.Controls.Add(this.pnlSeleccionados);
            this.Controls.Add(this.pnlSeleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrdenCompraDirecta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrdenCompraDirectas";
            this.Load += new System.EventHandler(this.FrmOrdenCompraDirecta_Load);
            this.pnlSeleccion.ResumeLayout(false);
            this.pnlSeleccion.PerformLayout();
            this.pnlProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).EndInit();
            this.pnlSeleccionarProductoServicio.ResumeLayout(false);
            this.pnlSeleccionarProductoServicio.PerformLayout();
            this.pnlProductosSelect.ResumeLayout(false);
            this.pnlProductosSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.pnlServiciosSelect.ResumeLayout(false);
            this.pnlServiciosSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAgregados)).EndInit();
            this.pnlSeleccionados.ResumeLayout(false);
            this.pnlSeleccionados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFechaLimite;
        private Guna.UI2.WinForms.Guna2Button btnAceptar;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaLimite;
        private Guna.UI2.WinForms.Guna2TextBox txtProveedor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEstadoOrden;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRequisicionID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOrdenID;
        private Guna.UI2.WinForms.Guna2Button btnProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private Guna.UI2.WinForms.Guna2Panel pnlSeleccion;
        private System.Windows.Forms.Label lblProductosSeleccionados;
        private System.Windows.Forms.DataGridView dgvProductosAgregados;
        private System.Windows.Forms.Panel pnlSeleccionados;
        private System.Windows.Forms.Panel pnlSeleccionarProductoServicio;
        private Guna.UI2.WinForms.Guna2Button btnGenerarDocumento;
        private System.Windows.Forms.Panel pnlProductosSelect;
        private Guna.UI2.WinForms.Guna2Button btnAgregarP;
        private Guna.UI2.WinForms.Guna2TextBox txtProducto;
        private System.Windows.Forms.Label lbID;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbProduc;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.Panel pnlServiciosSelect;
        private Guna.UI2.WinForms.Guna2TextBox txtServicio;
        private System.Windows.Forms.Label lbIDserv;
        private Guna.UI2.WinForms.Guna2Button btnAgregarS;
        private Guna.UI2.WinForms.Guna2TextBox txtIDServi;
        private System.Windows.Forms.Label lbServi;
        private System.Windows.Forms.Label lbCanServ;
        private System.Windows.Forms.NumericUpDown nudServicio;
        private System.Windows.Forms.DataGridView dgvListadoProductos;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltroProduc;
        private System.Windows.Forms.Label lblProductos;
        private Guna.UI2.WinForms.Guna2Button btnProducto;
    }
}