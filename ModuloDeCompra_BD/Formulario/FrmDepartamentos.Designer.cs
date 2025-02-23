namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmDepartamentos
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
            this.btnagregar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvDepartamento = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtnombredepartamento = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.cmbIDdepartamento = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbnombredepartamento = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).BeginInit();
            this.SuspendLayout();
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
            this.btnagregar.Location = new System.Drawing.Point(190, 139);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(151, 30);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "agregar";
            // 
            // dgvDepartamento
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDepartamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepartamento.BackgroundColor = System.Drawing.Color.DarkGray;
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
            this.dgvDepartamento.Location = new System.Drawing.Point(606, 51);
            this.dgvDepartamento.Name = "dgvDepartamento";
            this.dgvDepartamento.RowHeadersVisible = false;
            this.dgvDepartamento.Size = new System.Drawing.Size(515, 536);
            this.dgvDepartamento.TabIndex = 1;
            this.dgvDepartamento.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepartamento.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDepartamento.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDepartamento.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDepartamento.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDepartamento.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
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
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(199, 76);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(129, 15);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Nombre Departamento";
            // 
            // txtnombredepartamento
            // 
            this.txtnombredepartamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombredepartamento.DefaultText = "";
            this.txtnombredepartamento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnombredepartamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnombredepartamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombredepartamento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombredepartamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombredepartamento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnombredepartamento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombredepartamento.Location = new System.Drawing.Point(166, 97);
            this.txtnombredepartamento.Name = "txtnombredepartamento";
            this.txtnombredepartamento.PlaceholderText = "";
            this.txtnombredepartamento.SelectedText = "";
            this.txtnombredepartamento.Size = new System.Drawing.Size(200, 36);
            this.txtnombredepartamento.TabIndex = 3;
            this.txtnombredepartamento.TextChanged += new System.EventHandler(this.txtnombredepartamento_TextChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(288, 249);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(129, 15);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "Nombre Departamento";
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscar.FillColor = System.Drawing.Color.SlateBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(190, 312);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(151, 30);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            // 
            // cmbIDdepartamento
            // 
            this.cmbIDdepartamento.BackColor = System.Drawing.Color.Transparent;
            this.cmbIDdepartamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIDdepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDdepartamento.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIDdepartamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIDdepartamento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIDdepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbIDdepartamento.ItemHeight = 30;
            this.cmbIDdepartamento.Location = new System.Drawing.Point(84, 270);
            this.cmbIDdepartamento.Name = "cmbIDdepartamento";
            this.cmbIDdepartamento.Size = new System.Drawing.Size(174, 36);
            this.cmbIDdepartamento.TabIndex = 6;
            // 
            // cmbnombredepartamento
            // 
            this.cmbnombredepartamento.BackColor = System.Drawing.Color.Transparent;
            this.cmbnombredepartamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbnombredepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbnombredepartamento.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbnombredepartamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbnombredepartamento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbnombredepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbnombredepartamento.ItemHeight = 30;
            this.cmbnombredepartamento.Location = new System.Drawing.Point(264, 270);
            this.cmbnombredepartamento.Name = "cmbnombredepartamento";
            this.cmbnombredepartamento.Size = new System.Drawing.Size(174, 36);
            this.cmbnombredepartamento.TabIndex = 7;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(108, 249);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(99, 15);
            this.guna2HtmlLabel3.TabIndex = 8;
            this.guna2HtmlLabel3.Text = "ID  Departamento";
            // 
            // FrmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 655);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.cmbnombredepartamento);
            this.Controls.Add(this.cmbIDdepartamento);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtnombredepartamento);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dgvDepartamento);
            this.Controls.Add(this.btnagregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDepartamentos";
            this.Text = "FrmDepartamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnagregar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDepartamento;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtnombredepartamento;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbIDdepartamento;
        private Guna.UI2.WinForms.Guna2ComboBox cmbnombredepartamento;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}