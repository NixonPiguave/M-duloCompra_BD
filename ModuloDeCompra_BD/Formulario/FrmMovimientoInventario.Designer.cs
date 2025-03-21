namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmMovimientoInventario
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
            this.pnlBotones = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.txtIDGRN = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIDGRN = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvMovimientoInventario = new System.Windows.Forms.DataGridView();
            this.btnEscogerGRN = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAux = new System.Windows.Forms.DataGridView();
            this.txtValor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblValor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCantidad = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCostoUni = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCostoUni = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCostoInve = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCostoInventario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCUCompra = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCUCompra = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtGRNDetalle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGRNDetalle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientoInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAux)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.pnlBotones.Controls.Add(this.txtGRNDetalle);
            this.pnlBotones.Controls.Add(this.lblGRNDetalle);
            this.pnlBotones.Controls.Add(this.txtCUCompra);
            this.pnlBotones.Controls.Add(this.lblCUCompra);
            this.pnlBotones.Controls.Add(this.txtCostoInve);
            this.pnlBotones.Controls.Add(this.lblCostoInventario);
            this.pnlBotones.Controls.Add(this.txtCostoUni);
            this.pnlBotones.Controls.Add(this.lblCostoUni);
            this.pnlBotones.Controls.Add(this.txtCantidad);
            this.pnlBotones.Controls.Add(this.lblCantidad);
            this.pnlBotones.Controls.Add(this.txtValor);
            this.pnlBotones.Controls.Add(this.lblValor);
            this.pnlBotones.Controls.Add(this.btnEscogerGRN);
            this.pnlBotones.Controls.Add(this.btnAgregar);
            this.pnlBotones.Controls.Add(this.txtIDGRN);
            this.pnlBotones.Controls.Add(this.lblIDGRN);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1370, 207);
            this.pnlBotones.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(576, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(192, 42);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Registrar Movimiento";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtIDGRN
            // 
            this.txtIDGRN.BorderRadius = 10;
            this.txtIDGRN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDGRN.DefaultText = "";
            this.txtIDGRN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDGRN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDGRN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDGRN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDGRN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDGRN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDGRN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDGRN.Location = new System.Drawing.Point(144, 56);
            this.txtIDGRN.Name = "txtIDGRN";
            this.txtIDGRN.PlaceholderText = "";
            this.txtIDGRN.SelectedText = "";
            this.txtIDGRN.Size = new System.Drawing.Size(210, 35);
            this.txtIDGRN.TabIndex = 6;
            this.txtIDGRN.TextChanged += new System.EventHandler(this.txtIDGRN_TextChanged);
            this.txtIDGRN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtID_Bodega_KeyUp);
            // 
            // lblIDGRN
            // 
            this.lblIDGRN.BackColor = System.Drawing.Color.Transparent;
            this.lblIDGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDGRN.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIDGRN.Location = new System.Drawing.Point(144, 28);
            this.lblIDGRN.Name = "lblIDGRN";
            this.lblIDGRN.Size = new System.Drawing.Size(60, 22);
            this.lblIDGRN.TabIndex = 2;
            this.lblIDGRN.Text = "ID GRN";
            // 
            // dgvMovimientoInventario
            // 
            this.dgvMovimientoInventario.AllowUserToAddRows = false;
            this.dgvMovimientoInventario.AllowUserToOrderColumns = true;
            this.dgvMovimientoInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimientoInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMovimientoInventario.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovimientoInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientoInventario.Location = new System.Drawing.Point(32, 244);
            this.dgvMovimientoInventario.Name = "dgvMovimientoInventario";
            this.dgvMovimientoInventario.RowTemplate.Height = 18;
            this.dgvMovimientoInventario.Size = new System.Drawing.Size(1298, 399);
            this.dgvMovimientoInventario.TabIndex = 28;
            // 
            // btnEscogerGRN
            // 
            this.btnEscogerGRN.BorderRadius = 20;
            this.btnEscogerGRN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEscogerGRN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEscogerGRN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEscogerGRN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEscogerGRN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnEscogerGRN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscogerGRN.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEscogerGRN.Location = new System.Drawing.Point(383, 49);
            this.btnEscogerGRN.Name = "btnEscogerGRN";
            this.btnEscogerGRN.Size = new System.Drawing.Size(151, 42);
            this.btnEscogerGRN.TabIndex = 28;
            this.btnEscogerGRN.Text = "Escoger GRN";
            this.btnEscogerGRN.Click += new System.EventHandler(this.btnEscogerGRN_Click);
            // 
            // dgvAux
            // 
            this.dgvAux.AllowUserToAddRows = false;
            this.dgvAux.AllowUserToOrderColumns = true;
            this.dgvAux.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAux.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAux.BackgroundColor = System.Drawing.Color.White;
            this.dgvAux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAux.Location = new System.Drawing.Point(32, 244);
            this.dgvAux.Name = "dgvAux";
            this.dgvAux.RowTemplate.Height = 18;
            this.dgvAux.Size = new System.Drawing.Size(1298, 399);
            this.dgvAux.TabIndex = 29;
            this.dgvAux.Visible = false;
            this.dgvAux.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAux_CellDoubleClick);
            // 
            // txtValor
            // 
            this.txtValor.BorderRadius = 10;
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.DefaultText = "";
            this.txtValor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.Location = new System.Drawing.Point(143, 135);
            this.txtValor.Name = "txtValor";
            this.txtValor.PlaceholderText = "";
            this.txtValor.SelectedText = "";
            this.txtValor.Size = new System.Drawing.Size(126, 35);
            this.txtValor.TabIndex = 30;
            // 
            // lblValor
            // 
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblValor.Location = new System.Drawing.Point(143, 107);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(40, 22);
            this.lblValor.TabIndex = 29;
            this.lblValor.Text = "Valor";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderRadius = 10;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.DefaultText = "";
            this.txtCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.Location = new System.Drawing.Point(304, 135);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PlaceholderText = "";
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.Size = new System.Drawing.Size(126, 35);
            this.txtCantidad.TabIndex = 32;
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCantidad.Location = new System.Drawing.Point(304, 107);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(67, 22);
            this.lblCantidad.TabIndex = 31;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCostoUni
            // 
            this.txtCostoUni.BorderRadius = 10;
            this.txtCostoUni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCostoUni.DefaultText = "";
            this.txtCostoUni.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCostoUni.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCostoUni.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCostoUni.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCostoUni.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCostoUni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCostoUni.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCostoUni.Location = new System.Drawing.Point(473, 135);
            this.txtCostoUni.Name = "txtCostoUni";
            this.txtCostoUni.PlaceholderText = "";
            this.txtCostoUni.SelectedText = "";
            this.txtCostoUni.Size = new System.Drawing.Size(126, 35);
            this.txtCostoUni.TabIndex = 34;
            // 
            // lblCostoUni
            // 
            this.lblCostoUni.BackColor = System.Drawing.Color.Transparent;
            this.lblCostoUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoUni.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCostoUni.Location = new System.Drawing.Point(473, 107);
            this.lblCostoUni.Name = "lblCostoUni";
            this.lblCostoUni.Size = new System.Drawing.Size(100, 22);
            this.lblCostoUni.TabIndex = 33;
            this.lblCostoUni.Text = "Costo Unidad";
            // 
            // txtCostoInve
            // 
            this.txtCostoInve.BorderRadius = 10;
            this.txtCostoInve.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCostoInve.DefaultText = "";
            this.txtCostoInve.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCostoInve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCostoInve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCostoInve.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCostoInve.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCostoInve.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCostoInve.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCostoInve.Location = new System.Drawing.Point(664, 135);
            this.txtCostoInve.Name = "txtCostoInve";
            this.txtCostoInve.PlaceholderText = "";
            this.txtCostoInve.SelectedText = "";
            this.txtCostoInve.Size = new System.Drawing.Size(126, 35);
            this.txtCostoInve.TabIndex = 36;
            // 
            // lblCostoInventario
            // 
            this.lblCostoInventario.BackColor = System.Drawing.Color.Transparent;
            this.lblCostoInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoInventario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCostoInventario.Location = new System.Drawing.Point(664, 107);
            this.lblCostoInventario.Name = "lblCostoInventario";
            this.lblCostoInventario.Size = new System.Drawing.Size(119, 22);
            this.lblCostoInventario.TabIndex = 35;
            this.lblCostoInventario.Text = "Costo Inventario";
            // 
            // txtCUCompra
            // 
            this.txtCUCompra.BorderRadius = 10;
            this.txtCUCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCUCompra.DefaultText = "";
            this.txtCUCompra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCUCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCUCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCUCompra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCUCompra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCUCompra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCUCompra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCUCompra.Location = new System.Drawing.Point(861, 135);
            this.txtCUCompra.Name = "txtCUCompra";
            this.txtCUCompra.PlaceholderText = "";
            this.txtCUCompra.SelectedText = "";
            this.txtCUCompra.Size = new System.Drawing.Size(126, 35);
            this.txtCUCompra.TabIndex = 38;
            // 
            // lblCUCompra
            // 
            this.lblCUCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblCUCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUCompra.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCUCompra.Location = new System.Drawing.Point(861, 107);
            this.lblCUCompra.Name = "lblCUCompra";
            this.lblCUCompra.Size = new System.Drawing.Size(82, 22);
            this.lblCUCompra.TabIndex = 37;
            this.lblCUCompra.Text = "CUCompra";
            // 
            // txtGRNDetalle
            // 
            this.txtGRNDetalle.BorderRadius = 10;
            this.txtGRNDetalle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGRNDetalle.DefaultText = "";
            this.txtGRNDetalle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGRNDetalle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGRNDetalle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGRNDetalle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGRNDetalle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGRNDetalle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGRNDetalle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGRNDetalle.Location = new System.Drawing.Point(1051, 135);
            this.txtGRNDetalle.Name = "txtGRNDetalle";
            this.txtGRNDetalle.PlaceholderText = "";
            this.txtGRNDetalle.SelectedText = "";
            this.txtGRNDetalle.Size = new System.Drawing.Size(126, 35);
            this.txtGRNDetalle.TabIndex = 40;
            // 
            // lblGRNDetalle
            // 
            this.lblGRNDetalle.BackColor = System.Drawing.Color.Transparent;
            this.lblGRNDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRNDetalle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGRNDetalle.Location = new System.Drawing.Point(1051, 107);
            this.lblGRNDetalle.Name = "lblGRNDetalle";
            this.lblGRNDetalle.Size = new System.Drawing.Size(93, 22);
            this.lblGRNDetalle.TabIndex = 39;
            this.lblGRNDetalle.Text = "GRN Detalle";
            // 
            // FrmMovimientoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 663);
            this.Controls.Add(this.dgvAux);
            this.Controls.Add(this.dgvMovimientoInventario);
            this.Controls.Add(this.pnlBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMovimientoInventario";
            this.Text = "FrmMovimientoInventario";
            this.Load += new System.EventHandler(this.FrmMovimientoInventario_Load);
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientoInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAux)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlBotones;
        private Guna.UI2.WinForms.Guna2TextBox txtIDGRN;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIDGRN;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvMovimientoInventario;
        private Guna.UI2.WinForms.Guna2Button btnEscogerGRN;
        private System.Windows.Forms.DataGridView dgvAux;
        private Guna.UI2.WinForms.Guna2TextBox txtValor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblValor;
        private Guna.UI2.WinForms.Guna2TextBox txtGRNDetalle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGRNDetalle;
        private Guna.UI2.WinForms.Guna2TextBox txtCUCompra;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCUCompra;
        private Guna.UI2.WinForms.Guna2TextBox txtCostoInve;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCostoInventario;
        private Guna.UI2.WinForms.Guna2TextBox txtCostoUni;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCostoUni;
        private Guna.UI2.WinForms.Guna2TextBox txtCantidad;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCantidad;
    }
}