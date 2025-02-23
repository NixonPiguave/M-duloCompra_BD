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
            this.cmbIVA = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPrecioUnitario = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbTipoP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtListadoProvee = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtListadoCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnListadoCategoria = new Guna.UI2.WinForms.Guna2Button();
            this.cmbEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNombreProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(251, 465);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 53);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BorderRadius = 20;
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(20, 465);
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
            this.btnListadoProveedor.Location = new System.Drawing.Point(166, 387);
            this.btnListadoProveedor.Name = "btnListadoProveedor";
            this.btnListadoProveedor.Size = new System.Drawing.Size(88, 36);
            this.btnListadoProveedor.TabIndex = 15;
            this.btnListadoProveedor.Text = "Listado";
            this.btnListadoProveedor.Click += new System.EventHandler(this.btnListadoProveedor_Click);
            // 
            // cmbIVA
            // 
            this.cmbIVA.BackColor = System.Drawing.Color.Transparent;
            this.cmbIVA.BorderRadius = 10;
            this.cmbIVA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIVA.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIVA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbIVA.ItemHeight = 30;
            this.cmbIVA.Location = new System.Drawing.Point(177, 223);
            this.cmbIVA.Name = "cmbIVA";
            this.cmbIVA.Size = new System.Drawing.Size(209, 36);
            this.cmbIVA.TabIndex = 12;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.BorderRadius = 10;
            this.txtPrecioUnitario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioUnitario.DefaultText = "";
            this.txtPrecioUnitario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecioUnitario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecioUnitario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioUnitario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioUnitario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecioUnitario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(176, 162);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.PlaceholderText = "";
            this.txtPrecioUnitario.SelectedText = "";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(210, 34);
            this.txtPrecioUnitario.TabIndex = 7;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(122, 223);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(41, 21);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "IVA:";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(170)))), ((int)(((byte)(239)))));
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel9);
            this.guna2Panel2.Controls.Add(this.cbTipoP);
            this.guna2Panel2.Controls.Add(this.txtListadoProvee);
            this.guna2Panel2.Controls.Add(this.txtListadoCategory);
            this.guna2Panel2.Controls.Add(this.btnCancelar);
            this.guna2Panel2.Controls.Add(this.btnGuardar);
            this.guna2Panel2.Controls.Add(this.btnListadoProveedor);
            this.guna2Panel2.Controls.Add(this.btnListadoCategoria);
            this.guna2Panel2.Controls.Add(this.cmbEstado);
            this.guna2Panel2.Controls.Add(this.cmbIVA);
            this.guna2Panel2.Controls.Add(this.txtPrecioUnitario);
            this.guna2Panel2.Controls.Add(this.txtNombreProducto);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(434, 708);
            this.guna2Panel2.TabIndex = 5;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(107, 61);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(46, 21);
            this.guna2HtmlLabel9.TabIndex = 19;
            this.guna2HtmlLabel9.Text = "Tipo:";
            // 
            // cbTipoP
            // 
            this.cbTipoP.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoP.BorderRadius = 10;
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
            this.cbTipoP.Location = new System.Drawing.Point(175, 49);
            this.cbTipoP.Name = "cbTipoP";
            this.cbTipoP.Size = new System.Drawing.Size(209, 36);
            this.cbTipoP.TabIndex = 18;
            this.cbTipoP.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // txtListadoProvee
            // 
            this.txtListadoProvee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtListadoProvee.DefaultText = "";
            this.txtListadoProvee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtListadoProvee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtListadoProvee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtListadoProvee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtListadoProvee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtListadoProvee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtListadoProvee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtListadoProvee.Location = new System.Drawing.Point(279, 397);
            this.txtListadoProvee.Name = "txtListadoProvee";
            this.txtListadoProvee.PlaceholderText = "";
            this.txtListadoProvee.ReadOnly = true;
            this.txtListadoProvee.SelectedText = "";
            this.txtListadoProvee.Size = new System.Drawing.Size(97, 26);
            this.txtListadoProvee.TabIndex = 17;
            // 
            // txtListadoCategory
            // 
            this.txtListadoCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtListadoCategory.DefaultText = "";
            this.txtListadoCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtListadoCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtListadoCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtListadoCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtListadoCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtListadoCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtListadoCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtListadoCategory.Location = new System.Drawing.Point(278, 350);
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
            this.btnListadoCategoria.Location = new System.Drawing.Point(166, 341);
            this.btnListadoCategoria.Name = "btnListadoCategoria";
            this.btnListadoCategoria.Size = new System.Drawing.Size(88, 36);
            this.btnListadoCategoria.TabIndex = 14;
            this.btnListadoCategoria.Text = "Listado";
            this.btnListadoCategoria.Click += new System.EventHandler(this.btnListadoCategoria_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstado.BorderRadius = 10;
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEstado.ItemHeight = 30;
            this.cmbEstado.Location = new System.Drawing.Point(175, 288);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(209, 36);
            this.cmbEstado.TabIndex = 13;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderRadius = 10;
            this.txtNombreProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProducto.DefaultText = "";
            this.txtNombreProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProducto.Location = new System.Drawing.Point(175, 105);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PlaceholderText = "";
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.Size = new System.Drawing.Size(210, 35);
            this.txtNombreProducto.TabIndex = 6;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(60, 387);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(93, 21);
            this.guna2HtmlLabel7.TabIndex = 5;
            this.guna2HtmlLabel7.Text = "Proveedor:";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(66, 350);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(87, 21);
            this.guna2HtmlLabel6.TabIndex = 4;
            this.guna2HtmlLabel6.Text = "Categoría:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(107, 288);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(63, 21);
            this.guna2HtmlLabel5.TabIndex = 3;
            this.guna2HtmlLabel5.Text = "Estado:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(35, 162);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(135, 21);
            this.guna2HtmlLabel3.TabIndex = 1;
            this.guna2HtmlLabel3.Text = "Precio Unitario:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 105);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(153, 21);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Nombre Producto:";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(717, 21);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(113, 26);
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
            this.dgvProducto.Location = new System.Drawing.Point(507, 89);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.RowTemplate.Height = 18;
            this.dgvProducto.Size = new System.Drawing.Size(578, 549);
            this.dgvProducto.TabIndex = 19;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 708);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnListadoProveedor;
        private Guna.UI2.WinForms.Guna2ComboBox cmbIVA;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioUnitario;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnListadoCategoria;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEstado;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreProducto;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtListadoProvee;
        private Guna.UI2.WinForms.Guna2TextBox txtListadoCategory;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipoP;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private System.Windows.Forms.DataGridView dgvProducto;
    }
}