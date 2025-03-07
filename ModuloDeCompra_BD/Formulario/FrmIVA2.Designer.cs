namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmIVA2
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
            this.dgvIVA = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.txtEstadoIVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEstadoIVA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.lblModificarCategoria = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtValorIVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.txtIDIVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblIVAEscogido = new System.Windows.Forms.Label();
            this.lblNuevoValorIVA = new System.Windows.Forms.Label();
            this.txtNuevoValorIVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNuevoEstadoIVA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNuevoEstadoIVA = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIVA)).BeginInit();
            this.pnlSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIVA
            // 
            this.dgvIVA.AllowUserToAddRows = false;
            this.dgvIVA.AllowUserToDeleteRows = false;
            this.dgvIVA.AllowUserToResizeColumns = false;
            this.dgvIVA.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvIVA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIVA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIVA.ColumnHeadersHeight = 4;
            this.dgvIVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIVA.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIVA.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvIVA.Location = new System.Drawing.Point(450, 12);
            this.dgvIVA.Name = "dgvIVA";
            this.dgvIVA.RowHeadersVisible = false;
            this.dgvIVA.Size = new System.Drawing.Size(808, 632);
            this.dgvIVA.TabIndex = 0;
            this.dgvIVA.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvIVA.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvIVA.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvIVA.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvIVA.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvIVA.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvIVA.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvIVA.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvIVA.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvIVA.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIVA.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvIVA.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvIVA.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvIVA.ThemeStyle.ReadOnly = false;
            this.dgvIVA.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvIVA.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvIVA.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIVA.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvIVA.ThemeStyle.RowsStyle.Height = 22;
            this.dgvIVA.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvIVA.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvIVA.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellDoubleClick);
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.pnlSubMenu.Controls.Add(this.txtNuevoEstadoIVA);
            this.pnlSubMenu.Controls.Add(this.lblNuevoEstadoIVA);
            this.pnlSubMenu.Controls.Add(this.txtNuevoValorIVA);
            this.pnlSubMenu.Controls.Add(this.lblNuevoValorIVA);
            this.pnlSubMenu.Controls.Add(this.lblIVAEscogido);
            this.pnlSubMenu.Controls.Add(this.txtEstadoIVA);
            this.pnlSubMenu.Controls.Add(this.lblEstadoIVA);
            this.pnlSubMenu.Controls.Add(this.btnEliminar);
            this.pnlSubMenu.Controls.Add(this.btnAceptar);
            this.pnlSubMenu.Controls.Add(this.lblModificarCategoria);
            this.pnlSubMenu.Controls.Add(this.txtValorIVA);
            this.pnlSubMenu.Controls.Add(this.btnAgregar);
            this.pnlSubMenu.Controls.Add(this.btnModificar);
            this.pnlSubMenu.Controls.Add(this.txtIDIVA);
            this.pnlSubMenu.Controls.Add(this.lblCategoria);
            this.pnlSubMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSubMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(319, 663);
            this.pnlSubMenu.TabIndex = 1;
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
            this.txtEstadoIVA.Location = new System.Drawing.Point(55, 338);
            this.txtEstadoIVA.Name = "txtEstadoIVA";
            this.txtEstadoIVA.PlaceholderText = "";
            this.txtEstadoIVA.SelectedText = "";
            this.txtEstadoIVA.Size = new System.Drawing.Size(200, 36);
            this.txtEstadoIVA.TabIndex = 9;
            // 
            // lblEstadoIVA
            // 
            this.lblEstadoIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoIVA.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEstadoIVA.Location = new System.Drawing.Point(92, 294);
            this.lblEstadoIVA.Name = "lblEstadoIVA";
            this.lblEstadoIVA.Size = new System.Drawing.Size(135, 22);
            this.lblEstadoIVA.TabIndex = 8;
            this.lblEstadoIVA.Text = "Añadir Estado IVA";
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
            this.btnEliminar.Location = new System.Drawing.Point(12, 591);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 53);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar Categoria";
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
            this.btnAceptar.Location = new System.Drawing.Point(12, 412);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(133, 53);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblModificarCategoria
            // 
            this.lblModificarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblModificarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarCategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.lblModificarCategoria.Location = new System.Drawing.Point(92, 206);
            this.lblModificarCategoria.Name = "lblModificarCategoria";
            this.lblModificarCategoria.Size = new System.Drawing.Size(121, 22);
            this.lblModificarCategoria.TabIndex = 5;
            this.lblModificarCategoria.Text = "Añadir Valor IVA";
            // 
            // txtValorIVA
            // 
            this.txtValorIVA.BorderRadius = 10;
            this.txtValorIVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValorIVA.DefaultText = "";
            this.txtValorIVA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValorIVA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValorIVA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValorIVA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValorIVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValorIVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValorIVA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValorIVA.Location = new System.Drawing.Point(55, 234);
            this.txtValorIVA.Name = "txtValorIVA";
            this.txtValorIVA.PlaceholderText = "";
            this.txtValorIVA.SelectedText = "";
            this.txtValorIVA.Size = new System.Drawing.Size(200, 36);
            this.txtValorIVA.TabIndex = 4;
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
            this.btnAgregar.Location = new System.Drawing.Point(12, 412);
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
            this.btnModificar.Location = new System.Drawing.Point(183, 412);
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
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCategoria.Location = new System.Drawing.Point(113, 112);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(86, 20);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Añadir IVA";
            // 
            // lblIVAEscogido
            // 
            this.lblIVAEscogido.AutoSize = true;
            this.lblIVAEscogido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblIVAEscogido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIVAEscogido.Location = new System.Drawing.Point(107, 112);
            this.lblIVAEscogido.Name = "lblIVAEscogido";
            this.lblIVAEscogido.Size = new System.Drawing.Size(106, 20);
            this.lblIVAEscogido.TabIndex = 10;
            this.lblIVAEscogido.Text = "IVA Escogido";
            // 
            // lblNuevoValorIVA
            // 
            this.lblNuevoValorIVA.AutoSize = true;
            this.lblNuevoValorIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNuevoValorIVA.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNuevoValorIVA.Location = new System.Drawing.Point(80, 206);
            this.lblNuevoValorIVA.Name = "lblNuevoValorIVA";
            this.lblNuevoValorIVA.Size = new System.Drawing.Size(147, 20);
            this.lblNuevoValorIVA.TabIndex = 11;
            this.lblNuevoValorIVA.Text = "Nuevo valor del IVA";
            // 
            // txtNuevoValorIVA
            // 
            this.txtNuevoValorIVA.BorderRadius = 10;
            this.txtNuevoValorIVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNuevoValorIVA.DefaultText = "";
            this.txtNuevoValorIVA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNuevoValorIVA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNuevoValorIVA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNuevoValorIVA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNuevoValorIVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNuevoValorIVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNuevoValorIVA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNuevoValorIVA.Location = new System.Drawing.Point(55, 234);
            this.txtNuevoValorIVA.Name = "txtNuevoValorIVA";
            this.txtNuevoValorIVA.PlaceholderText = "";
            this.txtNuevoValorIVA.SelectedText = "";
            this.txtNuevoValorIVA.Size = new System.Drawing.Size(200, 36);
            this.txtNuevoValorIVA.TabIndex = 15;
            this.txtNuevoValorIVA.Visible = false;
            // 
            // lblNuevoEstadoIVA
            // 
            this.lblNuevoEstadoIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevoEstadoIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoEstadoIVA.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNuevoEstadoIVA.Location = new System.Drawing.Point(92, 294);
            this.lblNuevoEstadoIVA.Name = "lblNuevoEstadoIVA";
            this.lblNuevoEstadoIVA.Size = new System.Drawing.Size(134, 22);
            this.lblNuevoEstadoIVA.TabIndex = 16;
            this.lblNuevoEstadoIVA.Text = "Nuevo Estado IVA";
            this.lblNuevoEstadoIVA.Visible = false;
            // 
            // txtNuevoEstadoIVA
            // 
            this.txtNuevoEstadoIVA.BorderRadius = 10;
            this.txtNuevoEstadoIVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNuevoEstadoIVA.DefaultText = "";
            this.txtNuevoEstadoIVA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNuevoEstadoIVA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNuevoEstadoIVA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNuevoEstadoIVA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNuevoEstadoIVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNuevoEstadoIVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNuevoEstadoIVA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNuevoEstadoIVA.Location = new System.Drawing.Point(55, 338);
            this.txtNuevoEstadoIVA.Name = "txtNuevoEstadoIVA";
            this.txtNuevoEstadoIVA.PlaceholderText = "";
            this.txtNuevoEstadoIVA.SelectedText = "";
            this.txtNuevoEstadoIVA.Size = new System.Drawing.Size(200, 36);
            this.txtNuevoEstadoIVA.TabIndex = 17;
            this.txtNuevoEstadoIVA.Visible = false;
            // 
            // FrmIVA2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1386, 663);
            this.Controls.Add(this.pnlSubMenu);
            this.Controls.Add(this.dgvIVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIVA2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIVA2";
            this.Load += new System.EventHandler(this.FrmIVA2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIVA)).EndInit();
            this.pnlSubMenu.ResumeLayout(false);
            this.pnlSubMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvIVA;
        private System.Windows.Forms.Panel pnlSubMenu;
        private System.Windows.Forms.Label lblCategoria;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2TextBox txtIDIVA;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblModificarCategoria;
        private Guna.UI2.WinForms.Guna2TextBox txtValorIVA;
        private Guna.UI2.WinForms.Guna2Button btnAceptar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2TextBox txtEstadoIVA;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEstadoIVA;
        private System.Windows.Forms.Label lblNuevoValorIVA;
        private System.Windows.Forms.Label lblIVAEscogido;
        private Guna.UI2.WinForms.Guna2TextBox txtNuevoEstadoIVA;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNuevoEstadoIVA;
        private Guna.UI2.WinForms.Guna2TextBox txtNuevoValorIVA;
    }
}