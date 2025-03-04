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
            this.btnAgregarP = new Guna.UI2.WinForms.Guna2Button();
            this.lbIDserv = new System.Windows.Forms.Label();
            this.txtIDServi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbCanServ = new System.Windows.Forms.Label();
            this.nudServicio = new System.Windows.Forms.NumericUpDown();
            this.lbServi = new System.Windows.Forms.Label();
            this.txtServicio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAgregarS = new Guna.UI2.WinForms.Guna2Button();
            this.btnServicio = new Guna.UI2.WinForms.Guna2Button();
            this.txtFiltroServicio = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvListadoServicio = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lbProduc = new System.Windows.Forms.Label();
            this.txtProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFiltroProduc = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvListadoProductos = new System.Windows.Forms.DataGridView();
            this.lbListado = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMotivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCrearRequi = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductosAgregados = new System.Windows.Forms.DataGridView();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtFiltroRequi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRequisiciones = new System.Windows.Forms.DataGridView();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAgregados)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProducto
            // 
            this.btnProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Location = new System.Drawing.Point(271, 56);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(134, 45);
            this.btnProducto.TabIndex = 0;
            this.btnProducto.Text = "Seleccionar productos";
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Controls.Add(this.btnAgregarP);
            this.guna2Panel1.Controls.Add(this.lbIDserv);
            this.guna2Panel1.Controls.Add(this.txtIDServi);
            this.guna2Panel1.Controls.Add(this.lbCanServ);
            this.guna2Panel1.Controls.Add(this.nudServicio);
            this.guna2Panel1.Controls.Add(this.lbServi);
            this.guna2Panel1.Controls.Add(this.txtServicio);
            this.guna2Panel1.Controls.Add(this.lbID);
            this.guna2Panel1.Controls.Add(this.txtID);
            this.guna2Panel1.Controls.Add(this.btnAgregarS);
            this.guna2Panel1.Controls.Add(this.btnServicio);
            this.guna2Panel1.Controls.Add(this.txtFiltroServicio);
            this.guna2Panel1.Controls.Add(this.dgvListadoServicio);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.lbCantidad);
            this.guna2Panel1.Controls.Add(this.nudCantidad);
            this.guna2Panel1.Controls.Add(this.lbProduc);
            this.guna2Panel1.Controls.Add(this.txtProducto);
            this.guna2Panel1.Controls.Add(this.btnProducto);
            this.guna2Panel1.Controls.Add(this.txtFiltroProduc);
            this.guna2Panel1.Controls.Add(this.dgvListadoProductos);
            this.guna2Panel1.Controls.Add(this.lbListado);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(691, 652);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAgregarP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarP.ForeColor = System.Drawing.Color.White;
            this.btnAgregarP.Location = new System.Drawing.Point(532, 285);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(120, 45);
            this.btnAgregarP.TabIndex = 25;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // lbIDserv
            // 
            this.lbIDserv.AutoSize = true;
            this.lbIDserv.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDserv.Location = new System.Drawing.Point(578, 341);
            this.lbIDserv.Name = "lbIDserv";
            this.lbIDserv.Size = new System.Drawing.Size(29, 19);
            this.lbIDserv.TabIndex = 24;
            this.lbIDserv.Text = "ID";
            // 
            // txtIDServi
            // 
            this.txtIDServi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDServi.DefaultText = "";
            this.txtIDServi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDServi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDServi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDServi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDServi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDServi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDServi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDServi.Location = new System.Drawing.Point(570, 363);
            this.txtIDServi.Name = "txtIDServi";
            this.txtIDServi.PlaceholderText = "";
            this.txtIDServi.ReadOnly = true;
            this.txtIDServi.SelectedText = "";
            this.txtIDServi.Size = new System.Drawing.Size(49, 36);
            this.txtIDServi.TabIndex = 23;
            // 
            // lbCanServ
            // 
            this.lbCanServ.AutoSize = true;
            this.lbCanServ.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCanServ.Location = new System.Drawing.Point(554, 487);
            this.lbCanServ.Name = "lbCanServ";
            this.lbCanServ.Size = new System.Drawing.Size(83, 19);
            this.lbCanServ.TabIndex = 22;
            this.lbCanServ.Text = "Cantidad";
            // 
            // nudServicio
            // 
            this.nudServicio.Location = new System.Drawing.Point(532, 509);
            this.nudServicio.Name = "nudServicio";
            this.nudServicio.Size = new System.Drawing.Size(120, 20);
            this.nudServicio.TabIndex = 21;
            // 
            // lbServi
            // 
            this.lbServi.AutoSize = true;
            this.lbServi.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServi.Location = new System.Drawing.Point(561, 412);
            this.lbServi.Name = "lbServi";
            this.lbServi.Size = new System.Drawing.Size(76, 19);
            this.lbServi.TabIndex = 20;
            this.lbServi.Text = "Servicio";
            // 
            // txtServicio
            // 
            this.txtServicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServicio.DefaultText = "";
            this.txtServicio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServicio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServicio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtServicio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServicio.Location = new System.Drawing.Point(517, 434);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.PlaceholderText = "";
            this.txtServicio.ReadOnly = true;
            this.txtServicio.SelectedText = "";
            this.txtServicio.Size = new System.Drawing.Size(162, 36);
            this.txtServicio.TabIndex = 19;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(578, 70);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(29, 19);
            this.lbID.TabIndex = 18;
            this.lbID.Text = "ID";
            this.lbID.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(570, 92);
            this.txtID.Name = "txtID";
            this.txtID.PlaceholderText = "";
            this.txtID.ReadOnly = true;
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(49, 36);
            this.txtID.TabIndex = 17;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnAgregarS
            // 
            this.btnAgregarS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAgregarS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarS.ForeColor = System.Drawing.Color.White;
            this.btnAgregarS.Location = new System.Drawing.Point(532, 552);
            this.btnAgregarS.Name = "btnAgregarS";
            this.btnAgregarS.Size = new System.Drawing.Size(120, 45);
            this.btnAgregarS.TabIndex = 16;
            this.btnAgregarS.Text = "Agregar";
            this.btnAgregarS.Click += new System.EventHandler(this.btnAgregarS_Click);
            // 
            // btnServicio
            // 
            this.btnServicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnServicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnServicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnServicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnServicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnServicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicio.ForeColor = System.Drawing.Color.White;
            this.btnServicio.Location = new System.Drawing.Point(271, 379);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Size = new System.Drawing.Size(134, 45);
            this.btnServicio.TabIndex = 12;
            this.btnServicio.Text = "Seleccionar Servicios";
            this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click);
            // 
            // txtFiltroServicio
            // 
            this.txtFiltroServicio.BorderRadius = 10;
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
            this.txtFiltroServicio.Location = new System.Drawing.Point(38, 388);
            this.txtFiltroServicio.Name = "txtFiltroServicio";
            this.txtFiltroServicio.PlaceholderText = "";
            this.txtFiltroServicio.SelectedText = "";
            this.txtFiltroServicio.Size = new System.Drawing.Size(200, 36);
            this.txtFiltroServicio.TabIndex = 15;
            this.txtFiltroServicio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltroServicio_KeyUp);
            // 
            // dgvListadoServicio
            // 
            this.dgvListadoServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoServicio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoServicio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListadoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoServicio.Location = new System.Drawing.Point(38, 440);
            this.dgvListadoServicio.Name = "dgvListadoServicio";
            this.dgvListadoServicio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListadoServicio.RowHeadersVisible = false;
            this.dgvListadoServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoServicio.Size = new System.Drawing.Size(447, 199);
            this.dgvListadoServicio.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Listado Servicio";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(554, 216);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(83, 19);
            this.lbCantidad.TabIndex = 11;
            this.lbCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(532, 238);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 10;
            // 
            // lbProduc
            // 
            this.lbProduc.AutoSize = true;
            this.lbProduc.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduc.Location = new System.Drawing.Point(545, 141);
            this.lbProduc.Name = "lbProduc";
            this.lbProduc.Size = new System.Drawing.Size(85, 19);
            this.lbProduc.TabIndex = 9;
            this.lbProduc.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProducto.DefaultText = "";
            this.txtProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProducto.Location = new System.Drawing.Point(517, 163);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PlaceholderText = "";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.SelectedText = "";
            this.txtProducto.Size = new System.Drawing.Size(162, 36);
            this.txtProducto.TabIndex = 7;
            // 
            // txtFiltroProduc
            // 
            this.txtFiltroProduc.BorderRadius = 10;
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
            this.txtFiltroProduc.Location = new System.Drawing.Point(38, 65);
            this.txtFiltroProduc.Name = "txtFiltroProduc";
            this.txtFiltroProduc.PlaceholderText = "";
            this.txtFiltroProduc.SelectedText = "";
            this.txtFiltroProduc.Size = new System.Drawing.Size(200, 36);
            this.txtFiltroProduc.TabIndex = 6;
            this.txtFiltroProduc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltroProduc_KeyUp);
            // 
            // dgvListadoProductos
            // 
            this.dgvListadoProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProductos.Location = new System.Drawing.Point(38, 117);
            this.dgvListadoProductos.Name = "dgvListadoProductos";
            this.dgvListadoProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListadoProductos.RowHeadersVisible = false;
            this.dgvListadoProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoProductos.Size = new System.Drawing.Size(447, 187);
            this.dgvListadoProductos.TabIndex = 4;
            // 
            // lbListado
            // 
            this.lbListado.AutoSize = true;
            this.lbListado.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListado.Location = new System.Drawing.Point(34, 28);
            this.lbListado.Name = "lbListado";
            this.lbListado.Size = new System.Drawing.Size(157, 19);
            this.lbListado.TabIndex = 5;
            this.lbListado.Text = "Listado Productos";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.txtMotivo);
            this.guna2Panel2.Controls.Add(this.btnCrearRequi);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.dgvProductosAgregados);
            this.guna2Panel2.Location = new System.Drawing.Point(709, 12);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(665, 349);
            this.guna2Panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 19);
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
            this.txtMotivo.Location = new System.Drawing.Point(419, 75);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PlaceholderText = "";
            this.txtMotivo.SelectedText = "";
            this.txtMotivo.Size = new System.Drawing.Size(213, 216);
            this.txtMotivo.TabIndex = 8;
            // 
            // btnCrearRequi
            // 
            this.btnCrearRequi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearRequi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearRequi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearRequi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearRequi.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCrearRequi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCrearRequi.ForeColor = System.Drawing.Color.Black;
            this.btnCrearRequi.Location = new System.Drawing.Point(231, 297);
            this.btnCrearRequi.Name = "btnCrearRequi";
            this.btnCrearRequi.Size = new System.Drawing.Size(172, 33);
            this.btnCrearRequi.TabIndex = 7;
            this.btnCrearRequi.Text = "Crear Requisición";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Productos Seleccionados";
            // 
            // dgvProductosAgregados
            // 
            this.dgvProductosAgregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosAgregados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductosAgregados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductosAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosAgregados.Location = new System.Drawing.Point(27, 75);
            this.dgvProductosAgregados.Name = "dgvProductosAgregados";
            this.dgvProductosAgregados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductosAgregados.RowHeadersVisible = false;
            this.dgvProductosAgregados.Size = new System.Drawing.Size(376, 216);
            this.dgvProductosAgregados.TabIndex = 7;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel3.Controls.Add(this.txtFiltroRequi);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.dgvRequisiciones);
            this.guna2Panel3.Location = new System.Drawing.Point(709, 367);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(665, 297);
            this.guna2Panel3.TabIndex = 3;
            // 
            // txtFiltroRequi
            // 
            this.txtFiltroRequi.BorderRadius = 10;
            this.txtFiltroRequi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroRequi.DefaultText = "";
            this.txtFiltroRequi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltroRequi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltroRequi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltroRequi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltroRequi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltroRequi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltroRequi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltroRequi.IconRight = global::ModuloDeCompra_BD.Properties.Resources.brows_browsing_find_search_seo_web_zoom_icon_123196;
            this.txtFiltroRequi.Location = new System.Drawing.Point(27, 25);
            this.txtFiltroRequi.Name = "txtFiltroRequi";
            this.txtFiltroRequi.PlaceholderText = "";
            this.txtFiltroRequi.SelectedText = "";
            this.txtFiltroRequi.Size = new System.Drawing.Size(200, 36);
            this.txtFiltroRequi.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Requisiciones";
            // 
            // dgvRequisiciones
            // 
            this.dgvRequisiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequisiciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRequisiciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRequisiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisiciones.Location = new System.Drawing.Point(27, 67);
            this.dgvRequisiciones.Name = "dgvRequisiciones";
            this.dgvRequisiciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRequisiciones.RowHeadersVisible = false;
            this.dgvRequisiciones.Size = new System.Drawing.Size(501, 200);
            this.dgvRequisiciones.TabIndex = 7;
            // 
            // FrmRequisiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1386, 663);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRequisiciones";
            this.Text = "FrmRequisiciones";
            this.Load += new System.EventHandler(this.FrmRequisiciones_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAgregados)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisiciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnProducto;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltroProduc;
        private System.Windows.Forms.DataGridView dgvListadoProductos;
        private System.Windows.Forms.Label lbListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductosAgregados;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnCrearRequi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRequisiciones;
        private System.Windows.Forms.Label lbProduc;
        private Guna.UI2.WinForms.Guna2TextBox txtProducto;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtMotivo;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltroRequi;
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
    }
}