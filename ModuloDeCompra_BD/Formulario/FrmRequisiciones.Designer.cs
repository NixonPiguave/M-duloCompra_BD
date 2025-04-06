namespace Menú.Formularios
{
    partial class FrmRequisiciones
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
            this.btnProducto = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvListadoProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregarP = new Guna.UI2.WinForms.Guna2Button();
            this.lbListado = new System.Windows.Forms.Label();
            this.txtFiltroProduc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbProduc = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvListadoServicio = new System.Windows.Forms.DataGridView();
            this.lbIDserv = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDServi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFiltroServicio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbCanServ = new System.Windows.Forms.Label();
            this.btnServicio = new Guna.UI2.WinForms.Guna2Button();
            this.nudServicio = new System.Windows.Forms.NumericUpDown();
            this.txtServicio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbServi = new System.Windows.Forms.Label();
            this.btnAgregarS = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMotivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCrearRequi = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductosAgregados = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAgregados)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
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
            this.btnProducto.Location = new System.Drawing.Point(389, 26);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(134, 45);
            this.btnProducto.TabIndex = 0;
            this.btnProducto.Text = "Seleccionar productos";
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.guna2Panel1.Controls.Add(this.panel5);
            this.guna2Panel1.Controls.Add(this.tabControl1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1211, 652);
            this.guna2Panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-7, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1283, 355);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.lbListado);
            this.tabPage1.Controls.Add(this.txtFiltroProduc);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1275, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            // 
            // dgvListadoProductos
            // 
            this.dgvListadoProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProductos.Location = new System.Drawing.Point(29, 20);
            this.dgvListadoProductos.Name = "dgvListadoProductos";
            this.dgvListadoProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListadoProductos.RowHeadersVisible = false;
            this.dgvListadoProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoProductos.Size = new System.Drawing.Size(333, 184);
            this.dgvListadoProductos.TabIndex = 4;
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
            this.btnAgregarP.Location = new System.Drawing.Point(46, 159);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(120, 45);
            this.btnAgregarP.TabIndex = 25;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // lbListado
            // 
            this.lbListado.AutoSize = true;
            this.lbListado.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListado.Location = new System.Drawing.Point(133, 20);
            this.lbListado.Name = "lbListado";
            this.lbListado.Size = new System.Drawing.Size(168, 22);
            this.lbListado.TabIndex = 5;
            this.lbListado.Text = "Listado Productos";
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
            this.txtFiltroProduc.Location = new System.Drawing.Point(137, 55);
            this.txtFiltroProduc.Name = "txtFiltroProduc";
            this.txtFiltroProduc.PlaceholderText = "";
            this.txtFiltroProduc.SelectedText = "";
            this.txtFiltroProduc.Size = new System.Drawing.Size(200, 36);
            this.txtFiltroProduc.TabIndex = 6;
            this.txtFiltroProduc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltroProduc_KeyUp);
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
            this.txtProducto.Location = new System.Drawing.Point(31, 48);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PlaceholderText = "";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.SelectedText = "";
            this.txtProducto.Size = new System.Drawing.Size(162, 36);
            this.txtProducto.TabIndex = 7;
            // 
            // lbProduc
            // 
            this.lbProduc.AutoSize = true;
            this.lbProduc.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduc.ForeColor = System.Drawing.Color.White;
            this.lbProduc.Location = new System.Drawing.Point(59, 26);
            this.lbProduc.Name = "lbProduc";
            this.lbProduc.Size = new System.Drawing.Size(91, 22);
            this.lbProduc.TabIndex = 9;
            this.lbProduc.Text = "Producto";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(46, 123);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 10;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.Color.White;
            this.lbCantidad.Location = new System.Drawing.Point(68, 101);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(87, 22);
            this.lbCantidad.TabIndex = 11;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(437, 101);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(30, 22);
            this.lbID.TabIndex = 18;
            this.lbID.Text = "ID";
            this.lbID.Click += new System.EventHandler(this.label6_Click);
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
            this.txtID.Location = new System.Drawing.Point(429, 123);
            this.txtID.Name = "txtID";
            this.txtID.PlaceholderText = "";
            this.txtID.ReadOnly = true;
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(49, 36);
            this.txtID.TabIndex = 17;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtFiltroServicio);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1275, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Servicio";
            // 
            // dgvListadoServicio
            // 
            this.dgvListadoServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoServicio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoServicio.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoServicio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListadoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoServicio.Location = new System.Drawing.Point(23, 18);
            this.dgvListadoServicio.Name = "dgvListadoServicio";
            this.dgvListadoServicio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListadoServicio.RowHeadersVisible = false;
            this.dgvListadoServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoServicio.Size = new System.Drawing.Size(334, 184);
            this.dgvListadoServicio.TabIndex = 13;
            // 
            // lbIDserv
            // 
            this.lbIDserv.AutoSize = true;
            this.lbIDserv.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDserv.ForeColor = System.Drawing.Color.White;
            this.lbIDserv.Location = new System.Drawing.Point(433, 98);
            this.lbIDserv.Name = "lbIDserv";
            this.lbIDserv.Size = new System.Drawing.Size(30, 22);
            this.lbIDserv.TabIndex = 24;
            this.lbIDserv.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(142, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Listado Servicio";
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
            this.txtIDServi.Location = new System.Drawing.Point(425, 120);
            this.txtIDServi.Name = "txtIDServi";
            this.txtIDServi.PlaceholderText = "";
            this.txtIDServi.ReadOnly = true;
            this.txtIDServi.SelectedText = "";
            this.txtIDServi.Size = new System.Drawing.Size(49, 36);
            this.txtIDServi.TabIndex = 23;
            // 
            // txtFiltroServicio
            // 
            this.txtFiltroServicio.BorderRadius = 5;
            this.txtFiltroServicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroServicio.DefaultText = "";
            this.txtFiltroServicio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltroServicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltroServicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltroServicio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltroServicio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltroServicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltroServicio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltroServicio.IconRight = global::ModuloDeCompra_BD.Properties.Resources.brows_browsing_find_search_seo_web_zoom_icon_123196;
            this.txtFiltroServicio.Location = new System.Drawing.Point(137, 56);
            this.txtFiltroServicio.Name = "txtFiltroServicio";
            this.txtFiltroServicio.PlaceholderText = "";
            this.txtFiltroServicio.SelectedText = "";
            this.txtFiltroServicio.Size = new System.Drawing.Size(200, 36);
            this.txtFiltroServicio.TabIndex = 15;
            this.txtFiltroServicio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltroServicio_KeyUp);
            // 
            // lbCanServ
            // 
            this.lbCanServ.AutoSize = true;
            this.lbCanServ.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCanServ.ForeColor = System.Drawing.Color.White;
            this.lbCanServ.Location = new System.Drawing.Point(58, 95);
            this.lbCanServ.Name = "lbCanServ";
            this.lbCanServ.Size = new System.Drawing.Size(87, 22);
            this.lbCanServ.TabIndex = 22;
            this.lbCanServ.Text = "Cantidad";
            // 
            // btnServicio
            // 
            this.btnServicio.BorderRadius = 10;
            this.btnServicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnServicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnServicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnServicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnServicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnServicio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicio.ForeColor = System.Drawing.Color.White;
            this.btnServicio.Location = new System.Drawing.Point(383, 34);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Size = new System.Drawing.Size(134, 45);
            this.btnServicio.TabIndex = 12;
            this.btnServicio.Text = "Seleccionar Servicios";
            this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click);
            // 
            // nudServicio
            // 
            this.nudServicio.Location = new System.Drawing.Point(48, 120);
            this.nudServicio.Name = "nudServicio";
            this.nudServicio.Size = new System.Drawing.Size(120, 20);
            this.nudServicio.TabIndex = 21;
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
            this.txtServicio.Location = new System.Drawing.Point(25, 43);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.PlaceholderText = "";
            this.txtServicio.ReadOnly = true;
            this.txtServicio.SelectedText = "";
            this.txtServicio.Size = new System.Drawing.Size(162, 36);
            this.txtServicio.TabIndex = 19;
            // 
            // lbServi
            // 
            this.lbServi.AutoSize = true;
            this.lbServi.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServi.ForeColor = System.Drawing.Color.White;
            this.lbServi.Location = new System.Drawing.Point(65, 20);
            this.lbServi.Name = "lbServi";
            this.lbServi.Size = new System.Drawing.Size(81, 22);
            this.lbServi.TabIndex = 20;
            this.lbServi.Text = "Servicio";
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
            this.btnAgregarS.Location = new System.Drawing.Point(48, 157);
            this.btnAgregarS.Name = "btnAgregarS";
            this.btnAgregarS.Size = new System.Drawing.Size(120, 45);
            this.btnAgregarS.TabIndex = 16;
            this.btnAgregarS.Text = "Agregar";
            this.btnAgregarS.Click += new System.EventHandler(this.btnAgregarS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(817, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Motivo de la Requisición";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotivo.DefaultText = "";
            this.txtMotivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMotivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMotivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMotivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotivo.Location = new System.Drawing.Point(634, 21);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PlaceholderText = "";
            this.txtMotivo.SelectedText = "";
            this.txtMotivo.Size = new System.Drawing.Size(396, 91);
            this.txtMotivo.TabIndex = 8;
            // 
            // btnCrearRequi
            // 
            this.btnCrearRequi.BorderRadius = 10;
            this.btnCrearRequi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearRequi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearRequi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearRequi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearRequi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnCrearRequi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearRequi.ForeColor = System.Drawing.Color.White;
            this.btnCrearRequi.Location = new System.Drawing.Point(765, 131);
            this.btnCrearRequi.Name = "btnCrearRequi";
            this.btnCrearRequi.Size = new System.Drawing.Size(139, 52);
            this.btnCrearRequi.TabIndex = 7;
            this.btnCrearRequi.Text = "Crear Requisición";
            this.btnCrearRequi.Click += new System.EventHandler(this.btnCrearRequi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Productos Seleccionados";
            // 
            // dgvProductosAgregados
            // 
            this.dgvProductosAgregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosAgregados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductosAgregados.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductosAgregados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductosAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosAgregados.Location = new System.Drawing.Point(25, 21);
            this.dgvProductosAgregados.Name = "dgvProductosAgregados";
            this.dgvProductosAgregados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductosAgregados.RowHeadersVisible = false;
            this.dgvProductosAgregados.Size = new System.Drawing.Size(492, 173);
            this.dgvProductosAgregados.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.lbIDserv);
            this.panel1.Controls.Add(this.dgvListadoServicio);
            this.panel1.Controls.Add(this.txtIDServi);
            this.panel1.Controls.Add(this.btnServicio);
            this.panel1.Location = new System.Drawing.Point(137, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 224);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.dgvListadoProductos);
            this.panel2.Controls.Add(this.btnProducto);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.lbID);
            this.panel2.Location = new System.Drawing.Point(137, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 224);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.panel3.Controls.Add(this.txtServicio);
            this.panel3.Controls.Add(this.btnAgregarS);
            this.panel3.Controls.Add(this.lbServi);
            this.panel3.Controls.Add(this.nudServicio);
            this.panel3.Controls.Add(this.lbCanServ);
            this.panel3.Location = new System.Drawing.Point(967, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 224);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.panel4.Controls.Add(this.txtProducto);
            this.panel4.Controls.Add(this.lbCantidad);
            this.panel4.Controls.Add(this.btnAgregarP);
            this.panel4.Controls.Add(this.nudCantidad);
            this.panel4.Controls.Add(this.lbProduc);
            this.panel4.Location = new System.Drawing.Point(967, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 224);
            this.panel4.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.panel5.Controls.Add(this.btnCrearRequi);
            this.panel5.Controls.Add(this.dgvProductosAgregados);
            this.panel5.Controls.Add(this.txtMotivo);
            this.panel5.Location = new System.Drawing.Point(134, 395);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1050, 209);
            this.panel5.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "CREAR REQUISICIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "CREAR REQUISICIÓN";
            // 
            // FrmRequisiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1386, 676);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRequisiciones";
            this.Text = "FrmRequisiciones";
            this.Load += new System.EventHandler(this.FrmRequisiciones_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAgregados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnProducto;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltroProduc;
        private System.Windows.Forms.DataGridView dgvListadoProductos;
        private System.Windows.Forms.Label lbListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductosAgregados;
        private Guna.UI2.WinForms.Guna2Button btnCrearRequi;
        private System.Windows.Forms.Label lbProduc;
        private Guna.UI2.WinForms.Guna2TextBox txtProducto;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtMotivo;
        private Guna.UI2.WinForms.Guna2Button btnServicio;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltroServicio;
        private System.Windows.Forms.DataGridView dgvListadoServicio;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnAgregarS;
        private System.Windows.Forms.Label lbID;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.Label lbIDserv;
        private Guna.UI2.WinForms.Guna2TextBox txtIDServi;
        private System.Windows.Forms.Label lbCanServ;
        private System.Windows.Forms.NumericUpDown nudServicio;
        private System.Windows.Forms.Label lbServi;
        private Guna.UI2.WinForms.Guna2TextBox txtServicio;
        private Guna.UI2.WinForms.Guna2Button btnAgregarP;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}