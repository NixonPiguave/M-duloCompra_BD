namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmIVA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCategoria = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.lblValorIVA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAgregarValorIVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.txtIDIVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIDIVA = new System.Windows.Forms.Label();
            this.lblEstadoIva = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEstadoIVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtModificarEstadoIVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblModificarEstadoIVA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblModificarIDIVA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblModificarValorIVA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtModificarIDIVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtModificarValorIVA = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.pnlSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.AllowUserToResizeColumns = false;
            this.dgvCategoria.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCategoria.ColumnHeadersHeight = 4;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategoria.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCategoria.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCategoria.Location = new System.Drawing.Point(450, 12);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.RowHeadersVisible = false;
            this.dgvCategoria.Size = new System.Drawing.Size(808, 632);
            this.dgvCategoria.TabIndex = 0;
            this.dgvCategoria.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCategoria.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCategoria.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCategoria.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCategoria.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCategoria.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCategoria.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCategoria.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCategoria.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCategoria.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCategoria.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCategoria.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCategoria.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvCategoria.ThemeStyle.ReadOnly = false;
            this.dgvCategoria.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCategoria.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategoria.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCategoria.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCategoria.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCategoria.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCategoria.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellDoubleClick);
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.pnlSubMenu.Controls.Add(this.txtModificarValorIVA);
            this.pnlSubMenu.Controls.Add(this.txtModificarIDIVA);
            this.pnlSubMenu.Controls.Add(this.lblModificarValorIVA);
            this.pnlSubMenu.Controls.Add(this.lblModificarIDIVA);
            this.pnlSubMenu.Controls.Add(this.lblModificarEstadoIVA);
            this.pnlSubMenu.Controls.Add(this.txtModificarEstadoIVA);
            this.pnlSubMenu.Controls.Add(this.txtEstadoIVA);
            this.pnlSubMenu.Controls.Add(this.lblEstadoIva);
            this.pnlSubMenu.Controls.Add(this.btnEliminar);
            this.pnlSubMenu.Controls.Add(this.btnAceptar);
            this.pnlSubMenu.Controls.Add(this.lblValorIVA);
            this.pnlSubMenu.Controls.Add(this.txtAgregarValorIVA);
            this.pnlSubMenu.Controls.Add(this.btnAgregar);
            this.pnlSubMenu.Controls.Add(this.btnModificar);
            this.pnlSubMenu.Controls.Add(this.txtIDIVA);
            this.pnlSubMenu.Controls.Add(this.lblIDIVA);
            this.pnlSubMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSubMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(319, 663);
            this.pnlSubMenu.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.FillColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(97, 591);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 53);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar IVA";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(12, 519);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(133, 53);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblValorIVA
            // 
            this.lblValorIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblValorIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorIVA.ForeColor = System.Drawing.SystemColors.Control;
            this.lblValorIVA.Location = new System.Drawing.Point(120, 206);
            this.lblValorIVA.Name = "lblValorIVA";
            this.lblValorIVA.Size = new System.Drawing.Size(71, 22);
            this.lblValorIVA.TabIndex = 5;
            this.lblValorIVA.Text = "Valor IVA";
            // 
            // txtAgregarValorIVA
            // 
            this.txtAgregarValorIVA.BorderRadius = 10;
            this.txtAgregarValorIVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAgregarValorIVA.DefaultText = "";
            this.txtAgregarValorIVA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAgregarValorIVA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAgregarValorIVA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAgregarValorIVA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAgregarValorIVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAgregarValorIVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAgregarValorIVA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAgregarValorIVA.Location = new System.Drawing.Point(55, 234);
            this.txtAgregarValorIVA.Name = "txtAgregarValorIVA";
            this.txtAgregarValorIVA.PlaceholderText = "";
            this.txtAgregarValorIVA.SelectedText = "";
            this.txtAgregarValorIVA.Size = new System.Drawing.Size(200, 36);
            this.txtAgregarValorIVA.TabIndex = 4;
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
            this.btnAgregar.Location = new System.Drawing.Point(12, 408);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 53);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BorderRadius = 20;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(183, 408);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(133, 53);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtIDIVA
            // 
            this.txtIDIVA.BorderRadius = 10;
            this.txtIDIVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDIVA.DefaultText = "";
            this.txtIDIVA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDIVA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDIVA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDIVA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDIVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDIVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDIVA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDIVA.Location = new System.Drawing.Point(55, 148);
            this.txtIDIVA.Name = "txtIDIVA";
            this.txtIDIVA.PlaceholderText = "";
            this.txtIDIVA.SelectedText = "";
            this.txtIDIVA.Size = new System.Drawing.Size(200, 36);
            this.txtIDIVA.TabIndex = 1;
            // 
            // lblIDIVA
            // 
            this.lblIDIVA.AutoSize = true;
            this.lblIDIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblIDIVA.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIDIVA.Location = new System.Drawing.Point(134, 115);
            this.lblIDIVA.Name = "lblIDIVA";
            this.lblIDIVA.Size = new System.Drawing.Size(57, 20);
            this.lblIDIVA.TabIndex = 0;
            this.lblIDIVA.Text = "ID IVA";
            // 
            // lblEstadoIva
            // 
            this.lblEstadoIva.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoIva.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEstadoIva.Location = new System.Drawing.Point(112, 302);
            this.lblEstadoIva.Name = "lblEstadoIva";
            this.lblEstadoIva.Size = new System.Drawing.Size(85, 22);
            this.lblEstadoIva.TabIndex = 8;
            this.lblEstadoIva.Text = "Estado IVA";
            // 
            // txtEstadoIVA
            // 
            this.txtEstadoIVA.BorderRadius = 10;
            this.txtEstadoIVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstadoIVA.DefaultText = "";
            this.txtEstadoIVA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEstadoIVA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEstadoIVA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstadoIVA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstadoIVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstadoIVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEstadoIVA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstadoIVA.Location = new System.Drawing.Point(55, 334);
            this.txtEstadoIVA.Name = "txtEstadoIVA";
            this.txtEstadoIVA.PlaceholderText = "";
            this.txtEstadoIVA.SelectedText = "";
            this.txtEstadoIVA.Size = new System.Drawing.Size(200, 36);
            this.txtEstadoIVA.TabIndex = 9;
            // 
            // txtModificarEstadoIVA
            // 
            this.txtModificarEstadoIVA.BorderRadius = 10;
            this.txtModificarEstadoIVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModificarEstadoIVA.DefaultText = "";
            this.txtModificarEstadoIVA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtModificarEstadoIVA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtModificarEstadoIVA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModificarEstadoIVA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModificarEstadoIVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModificarEstadoIVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtModificarEstadoIVA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModificarEstadoIVA.Location = new System.Drawing.Point(55, 425);
            this.txtModificarEstadoIVA.Name = "txtModificarEstadoIVA";
            this.txtModificarEstadoIVA.PlaceholderText = "";
            this.txtModificarEstadoIVA.SelectedText = "";
            this.txtModificarEstadoIVA.Size = new System.Drawing.Size(200, 36);
            this.txtModificarEstadoIVA.TabIndex = 10;
            this.txtModificarEstadoIVA.Visible = false;
            // 
            // lblModificarEstadoIVA
            // 
            this.lblModificarEstadoIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblModificarEstadoIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarEstadoIVA.ForeColor = System.Drawing.SystemColors.Control;
            this.lblModificarEstadoIVA.Location = new System.Drawing.Point(83, 397);
            this.lblModificarEstadoIVA.Name = "lblModificarEstadoIVA";
            this.lblModificarEstadoIVA.Size = new System.Drawing.Size(153, 22);
            this.lblModificarEstadoIVA.TabIndex = 11;
            this.lblModificarEstadoIVA.Text = "Modificar Estado IVA";
            this.lblModificarEstadoIVA.Visible = false;
            // 
            // lblModificarIDIVA
            // 
            this.lblModificarIDIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblModificarIDIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarIDIVA.ForeColor = System.Drawing.SystemColors.Control;
            this.lblModificarIDIVA.Location = new System.Drawing.Point(97, 206);
            this.lblModificarIDIVA.Name = "lblModificarIDIVA";
            this.lblModificarIDIVA.Size = new System.Drawing.Size(119, 22);
            this.lblModificarIDIVA.TabIndex = 12;
            this.lblModificarIDIVA.Text = "Modificar ID IVA";
            this.lblModificarIDIVA.Visible = false;
            // 
            // lblModificarValorIVA
            // 
            this.lblModificarValorIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblModificarValorIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarValorIVA.ForeColor = System.Drawing.SystemColors.Control;
            this.lblModificarValorIVA.Location = new System.Drawing.Point(83, 302);
            this.lblModificarValorIVA.Name = "lblModificarValorIVA";
            this.lblModificarValorIVA.Size = new System.Drawing.Size(139, 22);
            this.lblModificarValorIVA.TabIndex = 12;
            this.lblModificarValorIVA.Text = "Modificar Valor IVA";
            this.lblModificarValorIVA.Visible = false;
            // 
            // txtModificarIDIVA
            // 
            this.txtModificarIDIVA.BorderRadius = 10;
            this.txtModificarIDIVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModificarIDIVA.DefaultText = "";
            this.txtModificarIDIVA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtModificarIDIVA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtModificarIDIVA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModificarIDIVA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModificarIDIVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModificarIDIVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtModificarIDIVA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModificarIDIVA.Location = new System.Drawing.Point(55, 234);
            this.txtModificarIDIVA.Name = "txtModificarIDIVA";
            this.txtModificarIDIVA.PlaceholderText = "";
            this.txtModificarIDIVA.SelectedText = "";
            this.txtModificarIDIVA.Size = new System.Drawing.Size(200, 36);
            this.txtModificarIDIVA.TabIndex = 13;
            // 
            // txtModificarValorIVA
            // 
            this.txtModificarValorIVA.BorderRadius = 10;
            this.txtModificarValorIVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModificarValorIVA.DefaultText = "";
            this.txtModificarValorIVA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtModificarValorIVA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtModificarValorIVA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModificarValorIVA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModificarValorIVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModificarValorIVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtModificarValorIVA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModificarValorIVA.Location = new System.Drawing.Point(55, 334);
            this.txtModificarValorIVA.Name = "txtModificarValorIVA";
            this.txtModificarValorIVA.PlaceholderText = "";
            this.txtModificarValorIVA.SelectedText = "";
            this.txtModificarValorIVA.Size = new System.Drawing.Size(200, 36);
            this.txtModificarValorIVA.TabIndex = 14;
            // 
            // FrmIVA
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1386, 663);
            this.Controls.Add(this.pnlSubMenu);
            this.Controls.Add(this.dgvCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIVA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIVA";
            this.Load += new System.EventHandler(this.FrmIVA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.pnlSubMenu.ResumeLayout(false);
            this.pnlSubMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvCategoria;
        private System.Windows.Forms.Panel pnlSubMenu;
        private System.Windows.Forms.Label lblIDIVA;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2TextBox txtIDIVA;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblValorIVA;
        private Guna.UI2.WinForms.Guna2TextBox txtAgregarValorIVA;
        private Guna.UI2.WinForms.Guna2Button btnAceptar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblModificarEstadoIVA;
        private Guna.UI2.WinForms.Guna2TextBox txtModificarEstadoIVA;
        private Guna.UI2.WinForms.Guna2TextBox txtEstadoIVA;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEstadoIva;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblModificarValorIVA;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblModificarIDIVA;
        private Guna.UI2.WinForms.Guna2TextBox txtModificarValorIVA;
        private Guna.UI2.WinForms.Guna2TextBox txtModificarIDIVA;
    }
}