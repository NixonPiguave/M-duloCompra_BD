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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.bntagregar = new Guna.UI2.WinForms.Guna2Button();
            this.txtNombreDepartamento = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvDepartamento = new System.Windows.Forms.DataGridView();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(170)))), ((int)(((byte)(239)))));
            this.guna2Panel2.Controls.Add(this.btnModificar);
            this.guna2Panel2.Controls.Add(this.bntagregar);
            this.guna2Panel2.Controls.Add(this.txtNombreDepartamento);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(466, 655);
            this.guna2Panel2.TabIndex = 29;
            // 
            // btnModificar
            // 
            this.btnModificar.BorderRadius = 20;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(238, 360);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(133, 53);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // bntagregar
            // 
            this.bntagregar.BorderRadius = 20;
            this.bntagregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bntagregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bntagregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bntagregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bntagregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bntagregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bntagregar.ForeColor = System.Drawing.Color.White;
            this.bntagregar.Location = new System.Drawing.Point(60, 360);
            this.bntagregar.Name = "bntagregar";
            this.bntagregar.Size = new System.Drawing.Size(133, 53);
            this.bntagregar.TabIndex = 7;
            this.bntagregar.Text = "Agregar";
            this.bntagregar.Click += new System.EventHandler(this.bntagregar_Click);
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.BorderRadius = 10;
            this.txtNombreDepartamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreDepartamento.DefaultText = "";
            this.txtNombreDepartamento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreDepartamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreDepartamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreDepartamento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreDepartamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreDepartamento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreDepartamento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreDepartamento.Location = new System.Drawing.Point(111, 305);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.PlaceholderText = "";
            this.txtNombreDepartamento.SelectedText = "";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(210, 35);
            this.txtNombreDepartamento.TabIndex = 6;
            this.txtNombreDepartamento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombreDepartamento_KeyUp);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(120, 278);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(189, 21);
            this.guna2HtmlLabel7.TabIndex = 2;
            this.guna2HtmlLabel7.Text = "Nombre Departamento";
            // 
            // dgvDepartamento
            // 
            this.dgvDepartamento.AllowUserToAddRows = false;
            this.dgvDepartamento.AllowUserToOrderColumns = true;
            this.dgvDepartamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartamento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDepartamento.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamento.Location = new System.Drawing.Point(525, 57);
            this.dgvDepartamento.Name = "dgvDepartamento";
            this.dgvDepartamento.RowTemplate.Height = 18;
            this.dgvDepartamento.Size = new System.Drawing.Size(579, 535);
            this.dgvDepartamento.TabIndex = 30;
            this.dgvDepartamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartamento_CellDoubleClick);
            // 
            // FrmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 655);
            this.Controls.Add(this.dgvDepartamento);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDepartamentos";
            this.Text = "FrmDepartamentos";
            this.Load += new System.EventHandler(this.FrmDepartamentos_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button bntagregar;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreDepartamento;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private System.Windows.Forms.DataGridView dgvDepartamento;
    }
}