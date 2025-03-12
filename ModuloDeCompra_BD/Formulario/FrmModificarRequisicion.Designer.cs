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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.btnRegresar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.txtRequisicion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRequisicion = new System.Windows.Forms.Label();
            this.txtProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.dgvEstadoRequision = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.lblNuevaCantidad = new System.Windows.Forms.Label();
            this.txtNuevaCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMotivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoRequision)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
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
            // btnRegresar
            // 
            this.btnRegresar.BorderRadius = 20;
            this.btnRegresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegresar.FillColor = System.Drawing.Color.Red;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(12, 682);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(133, 53);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Regresar a Requisición";
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(12, 682);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(133, 53);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Confirmar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.lblProducto.Location = new System.Drawing.Point(125, 120);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(73, 20);
            this.lblProducto.TabIndex = 11;
            this.lblProducto.Text = "Producto";
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
            this.txtCantidad.Location = new System.Drawing.Point(62, 250);
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
            this.lblCantidad.Location = new System.Drawing.Point(125, 217);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMotivo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMotivo.Location = new System.Drawing.Point(93, 307);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(141, 20);
            this.lblMotivo.TabIndex = 15;
            this.lblMotivo.Text = "Motivo Requisición";
            // 
            // dgvEstadoRequision
            // 
            this.dgvEstadoRequision.AllowUserToAddRows = false;
            this.dgvEstadoRequision.AllowUserToDeleteRows = false;
            this.dgvEstadoRequision.AllowUserToResizeColumns = false;
            this.dgvEstadoRequision.AllowUserToResizeRows = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.dgvEstadoRequision.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoRequision.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvEstadoRequision.ColumnHeadersHeight = 4;
            this.dgvEstadoRequision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstadoRequision.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvEstadoRequision.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEstadoRequision.Location = new System.Drawing.Point(456, 12);
            this.dgvEstadoRequision.Name = "dgvEstadoRequision";
            this.dgvEstadoRequision.RowHeadersVisible = false;
            this.dgvEstadoRequision.Size = new System.Drawing.Size(808, 632);
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
            this.btnModificar.Location = new System.Drawing.Point(168, 682);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(133, 53);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblNuevaCantidad
            // 
            this.lblNuevaCantidad.AutoSize = true;
            this.lblNuevaCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNuevaCantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNuevaCantidad.Location = new System.Drawing.Point(105, 307);
            this.lblNuevaCantidad.Name = "lblNuevaCantidad";
            this.lblNuevaCantidad.Size = new System.Drawing.Size(122, 20);
            this.lblNuevaCantidad.TabIndex = 18;
            this.lblNuevaCantidad.Text = "Nueva Cantidad";
            this.lblNuevaCantidad.Visible = false;
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
            this.txtNuevaCantidad.Location = new System.Drawing.Point(62, 343);
            this.txtNuevaCantidad.Name = "txtNuevaCantidad";
            this.txtNuevaCantidad.PlaceholderText = "";
            this.txtNuevaCantidad.SelectedText = "";
            this.txtNuevaCantidad.Size = new System.Drawing.Size(200, 36);
            this.txtNuevaCantidad.TabIndex = 19;
            this.txtNuevaCantidad.Visible = false;
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
            this.txtMotivo.Location = new System.Drawing.Point(62, 343);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PlaceholderText = "";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.SelectedText = "";
            this.txtMotivo.Size = new System.Drawing.Size(200, 148);
            this.txtMotivo.TabIndex = 16;
            // 
            // FrmDetalleRequisicion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1402, 771);
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
    }
}