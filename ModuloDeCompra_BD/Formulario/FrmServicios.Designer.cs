namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnagregar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtnombreservicio = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtServicio = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBuscarservicio = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbIDservicio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbnombreservicio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btneliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btneditar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvDepartamento = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 95);
            this.label1.TabIndex = 16;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnagregar
            // 
            this.btnagregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnagregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnagregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnagregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnagregar.FillColor = System.Drawing.Color.SlateBlue;
            this.btnagregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(223, 182);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(151, 30);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "agregar";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(86, 93);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(96, 15);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Nombre Servicio";
            // 
            // txtnombreservicio
            // 
            this.txtnombreservicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombreservicio.DefaultText = "";
            this.txtnombreservicio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnombreservicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnombreservicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombreservicio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombreservicio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombreservicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnombreservicio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombreservicio.Location = new System.Drawing.Point(43, 114);
            this.txtnombreservicio.Name = "txtnombreservicio";
            this.txtnombreservicio.PlaceholderText = "";
            this.txtnombreservicio.SelectedText = "";
            this.txtnombreservicio.Size = new System.Drawing.Size(200, 36);
            this.txtnombreservicio.TabIndex = 6;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(336, 93);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(87, 15);
            this.guna2HtmlLabel2.TabIndex = 7;
            this.guna2HtmlLabel2.Text = "Precio servicio";
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
            this.txtServicio.Location = new System.Drawing.Point(284, 114);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.PlaceholderText = "";
            this.txtServicio.SelectedText = "";
            this.txtServicio.Size = new System.Drawing.Size(200, 36);
            this.txtServicio.TabIndex = 8;
            // 
            // btnBuscarservicio
            // 
            this.btnBuscarservicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarservicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarservicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarservicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarservicio.FillColor = System.Drawing.Color.SlateBlue;
            this.btnBuscarservicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarservicio.ForeColor = System.Drawing.Color.White;
            this.btnBuscarservicio.Location = new System.Drawing.Point(755, 231);
            this.btnBuscarservicio.Name = "btnBuscarservicio";
            this.btnBuscarservicio.Size = new System.Drawing.Size(151, 30);
            this.btnBuscarservicio.TabIndex = 9;
            this.btnBuscarservicio.Text = "Buscar";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(853, 168);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(96, 15);
            this.guna2HtmlLabel4.TabIndex = 10;
            this.guna2HtmlLabel4.Text = "Nombre Servicio";
            // 
            // cmbIDservicio
            // 
            this.cmbIDservicio.BackColor = System.Drawing.Color.Transparent;
            this.cmbIDservicio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIDservicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDservicio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIDservicio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIDservicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIDservicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbIDservicio.ItemHeight = 30;
            this.cmbIDservicio.Location = new System.Drawing.Point(649, 189);
            this.cmbIDservicio.Name = "cmbIDservicio";
            this.cmbIDservicio.Size = new System.Drawing.Size(174, 36);
            this.cmbIDservicio.TabIndex = 11;
            // 
            // cmbnombreservicio
            // 
            this.cmbnombreservicio.BackColor = System.Drawing.Color.Transparent;
            this.cmbnombreservicio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbnombreservicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbnombreservicio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbnombreservicio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbnombreservicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbnombreservicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbnombreservicio.ItemHeight = 30;
            this.cmbnombreservicio.Location = new System.Drawing.Point(829, 189);
            this.cmbnombreservicio.Name = "cmbnombreservicio";
            this.cmbnombreservicio.Size = new System.Drawing.Size(174, 36);
            this.cmbnombreservicio.TabIndex = 12;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(673, 168);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(66, 15);
            this.guna2HtmlLabel3.TabIndex = 13;
            this.guna2HtmlLabel3.Text = "ID  Servicio";
            // 
            // btneliminar
            // 
            this.btneliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btneliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btneliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btneliminar.FillColor = System.Drawing.Color.Crimson;
            this.btneliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(394, 182);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(151, 30);
            this.btneliminar.TabIndex = 14;
            this.btneliminar.Text = "Eliminar";
            // 
            // btneditar
            // 
            this.btneditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btneditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btneditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btneditar.FillColor = System.Drawing.Color.LimeGreen;
            this.btneditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Location = new System.Drawing.Point(43, 182);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(151, 30);
            this.btneditar.TabIndex = 15;
            this.btneditar.Text = "editar";
            // 
            // dgvDepartamento
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDepartamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDepartamento.ColumnHeadersHeight = 4;
            this.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartamento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDepartamento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepartamento.Location = new System.Drawing.Point(32, 283);
            this.dgvDepartamento.Name = "dgvDepartamento";
            this.dgvDepartamento.RowHeadersVisible = false;
            this.dgvDepartamento.Size = new System.Drawing.Size(1086, 344);
            this.dgvDepartamento.TabIndex = 2;
            this.dgvDepartamento.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepartamento.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDepartamento.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDepartamento.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDepartamento.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDepartamento.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepartamento.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepartamento.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDepartamento.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDepartamento.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDepartamento.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDepartamento.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDepartamento.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDepartamento.ThemeStyle.ReadOnly = false;
            this.dgvDepartamento.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepartamento.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDepartamento.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDepartamento.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDepartamento.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDepartamento.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepartamento.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FrmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.cmbnombreservicio);
            this.Controls.Add(this.cmbIDservicio);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.btnBuscarservicio);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtnombreservicio);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvDepartamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmServicios";
            this.Text = "FrmServicios";
            this.Load += new System.EventHandler(this.FrmServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnagregar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtnombreservicio;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtServicio;
        private Guna.UI2.WinForms.Guna2Button btnBuscarservicio;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbIDservicio;
        private Guna.UI2.WinForms.Guna2ComboBox cmbnombreservicio;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button btneliminar;
        private Guna.UI2.WinForms.Guna2Button btneditar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDepartamento;
    }
}