namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmDetalleRequisicion
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
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.cmbEstados = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtServicioID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtNuevaCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNuevaCantidad = new System.Windows.Forms.Label();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.txtMotivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnRegresar = new Guna.UI2.WinForms.Guna2Button();
            this.txtRequisicion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRequisicion = new System.Windows.Forms.Label();
            this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvEstadoRequision = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoRequision)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.pnlSubMenu.Controls.Add(this.cmbEstados);
            this.pnlSubMenu.Controls.Add(this.txtServicioID);
            this.pnlSubMenu.Controls.Add(this.label1);
            this.pnlSubMenu.Controls.Add(this.lblEstado);
            this.pnlSubMenu.Controls.Add(this.lblMotivo);
            this.pnlSubMenu.Controls.Add(this.txtNuevaCantidad);
            this.pnlSubMenu.Controls.Add(this.lblNuevaCantidad);
            this.pnlSubMenu.Controls.Add(this.btnModificar);
            this.pnlSubMenu.Controls.Add(this.txtMotivo);
            this.pnlSubMenu.Controls.Add(this.txtCantidad);
            this.pnlSubMenu.Controls.Add(this.lblCantidad);
            this.pnlSubMenu.Controls.Add(this.txtProducto);
            this.pnlSubMenu.Controls.Add(this.lblProducto);
            this.pnlSubMenu.Controls.Add(this.btnRegresar);
            this.pnlSubMenu.Controls.Add(this.txtRequisicion);
            this.pnlSubMenu.Controls.Add(this.lblRequisicion);
            this.pnlSubMenu.Controls.Add(this.btnAceptar);
            this.pnlSubMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSubMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(319, 771);
            this.pnlSubMenu.TabIndex = 1;
            // 
            // cmbEstados
            // 
            this.cmbEstados.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstados.BorderRadius = 15;
            this.cmbEstados.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstados.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEstados.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEstados.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEstados.ItemHeight = 30;
            this.cmbEstados.Items.AddRange(new object[] {
            "Aprobado",
            "Rechazado"});
            this.cmbEstados.Location = new System.Drawing.Point(69, 648);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(193, 36);
            this.cmbEstados.TabIndex = 25;
            // 
            // txtServicioID
            // 
            this.txtServicioID.BorderRadius = 10;
            this.txtServicioID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServicioID.DefaultText = "";
            this.txtServicioID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServicioID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServicioID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServicioID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServicioID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServicioID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtServicioID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServicioID.Location = new System.Drawing.Point(62, 247);
            this.txtServicioID.Multiline = true;
            this.txtServicioID.Name = "txtServicioID";
            this.txtServicioID.PlaceholderText = "";
            this.txtServicioID.ReadOnly = true;
            this.txtServicioID.SelectedText = "";
            this.txtServicioID.Size = new System.Drawing.Size(200, 39);
            this.txtServicioID.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(115, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID Servicio";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEstado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEstado.Location = new System.Drawing.Point(138, 612);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 21;
            this.lblEstado.Text = "Estado";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMotivo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMotivo.Location = new System.Drawing.Point(93, 373);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(141, 20);
            this.lblMotivo.TabIndex = 15;
            this.lblMotivo.Text = "Motivo Requisición";
            // 
            // txtNuevaCantidad
            // 
            this.txtNuevaCantidad.BorderRadius = 10;
            this.txtNuevaCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNuevaCantidad.DefaultText = "";
            this.txtNuevaCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNuevaCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNuevaCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNuevaCantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNuevaCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNuevaCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNuevaCantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNuevaCantidad.Location = new System.Drawing.Point(62, 396);
            this.txtNuevaCantidad.Name = "txtNuevaCantidad";
            this.txtNuevaCantidad.PlaceholderText = "";
            this.txtNuevaCantidad.SelectedText = "";
            this.txtNuevaCantidad.Size = new System.Drawing.Size(200, 36);
            this.txtNuevaCantidad.TabIndex = 19;
            this.txtNuevaCantidad.Visible = false;
            // 
            // lblNuevaCantidad
            // 
            this.lblNuevaCantidad.AutoSize = true;
            this.lblNuevaCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNuevaCantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNuevaCantidad.Location = new System.Drawing.Point(104, 373);
            this.lblNuevaCantidad.Name = "lblNuevaCantidad";
            this.lblNuevaCantidad.Size = new System.Drawing.Size(122, 20);
            this.lblNuevaCantidad.TabIndex = 18;
            this.lblNuevaCantidad.Text = "Nueva Cantidad";
            this.lblNuevaCantidad.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BorderRadius = 20;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(173, 706);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(133, 53);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtMotivo
            // 
            this.txtMotivo.BorderRadius = 10;
            this.txtMotivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotivo.DefaultText = "";
            this.txtMotivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMotivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMotivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMotivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotivo.Location = new System.Drawing.Point(62, 396);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PlaceholderText = "";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.SelectedText = "";
            this.txtMotivo.Size = new System.Drawing.Size(200, 114);
            this.txtMotivo.TabIndex = 16;
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
            this.txtCantidad.Location = new System.Drawing.Point(62, 325);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PlaceholderText = "";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.Size = new System.Drawing.Size(200, 36);
            this.txtCantidad.TabIndex = 14;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCantidad.Location = new System.Drawing.Point(127, 302);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtProducto
            // 
            this.txtProducto.BorderRadius = 10;
            this.txtProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProducto.DefaultText = "";
            this.txtProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProducto.Location = new System.Drawing.Point(62, 155);
            this.txtProducto.Multiline = true;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PlaceholderText = "";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.SelectedText = "";
            this.txtProducto.Size = new System.Drawing.Size(200, 39);
            this.txtProducto.TabIndex = 12;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProducto.Location = new System.Drawing.Point(115, 119);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(94, 20);
            this.lblProducto.TabIndex = 11;
            this.lblProducto.Text = "ID Producto";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BorderRadius = 20;
            this.btnRegresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(12, 706);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(133, 53);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Regresar a Requisición";
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtRequisicion
            // 
            this.txtRequisicion.BorderRadius = 10;
            this.txtRequisicion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRequisicion.DefaultText = "";
            this.txtRequisicion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRequisicion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRequisicion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRequisicion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRequisicion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRequisicion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRequisicion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRequisicion.Location = new System.Drawing.Point(62, 71);
            this.txtRequisicion.Name = "txtRequisicion";
            this.txtRequisicion.PlaceholderText = "";
            this.txtRequisicion.ReadOnly = true;
            this.txtRequisicion.SelectedText = "";
            this.txtRequisicion.Size = new System.Drawing.Size(200, 36);
            this.txtRequisicion.TabIndex = 1;
            // 
            // lblRequisicion
            // 
            this.lblRequisicion.AutoSize = true;
            this.lblRequisicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRequisicion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRequisicion.Location = new System.Drawing.Point(93, 38);
            this.lblRequisicion.Name = "lblRequisicion";
            this.lblRequisicion.Size = new System.Drawing.Size(139, 20);
            this.lblRequisicion.TabIndex = 0;
            this.lblRequisicion.Text = "Orden Requisición";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BorderRadius = 20;
            this.btnAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAceptar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(12, 706);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(133, 53);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Confirmar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvEstadoRequision
            // 
            this.dgvEstadoRequision.AllowUserToAddRows = false;
            this.dgvEstadoRequision.AllowUserToDeleteRows = false;
            this.dgvEstadoRequision.AllowUserToResizeColumns = false;
            this.dgvEstadoRequision.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEstadoRequision.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoRequision.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstadoRequision.ColumnHeadersHeight = 4;
            this.dgvEstadoRequision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstadoRequision.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstadoRequision.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEstadoRequision.Location = new System.Drawing.Point(466, 50);
            this.dgvEstadoRequision.Name = "dgvEstadoRequision";
            this.dgvEstadoRequision.RowHeadersVisible = false;
            this.dgvEstadoRequision.Size = new System.Drawing.Size(808, 683);
            this.dgvEstadoRequision.TabIndex = 0;
            this.dgvEstadoRequision.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstadoRequision.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEstadoRequision.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEstadoRequision.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEstadoRequision.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEstadoRequision.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstadoRequision.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEstadoRequision.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEstadoRequision.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEstadoRequision.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEstadoRequision.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEstadoRequision.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEstadoRequision.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvEstadoRequision.ThemeStyle.ReadOnly = false;
            this.dgvEstadoRequision.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstadoRequision.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEstadoRequision.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEstadoRequision.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEstadoRequision.ThemeStyle.RowsStyle.Height = 22;
            this.dgvEstadoRequision.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEstadoRequision.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEstadoRequision.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellDoubleClick);
            // 
            // FrmDetalleRequisicion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1386, 771);
            this.Controls.Add(this.pnlSubMenu);
            this.Controls.Add(this.dgvEstadoRequision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetalleRequisicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetalleRequisicions";
            this.Load += new System.EventHandler(this.FrmDetalleRequisicion_Load);
            this.pnlSubMenu.ResumeLayout(false);
            this.pnlSubMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoRequision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSubMenu;
        private System.Windows.Forms.Label lblRequisicion;
        private Guna.UI2.WinForms.Guna2Button btnAceptar;
        private Guna.UI2.WinForms.Guna2Button btnRegresar;
        private System.Windows.Forms.Label lblMotivo;
        private Guna.UI2.WinForms.Guna2TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private Guna.UI2.WinForms.Guna2TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
        public Guna.UI2.WinForms.Guna2DataGridView dgvEstadoRequision;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        public Guna.UI2.WinForms.Guna2TextBox txtRequisicion;
        private Guna.UI2.WinForms.Guna2TextBox txtNuevaCantidad;
        private System.Windows.Forms.Label lblNuevaCantidad;
        public Guna.UI2.WinForms.Guna2TextBox txtMotivo;
        private System.Windows.Forms.Label lblEstado;
        private Guna.UI2.WinForms.Guna2TextBox txtServicioID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEstados;
    }
}