namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmRecepcionCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDebito = new Guna.UI2.WinForms.Guna2Button();
            this.txtDebito = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCredito = new Guna.UI2.WinForms.Guna2Button();
            this.txtCredito = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombreProveedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnOrdenCompra = new Guna.UI2.WinForms.Guna2Button();
            this.txtProveedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOrdenCompra = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoGRN = new System.Windows.Forms.ComboBox();
            this.lbCantRecib = new System.Windows.Forms.Label();
            this.dgvDetalleOrden = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvaux = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnGenerarGrn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvGrnDeOrden = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCancelarOrden = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaux)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrnDeOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECEPCIÓN DE ÓRDENES (GRN)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 366);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.panel3.Controls.Add(this.btnDebito);
            this.panel3.Controls.Add(this.txtDebito);
            this.panel3.Controls.Add(this.btnCredito);
            this.panel3.Controls.Add(this.txtCredito);
            this.panel3.Location = new System.Drawing.Point(1167, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 295);
            this.panel3.TabIndex = 16;
            // 
            // btnDebito
            // 
            this.btnDebito.BorderRadius = 10;
            this.btnDebito.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDebito.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDebito.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDebito.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDebito.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnDebito.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebito.ForeColor = System.Drawing.Color.White;
            this.btnDebito.Location = new System.Drawing.Point(18, 40);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(122, 35);
            this.btnDebito.TabIndex = 11;
            this.btnDebito.Text = "Débito";
            this.btnDebito.Click += new System.EventHandler(this.btnDebito_Click);
            // 
            // txtDebito
            // 
            this.txtDebito.BorderRadius = 5;
            this.txtDebito.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDebito.DefaultText = "";
            this.txtDebito.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDebito.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDebito.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDebito.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDebito.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDebito.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDebito.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDebito.Location = new System.Drawing.Point(36, 80);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.PlaceholderText = "";
            this.txtDebito.ReadOnly = true;
            this.txtDebito.SelectedText = "";
            this.txtDebito.Size = new System.Drawing.Size(86, 27);
            this.txtDebito.TabIndex = 14;
            this.txtDebito.TextChanged += new System.EventHandler(this.txtDebito_TextChanged);
            // 
            // btnCredito
            // 
            this.btnCredito.BorderRadius = 10;
            this.btnCredito.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCredito.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCredito.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCredito.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCredito.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnCredito.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredito.ForeColor = System.Drawing.Color.White;
            this.btnCredito.Location = new System.Drawing.Point(18, 186);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(122, 35);
            this.btnCredito.TabIndex = 12;
            this.btnCredito.Text = "Crédito";
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // txtCredito
            // 
            this.txtCredito.BorderRadius = 5;
            this.txtCredito.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCredito.DefaultText = "";
            this.txtCredito.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCredito.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCredito.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCredito.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCredito.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCredito.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCredito.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCredito.Location = new System.Drawing.Point(36, 224);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.PlaceholderText = "";
            this.txtCredito.ReadOnly = true;
            this.txtCredito.SelectedText = "";
            this.txtCredito.Size = new System.Drawing.Size(86, 27);
            this.txtCredito.TabIndex = 13;
            this.txtCredito.TextChanged += new System.EventHandler(this.txtCredito_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.txtNombreProveedor);
            this.panel2.Controls.Add(this.btnOrdenCompra);
            this.panel2.Controls.Add(this.txtProveedor);
            this.panel2.Controls.Add(this.txtOrdenCompra);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(17, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 291);
            this.panel2.TabIndex = 15;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.BorderRadius = 5;
            this.txtNombreProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProveedor.DefaultText = "";
            this.txtNombreProveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProveedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreProveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProveedor.Location = new System.Drawing.Point(41, 161);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.PlaceholderText = "";
            this.txtNombreProveedor.ReadOnly = true;
            this.txtNombreProveedor.SelectedText = "";
            this.txtNombreProveedor.Size = new System.Drawing.Size(86, 27);
            this.txtNombreProveedor.TabIndex = 6;
            // 
            // btnOrdenCompra
            // 
            this.btnOrdenCompra.BorderRadius = 10;
            this.btnOrdenCompra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrdenCompra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrdenCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrdenCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrdenCompra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnOrdenCompra.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenCompra.ForeColor = System.Drawing.Color.White;
            this.btnOrdenCompra.Location = new System.Drawing.Point(17, 15);
            this.btnOrdenCompra.Name = "btnOrdenCompra";
            this.btnOrdenCompra.Size = new System.Drawing.Size(133, 51);
            this.btnOrdenCompra.TabIndex = 1;
            this.btnOrdenCompra.Text = "Orden de compra";
            this.btnOrdenCompra.Click += new System.EventHandler(this.btnOrdenCompra_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.BorderRadius = 5;
            this.txtProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProveedor.DefaultText = "";
            this.txtProveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProveedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProveedor.Location = new System.Drawing.Point(41, 161);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.PlaceholderText = "";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.SelectedText = "";
            this.txtProveedor.Size = new System.Drawing.Size(86, 27);
            this.txtProveedor.TabIndex = 4;
            this.txtProveedor.TextChanged += new System.EventHandler(this.txtProveedor_TextChanged);
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.BorderRadius = 5;
            this.txtOrdenCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrdenCompra.DefaultText = "";
            this.txtOrdenCompra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOrdenCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOrdenCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrdenCompra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrdenCompra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrdenCompra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOrdenCompra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrdenCompra.Location = new System.Drawing.Point(41, 72);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.PlaceholderText = "";
            this.txtOrdenCompra.ReadOnly = true;
            this.txtOrdenCompra.SelectedText = "";
            this.txtOrdenCompra.Size = new System.Drawing.Size(86, 27);
            this.txtOrdenCompra.TabIndex = 2;
            this.txtOrdenCompra.TextChanged += new System.EventHandler(this.txtOrdenCompra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proveedor";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.BtnCancelarOrden);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.cbTipoGRN);
            this.guna2Panel1.Controls.Add(this.lbCantRecib);
            this.guna2Panel1.Controls.Add(this.dgvDetalleOrden);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.dgvaux);
            this.guna2Panel1.Controls.Add(this.btnGenerarGrn);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Location = new System.Drawing.Point(235, 59);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(898, 295);
            this.guna2Panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de Recepción";
            // 
            // cbTipoGRN
            // 
            this.cbTipoGRN.FormattingEnabled = true;
            this.cbTipoGRN.Items.AddRange(new object[] {
            " Parcial",
            " Completa"});
            this.cbTipoGRN.Location = new System.Drawing.Point(198, 242);
            this.cbTipoGRN.Name = "cbTipoGRN";
            this.cbTipoGRN.Size = new System.Drawing.Size(121, 21);
            this.cbTipoGRN.TabIndex = 11;
            this.cbTipoGRN.SelectedIndexChanged += new System.EventHandler(this.cbTipoGRN_SelectedIndexChanged);
            // 
            // lbCantRecib
            // 
            this.lbCantRecib.AutoSize = true;
            this.lbCantRecib.BackColor = System.Drawing.Color.Transparent;
            this.lbCantRecib.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantRecib.ForeColor = System.Drawing.Color.White;
            this.lbCantRecib.Location = new System.Drawing.Point(502, 15);
            this.lbCantRecib.Name = "lbCantRecib";
            this.lbCantRecib.Size = new System.Drawing.Size(243, 22);
            this.lbCantRecib.TabIndex = 8;
            this.lbCantRecib.Text = "Registre cantidad Recibida";
            // 
            // dgvDetalleOrden
            // 
            this.dgvDetalleOrden.AllowUserToAddRows = false;
            this.dgvDetalleOrden.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDetalleOrden.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleOrden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleOrden.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleOrden.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalleOrden.Location = new System.Drawing.Point(39, 40);
            this.dgvDetalleOrden.MultiSelect = false;
            this.dgvDetalleOrden.Name = "dgvDetalleOrden";
            this.dgvDetalleOrden.RowHeadersVisible = false;
            this.dgvDetalleOrden.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetalleOrden.RowTemplate.Height = 40;
            this.dgvDetalleOrden.Size = new System.Drawing.Size(819, 181);
            this.dgvDetalleOrden.TabIndex = 7;
            this.dgvDetalleOrden.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalleOrden.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDetalleOrden.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDetalleOrden.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDetalleOrden.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDetalleOrden.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalleOrden.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalleOrden.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDetalleOrden.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalleOrden.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleOrden.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetalleOrden.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalleOrden.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvDetalleOrden.ThemeStyle.ReadOnly = false;
            this.dgvDetalleOrden.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalleOrden.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleOrden.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleOrden.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDetalleOrden.ThemeStyle.RowsStyle.Height = 40;
            this.dgvDetalleOrden.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalleOrden.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDetalleOrden.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleOrden_CellEndEdit);
            this.dgvDetalleOrden.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDetalleOrden_CellPainting);
            this.dgvDetalleOrden.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDetalleOrden_DataError);
            this.dgvDetalleOrden.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDetalleOrden_EditingControlShowing);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Detalles de la Orden de Compra";
            // 
            // dgvaux
            // 
            this.dgvaux.AllowUserToAddRows = false;
            this.dgvaux.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvaux.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvaux.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvaux.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvaux.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvaux.Location = new System.Drawing.Point(39, 40);
            this.dgvaux.MultiSelect = false;
            this.dgvaux.Name = "dgvaux";
            this.dgvaux.RowHeadersVisible = false;
            this.dgvaux.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvaux.RowTemplate.Height = 40;
            this.dgvaux.Size = new System.Drawing.Size(276, 181);
            this.dgvaux.TabIndex = 9;
            this.dgvaux.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvaux.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvaux.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvaux.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvaux.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvaux.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvaux.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvaux.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvaux.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvaux.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvaux.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvaux.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvaux.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvaux.ThemeStyle.ReadOnly = false;
            this.dgvaux.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvaux.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvaux.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvaux.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvaux.ThemeStyle.RowsStyle.Height = 40;
            this.dgvaux.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvaux.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvaux.Visible = false;
            // 
            // btnGenerarGrn
            // 
            this.btnGenerarGrn.BorderRadius = 10;
            this.btnGenerarGrn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarGrn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarGrn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerarGrn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerarGrn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnGenerarGrn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarGrn.ForeColor = System.Drawing.Color.White;
            this.btnGenerarGrn.Location = new System.Drawing.Point(417, 240);
            this.btnGenerarGrn.Name = "btnGenerarGrn";
            this.btnGenerarGrn.Size = new System.Drawing.Size(128, 44);
            this.btnGenerarGrn.TabIndex = 6;
            this.btnGenerarGrn.Text = "Generar GRN";
            this.btnGenerarGrn.Click += new System.EventHandler(this.btnGenerarGrn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.guna2Button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(720, 240);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(128, 44);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Cancelar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.dgvGrnDeOrden);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Location = new System.Drawing.Point(121, 404);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1144, 247);
            this.guna2Panel2.TabIndex = 4;
            // 
            // dgvGrnDeOrden
            // 
            this.dgvGrnDeOrden.AllowUserToAddRows = false;
            this.dgvGrnDeOrden.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvGrnDeOrden.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrnDeOrden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrnDeOrden.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvGrnDeOrden.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGrnDeOrden.Location = new System.Drawing.Point(34, 41);
            this.dgvGrnDeOrden.MultiSelect = false;
            this.dgvGrnDeOrden.Name = "dgvGrnDeOrden";
            this.dgvGrnDeOrden.ReadOnly = true;
            this.dgvGrnDeOrden.RowHeadersVisible = false;
            this.dgvGrnDeOrden.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGrnDeOrden.Size = new System.Drawing.Size(1074, 181);
            this.dgvGrnDeOrden.TabIndex = 7;
            this.dgvGrnDeOrden.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGrnDeOrden.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGrnDeOrden.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGrnDeOrden.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGrnDeOrden.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGrnDeOrden.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGrnDeOrden.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGrnDeOrden.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvGrnDeOrden.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGrnDeOrden.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGrnDeOrden.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGrnDeOrden.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGrnDeOrden.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvGrnDeOrden.ThemeStyle.ReadOnly = true;
            this.dgvGrnDeOrden.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGrnDeOrden.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGrnDeOrden.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGrnDeOrden.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGrnDeOrden.ThemeStyle.RowsStyle.Height = 22;
            this.dgvGrnDeOrden.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGrnDeOrden.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(539, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "GRN  Generados para esta Orden";
            // 
            // BtnCancelarOrden
            // 
            this.BtnCancelarOrden.BorderRadius = 10;
            this.BtnCancelarOrden.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCancelarOrden.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCancelarOrden.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCancelarOrden.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCancelarOrden.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.BtnCancelarOrden.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarOrden.ForeColor = System.Drawing.Color.White;
            this.BtnCancelarOrden.Location = new System.Drawing.Point(558, 242);
            this.BtnCancelarOrden.Name = "BtnCancelarOrden";
            this.BtnCancelarOrden.Size = new System.Drawing.Size(146, 44);
            this.BtnCancelarOrden.TabIndex = 12;
            this.BtnCancelarOrden.Text = "Cancelar Orden Compra";
            this.BtnCancelarOrden.Click += new System.EventHandler(this.BtnCancelarOrden_Click);
            // 
            // FrmRecepcionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1386, 663);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecepcionCompra";
            this.Text = "FrmRecepcionCompra";
            this.Load += new System.EventHandler(this.FrmRecepcionCompra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaux)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrnDeOrden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtOrdenCompra;
        private Guna.UI2.WinForms.Guna2Button btnOrdenCompra;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtProveedor;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnGenerarGrn;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetalleOrden;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGrnDeOrden;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label lbCantRecib;
        private Guna.UI2.WinForms.Guna2TextBox txtDebito;
        private Guna.UI2.WinForms.Guna2TextBox txtCredito;
        private Guna.UI2.WinForms.Guna2Button btnCredito;
        private Guna.UI2.WinForms.Guna2Button btnDebito;
        private Guna.UI2.WinForms.Guna2DataGridView dgvaux;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoGRN;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreProveedor;
        private Guna.UI2.WinForms.Guna2Button BtnCancelarOrden;
    }
}