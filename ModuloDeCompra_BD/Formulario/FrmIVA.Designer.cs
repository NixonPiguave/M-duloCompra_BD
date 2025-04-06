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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvIVA = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtNuevoEstadoIVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEstadoIVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNuevoEstadoIVA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEstadoIVA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNuevoValorIVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtValorIVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNuevoValorIVA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblModificarCategoria = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblIVAEscogido = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.txtIDIVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIVA)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIVA
            // 
            this.dgvIVA.AllowUserToAddRows = false;
            this.dgvIVA.AllowUserToDeleteRows = false;
            this.dgvIVA.AllowUserToResizeColumns = false;
            this.dgvIVA.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvIVA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIVA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvIVA.ColumnHeadersHeight = 20;
            this.dgvIVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIVA.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvIVA.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvIVA.Location = new System.Drawing.Point(20, 24);
            this.dgvIVA.Name = "dgvIVA";
            this.dgvIVA.RowHeadersVisible = false;
            this.dgvIVA.Size = new System.Drawing.Size(838, 225);
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
            this.dgvIVA.ThemeStyle.HeaderStyle.Height = 20;
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
            // txtNuevoEstadoIVA
            // 
            this.txtNuevoEstadoIVA.BorderRadius = 5;
            this.txtNuevoEstadoIVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNuevoEstadoIVA.DefaultText = "";
            this.txtNuevoEstadoIVA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNuevoEstadoIVA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNuevoEstadoIVA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNuevoEstadoIVA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNuevoEstadoIVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNuevoEstadoIVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNuevoEstadoIVA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNuevoEstadoIVA.Location = new System.Drawing.Point(22, 125);
            this.txtNuevoEstadoIVA.Name = "txtNuevoEstadoIVA";
            this.txtNuevoEstadoIVA.PlaceholderText = "";
            this.txtNuevoEstadoIVA.SelectedText = "";
            this.txtNuevoEstadoIVA.Size = new System.Drawing.Size(200, 36);
            this.txtNuevoEstadoIVA.TabIndex = 20;
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
            this.txtEstadoIVA.Location = new System.Drawing.Point(22, 125);
            this.txtEstadoIVA.Name = "txtEstadoIVA";
            this.txtEstadoIVA.PlaceholderText = "";
            this.txtEstadoIVA.SelectedText = "";
            this.txtEstadoIVA.Size = new System.Drawing.Size(200, 36);
            this.txtEstadoIVA.TabIndex = 19;
            // 
            // lblNuevoEstadoIVA
            // 
            this.lblNuevoEstadoIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevoEstadoIVA.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoEstadoIVA.ForeColor = System.Drawing.Color.White;
            this.lblNuevoEstadoIVA.Location = new System.Drawing.Point(45, 97);
            this.lblNuevoEstadoIVA.Name = "lblNuevoEstadoIVA";
            this.lblNuevoEstadoIVA.Size = new System.Drawing.Size(156, 24);
            this.lblNuevoEstadoIVA.TabIndex = 18;
            this.lblNuevoEstadoIVA.Text = "Nuevo Estado IVA";
            // 
            // lblEstadoIVA
            // 
            this.lblEstadoIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoIVA.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoIVA.ForeColor = System.Drawing.Color.White;
            this.lblEstadoIVA.Location = new System.Drawing.Point(44, 97);
            this.lblEstadoIVA.Name = "lblEstadoIVA";
            this.lblEstadoIVA.Size = new System.Drawing.Size(160, 24);
            this.lblEstadoIVA.TabIndex = 17;
            this.lblEstadoIVA.Text = "Añadir Estado IVA";
            // 
            // txtNuevoValorIVA
            // 
            this.txtNuevoValorIVA.BorderRadius = 5;
            this.txtNuevoValorIVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNuevoValorIVA.DefaultText = "";
            this.txtNuevoValorIVA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNuevoValorIVA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNuevoValorIVA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNuevoValorIVA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNuevoValorIVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNuevoValorIVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNuevoValorIVA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNuevoValorIVA.Location = new System.Drawing.Point(22, 51);
            this.txtNuevoValorIVA.Name = "txtNuevoValorIVA";
            this.txtNuevoValorIVA.PlaceholderText = "";
            this.txtNuevoValorIVA.SelectedText = "";
            this.txtNuevoValorIVA.Size = new System.Drawing.Size(200, 36);
            this.txtNuevoValorIVA.TabIndex = 16;
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
            this.txtValorIVA.Location = new System.Drawing.Point(22, 51);
            this.txtValorIVA.Name = "txtValorIVA";
            this.txtValorIVA.PlaceholderText = "";
            this.txtValorIVA.SelectedText = "";
            this.txtValorIVA.Size = new System.Drawing.Size(200, 36);
            this.txtValorIVA.TabIndex = 15;
            // 
            // lblNuevoValorIVA
            // 
            this.lblNuevoValorIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevoValorIVA.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoValorIVA.ForeColor = System.Drawing.Color.White;
            this.lblNuevoValorIVA.Location = new System.Drawing.Point(44, 22);
            this.lblNuevoValorIVA.Name = "lblNuevoValorIVA";
            this.lblNuevoValorIVA.Size = new System.Drawing.Size(174, 24);
            this.lblNuevoValorIVA.TabIndex = 14;
            this.lblNuevoValorIVA.Text = "Nuevo valor del IVA";
            // 
            // lblModificarCategoria
            // 
            this.lblModificarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblModificarCategoria.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarCategoria.ForeColor = System.Drawing.Color.White;
            this.lblModificarCategoria.Location = new System.Drawing.Point(44, 23);
            this.lblModificarCategoria.Name = "lblModificarCategoria";
            this.lblModificarCategoria.Size = new System.Drawing.Size(149, 24);
            this.lblModificarCategoria.TabIndex = 12;
            this.lblModificarCategoria.Text = "Añadir Valor IVA";
            // 
            // lblIVAEscogido
            // 
            this.lblIVAEscogido.AutoSize = true;
            this.lblIVAEscogido.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVAEscogido.ForeColor = System.Drawing.Color.Black;
            this.lblIVAEscogido.Location = new System.Drawing.Point(623, 159);
            this.lblIVAEscogido.Name = "lblIVAEscogido";
            this.lblIVAEscogido.Size = new System.Drawing.Size(121, 22);
            this.lblIVAEscogido.TabIndex = 11;
            this.lblIVAEscogido.Text = "IVA Escogido";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(623, 119);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(102, 22);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Añadir IVA";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnEliminar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(725, 255);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 53);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar IVA";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BorderRadius = 10;
            this.btnAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAceptar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnAceptar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(225, 68);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(133, 53);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderRadius = 10;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnAgregar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(228, 68);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 53);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BorderRadius = 10;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(12, 445);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(133, 53);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtIDIVA
            // 
            this.txtIDIVA.BorderRadius = 5;
            this.txtIDIVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDIVA.DefaultText = "";
            this.txtIDIVA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDIVA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDIVA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDIVA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDIVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDIVA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDIVA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDIVA.Location = new System.Drawing.Point(572, 183);
            this.txtIDIVA.Name = "txtIDIVA";
            this.txtIDIVA.PlaceholderText = "";
            this.txtIDIVA.SelectedText = "";
            this.txtIDIVA.Size = new System.Drawing.Size(200, 36);
            this.txtIDIVA.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.dgvIVA);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Location = new System.Drawing.Point(238, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 319);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.txtEstadoIVA);
            this.panel2.Controls.Add(this.lblEstadoIVA);
            this.panel2.Controls.Add(this.txtValorIVA);
            this.panel2.Controls.Add(this.lblModificarCategoria);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Location = new System.Drawing.Point(150, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 188);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.panel3.Controls.Add(this.txtNuevoEstadoIVA);
            this.panel3.Controls.Add(this.txtNuevoValorIVA);
            this.panel3.Controls.Add(this.lblNuevoEstadoIVA);
            this.panel3.Controls.Add(this.lblNuevoValorIVA);
            this.panel3.Controls.Add(this.btnAceptar);
            this.panel3.Location = new System.Drawing.Point(843, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 188);
            this.panel3.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(676, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "IVA";
            // 
            // FrmIVA
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1386, 663);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtIDIVA);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblIVAEscogido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIVA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIVA";
            this.Load += new System.EventHandler(this.FrmIVA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIVA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvIVA;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2TextBox txtIDIVA;
        private Guna.UI2.WinForms.Guna2Button btnAceptar;
        private Guna.UI2.WinForms.Guna2TextBox txtNuevoEstadoIVA;
        private Guna.UI2.WinForms.Guna2TextBox txtEstadoIVA;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNuevoEstadoIVA;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEstadoIVA;
        private Guna.UI2.WinForms.Guna2TextBox txtNuevoValorIVA;
        private Guna.UI2.WinForms.Guna2TextBox txtValorIVA;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNuevoValorIVA;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblModificarCategoria;
        private System.Windows.Forms.Label lblIVAEscogido;
        private System.Windows.Forms.Label lblCategoria;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}