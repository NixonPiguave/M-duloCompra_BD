namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmProductos
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
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnListadoProveedor = new Guna.UI2.WinForms.Guna2Button();
            this.txtPrecioUnitario = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtListadoUbiBodega = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnListadoUbiBodega = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnEditarGeneral = new Guna.UI2.WinForms.Guna2Button();
            this.cmbEstadoProducto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbTipoP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtListadoProvee = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtListadoCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnListadoCategoria = new Guna.UI2.WinForms.Guna2Button();
            this.cmbIVA = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNombreProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarServicio = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Animated = true;
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IndicateFocus = true;
            this.btnCancelar.Location = new System.Drawing.Point(291, 571);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 53);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Animated = true;
            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IndicateFocus = true;
            this.btnGuardar.Location = new System.Drawing.Point(15, 571);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(133, 53);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnListadoProveedor
            // 
            this.btnListadoProveedor.BorderRadius = 10;
            this.btnListadoProveedor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListadoProveedor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListadoProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListadoProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListadoProveedor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(92)))), ((int)(((byte)(197)))));
            this.btnListadoProveedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnListadoProveedor.ForeColor = System.Drawing.Color.White;
            this.btnListadoProveedor.Location = new System.Drawing.Point(175, 465);
            this.btnListadoProveedor.Name = "btnListadoProveedor";
            this.btnListadoProveedor.Size = new System.Drawing.Size(88, 36);
            this.btnListadoProveedor.TabIndex = 15;
            this.btnListadoProveedor.Text = "Listado";
            this.btnListadoProveedor.Click += new System.EventHandler(this.btnListadoProveedor_Click);
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.BorderRadius = 5;
            this.txtPrecioUnitario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioUnitario.DefaultText = "";
            this.txtPrecioUnitario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecioUnitario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecioUnitario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioUnitario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioUnitario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecioUnitario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(205, 155);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.PlaceholderText = "";
            this.txtPrecioUnitario.SelectedText = "";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(210, 34);
            this.txtPrecioUnitario.TabIndex = 7;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(152, 216);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(34, 22);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "IVA:";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.guna2Panel2.Controls.Add(this.txtListadoUbiBodega);
            this.guna2Panel2.Controls.Add(this.btnListadoUbiBodega);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel2.Controls.Add(this.btnEditarGeneral);
            this.guna2Panel2.Controls.Add(this.cmbEstadoProducto);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel9);
            this.guna2Panel2.Controls.Add(this.cbTipoP);
            this.guna2Panel2.Controls.Add(this.txtListadoProvee);
            this.guna2Panel2.Controls.Add(this.txtListadoCategory);
            this.guna2Panel2.Controls.Add(this.btnCancelar);
            this.guna2Panel2.Controls.Add(this.btnGuardar);
            this.guna2Panel2.Controls.Add(this.btnListadoProveedor);
            this.guna2Panel2.Controls.Add(this.btnListadoCategoria);
            this.guna2Panel2.Controls.Add(this.cmbIVA);
            this.guna2Panel2.Controls.Add(this.txtPrecioUnitario);
            this.guna2Panel2.Controls.Add(this.txtNombreProducto);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(434, 708);
            this.guna2Panel2.TabIndex = 5;
            // 
            // txtListadoUbiBodega
            // 
            this.txtListadoUbiBodega.BorderRadius = 5;
            this.txtListadoUbiBodega.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtListadoUbiBodega.DefaultText = "";
            this.txtListadoUbiBodega.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtListadoUbiBodega.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtListadoUbiBodega.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtListadoUbiBodega.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtListadoUbiBodega.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtListadoUbiBodega.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtListadoUbiBodega.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtListadoUbiBodega.Location = new System.Drawing.Point(288, 417);
            this.txtListadoUbiBodega.Name = "txtListadoUbiBodega";
            this.txtListadoUbiBodega.PlaceholderText = "";
            this.txtListadoUbiBodega.ReadOnly = true;
            this.txtListadoUbiBodega.SelectedText = "";
            this.txtListadoUbiBodega.Size = new System.Drawing.Size(97, 26);
            this.txtListadoUbiBodega.TabIndex = 26;
            // 
            // btnListadoUbiBodega
            // 
            this.btnListadoUbiBodega.BorderRadius = 10;
            this.btnListadoUbiBodega.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListadoUbiBodega.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListadoUbiBodega.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListadoUbiBodega.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListadoUbiBodega.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(92)))), ((int)(((byte)(197)))));
            this.btnListadoUbiBodega.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnListadoUbiBodega.ForeColor = System.Drawing.Color.White;
            this.btnListadoUbiBodega.Location = new System.Drawing.Point(175, 407);
            this.btnListadoUbiBodega.Name = "btnListadoUbiBodega";
            this.btnListadoUbiBodega.Size = new System.Drawing.Size(88, 36);
            this.btnListadoUbiBodega.TabIndex = 25;
            this.btnListadoUbiBodega.Text = "Listado";
            this.btnListadoUbiBodega.Click += new System.EventHandler(this.btnListadoUbiBodega_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(16, 421);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(135, 22);
            this.guna2HtmlLabel5.TabIndex = 24;
            this.guna2HtmlLabel5.Text = "Ubicación bodega:";
            // 
            // btnEditarGeneral
            // 
            this.btnEditarGeneral.Animated = true;
            this.btnEditarGeneral.BorderRadius = 10;
            this.btnEditarGeneral.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarGeneral.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarGeneral.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarGeneral.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarGeneral.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnEditarGeneral.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditarGeneral.ForeColor = System.Drawing.Color.White;
            this.btnEditarGeneral.IndicateFocus = true;
            this.btnEditarGeneral.Location = new System.Drawing.Point(152, 571);
            this.btnEditarGeneral.Name = "btnEditarGeneral";
            this.btnEditarGeneral.Size = new System.Drawing.Size(133, 53);
            this.btnEditarGeneral.TabIndex = 23;
            this.btnEditarGeneral.Text = "Editar";
            this.btnEditarGeneral.Click += new System.EventHandler(this.btnEditarGeneral_Click);
            // 
            // cmbEstadoProducto
            // 
            this.cmbEstadoProducto.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstadoProducto.BorderRadius = 5;
            this.cmbEstadoProducto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstadoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoProducto.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEstadoProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEstadoProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstadoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEstadoProducto.ItemHeight = 30;
            this.cmbEstadoProducto.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoProducto.Location = new System.Drawing.Point(204, 277);
            this.cmbEstadoProducto.Name = "cmbEstadoProducto";
            this.cmbEstadoProducto.Size = new System.Drawing.Size(209, 36);
            this.cmbEstadoProducto.TabIndex = 22;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 291);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(189, 22);
            this.guna2HtmlLabel2.TabIndex = 21;
            this.guna2HtmlLabel2.Text = "Estado Producto / Servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(50, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Producto/Servicio:\r\n";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(141, 56);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(37, 22);
            this.guna2HtmlLabel9.TabIndex = 19;
            this.guna2HtmlLabel9.Text = "Tipo:";
            // 
            // cbTipoP
            // 
            this.cbTipoP.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoP.BorderRadius = 5;
            this.cbTipoP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTipoP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTipoP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTipoP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTipoP.ItemHeight = 30;
            this.cbTipoP.Items.AddRange(new object[] {
            "Producto",
            "Servicio"});
            this.cbTipoP.Location = new System.Drawing.Point(204, 42);
            this.cbTipoP.Name = "cbTipoP";
            this.cbTipoP.Size = new System.Drawing.Size(209, 36);
            this.cbTipoP.TabIndex = 18;
            this.cbTipoP.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // txtListadoProvee
            // 
            this.txtListadoProvee.BorderRadius = 5;
            this.txtListadoProvee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtListadoProvee.DefaultText = "";
            this.txtListadoProvee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtListadoProvee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtListadoProvee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtListadoProvee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtListadoProvee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtListadoProvee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtListadoProvee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtListadoProvee.Location = new System.Drawing.Point(288, 475);
            this.txtListadoProvee.Name = "txtListadoProvee";
            this.txtListadoProvee.PlaceholderText = "";
            this.txtListadoProvee.ReadOnly = true;
            this.txtListadoProvee.SelectedText = "";
            this.txtListadoProvee.Size = new System.Drawing.Size(97, 26);
            this.txtListadoProvee.TabIndex = 17;
            // 
            // txtListadoCategory
            // 
            this.txtListadoCategory.BorderRadius = 5;
            this.txtListadoCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtListadoCategory.DefaultText = "";
            this.txtListadoCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtListadoCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtListadoCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtListadoCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtListadoCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtListadoCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtListadoCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtListadoCategory.Location = new System.Drawing.Point(287, 369);
            this.txtListadoCategory.Name = "txtListadoCategory";
            this.txtListadoCategory.PlaceholderText = "";
            this.txtListadoCategory.ReadOnly = true;
            this.txtListadoCategory.SelectedText = "";
            this.txtListadoCategory.Size = new System.Drawing.Size(97, 26);
            this.txtListadoCategory.TabIndex = 16;
            // 
            // btnListadoCategoria
            // 
            this.btnListadoCategoria.BorderRadius = 10;
            this.btnListadoCategoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListadoCategoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListadoCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListadoCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListadoCategoria.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(92)))), ((int)(((byte)(197)))));
            this.btnListadoCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnListadoCategoria.ForeColor = System.Drawing.Color.White;
            this.btnListadoCategoria.Location = new System.Drawing.Point(175, 360);
            this.btnListadoCategoria.Name = "btnListadoCategoria";
            this.btnListadoCategoria.Size = new System.Drawing.Size(88, 36);
            this.btnListadoCategoria.TabIndex = 14;
            this.btnListadoCategoria.Text = "Listado";
            this.btnListadoCategoria.Click += new System.EventHandler(this.btnListadoCategoria_Click);
            // 
            // cmbIVA
            // 
            this.cmbIVA.BackColor = System.Drawing.Color.Transparent;
            this.cmbIVA.BorderRadius = 5;
            this.cmbIVA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIVA.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIVA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbIVA.ItemHeight = 30;
            this.cmbIVA.Items.AddRange(new object[] {
            "Exento"});
            this.cmbIVA.Location = new System.Drawing.Point(206, 216);
            this.cmbIVA.Name = "cmbIVA";
            this.cmbIVA.Size = new System.Drawing.Size(209, 36);
            this.cmbIVA.TabIndex = 12;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderRadius = 5;
            this.txtNombreProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProducto.DefaultText = "";
            this.txtNombreProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProducto.Location = new System.Drawing.Point(206, 98);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PlaceholderText = "";
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.Size = new System.Drawing.Size(210, 35);
            this.txtNombreProducto.TabIndex = 6;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(69, 465);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(79, 22);
            this.guna2HtmlLabel7.TabIndex = 5;
            this.guna2HtmlLabel7.Text = "Proveedor:";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(75, 369);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(76, 22);
            this.guna2HtmlLabel6.TabIndex = 4;
            this.guna2HtmlLabel6.Text = "Categoría:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(137, 155);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(49, 22);
            this.guna2HtmlLabel3.TabIndex = 1;
            this.guna2HtmlLabel3.Text = "Costo:";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(739, 22);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(100, 27);
            this.guna2HtmlLabel8.TabIndex = 18;
            this.guna2HtmlLabel8.Text = "Productos";
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToOrderColumns = true;
            this.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducto.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(507, 55);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.RowHeadersVisible = false;
            this.dgvProducto.RowTemplate.Height = 18;
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(594, 220);
            this.dgvProducto.TabIndex = 19;
            this.dgvProducto.DoubleClick += new System.EventHandler(this.dgvProducto_DoubleClick);
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToOrderColumns = true;
            this.dgvService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvService.BackgroundColor = System.Drawing.Color.White;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(507, 382);
            this.dgvService.Name = "dgvService";
            this.dgvService.RowHeadersVisible = false;
            this.dgvService.RowTemplate.Height = 18;
            this.dgvService.Size = new System.Drawing.Size(594, 233);
            this.dgvService.TabIndex = 21;
            this.dgvService.DoubleClick += new System.EventHandler(this.dgvService_DoubleClick);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(739, 349);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(91, 27);
            this.guna2HtmlLabel1.TabIndex = 20;
            this.guna2HtmlLabel1.Text = "Servicios";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(92)))), ((int)(((byte)(197)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(507, 288);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 36);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.BorderRadius = 10;
            this.btnEliminarServicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarServicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarServicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarServicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarServicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(92)))), ((int)(((byte)(197)))));
            this.btnEliminarServicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminarServicio.ForeColor = System.Drawing.Color.White;
            this.btnEliminarServicio.Location = new System.Drawing.Point(507, 630);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(88, 36);
            this.btnEliminarServicio.TabIndex = 24;
            this.btnEliminarServicio.Text = "Eliminar";
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 708);
            this.Controls.Add(this.btnEliminarServicio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnListadoProveedor;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioUnitario;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnListadoCategoria;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreProducto;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtListadoProvee;
        private Guna.UI2.WinForms.Guna2TextBox txtListadoCategory;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipoP;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.DataGridView dgvService;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnEliminarServicio;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEstadoProducto;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbIVA;
        private Guna.UI2.WinForms.Guna2Button btnEditarGeneral;
        private Guna.UI2.WinForms.Guna2TextBox txtListadoUbiBodega;
        private Guna.UI2.WinForms.Guna2Button btnListadoUbiBodega;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}