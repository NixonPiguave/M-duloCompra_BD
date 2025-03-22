namespace Menú
{
    partial class FrmMenuEmpleado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuEmpleado));
            this.pn1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearRequisicion = new Guna.UI2.WinForms.Guna2Button();
            this.btnReportes = new Guna.UI2.WinForms.Guna2Button();
            this.pn2 = new System.Windows.Forms.Panel();
            this.dgvEmpresa = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvOrdenesRequisicion = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pn1.SuspendLayout();
            this.pn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesRequisicion)).BeginInit();
            this.SuspendLayout();
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.Black;
            this.pn1.Controls.Add(this.label1);
            this.pn1.Controls.Add(this.btnCrearRequisicion);
            this.pn1.Controls.Add(this.btnReportes);
            this.pn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn1.Location = new System.Drawing.Point(0, 0);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(1370, 69);
            this.pn1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seccion Empleado";
            // 
            // btnCrearRequisicion
            // 
            this.btnCrearRequisicion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearRequisicion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearRequisicion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearRequisicion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearRequisicion.FillColor = System.Drawing.Color.Black;
            this.btnCrearRequisicion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearRequisicion.ForeColor = System.Drawing.Color.White;
            this.btnCrearRequisicion.HoverState.ForeColor = System.Drawing.Color.Yellow;
            this.btnCrearRequisicion.Location = new System.Drawing.Point(1006, 12);
            this.btnCrearRequisicion.Name = "btnCrearRequisicion";
            this.btnCrearRequisicion.Size = new System.Drawing.Size(177, 45);
            this.btnCrearRequisicion.TabIndex = 6;
            this.btnCrearRequisicion.Text = "Crear Requisición";
            this.btnCrearRequisicion.Click += new System.EventHandler(this.btnCrearRequisicion_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReportes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReportes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReportes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReportes.FillColor = System.Drawing.Color.Black;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.HoverState.ForeColor = System.Drawing.Color.Yellow;
            this.btnReportes.Location = new System.Drawing.Point(1189, 12);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(133, 45);
            this.btnReportes.TabIndex = 1;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // pn2
            // 
            this.pn2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pn2.Controls.Add(this.dgvEmpresa);
            this.pn2.Controls.Add(this.dgvOrdenesRequisicion);
            this.pn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn2.Location = new System.Drawing.Point(0, 69);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(1370, 663);
            this.pn2.TabIndex = 1;
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.AllowUserToAddRows = false;
            this.dgvEmpresa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEmpresa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpresa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmpresa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmpresa.Location = new System.Drawing.Point(1225, 608);
            this.dgvEmpresa.MultiSelect = false;
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.ReadOnly = true;
            this.dgvEmpresa.RowHeadersVisible = false;
            this.dgvEmpresa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmpresa.Size = new System.Drawing.Size(145, 55);
            this.dgvEmpresa.TabIndex = 10;
            this.dgvEmpresa.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpresa.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEmpresa.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEmpresa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEmpresa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEmpresa.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpresa.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmpresa.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEmpresa.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmpresa.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmpresa.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmpresa.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmpresa.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvEmpresa.ThemeStyle.ReadOnly = true;
            this.dgvEmpresa.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpresa.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmpresa.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmpresa.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEmpresa.ThemeStyle.RowsStyle.Height = 22;
            this.dgvEmpresa.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmpresa.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEmpresa.Visible = false;
            // 
            // dgvOrdenesRequisicion
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvOrdenesRequisicion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenesRequisicion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrdenesRequisicion.ColumnHeadersHeight = 4;
            this.dgvOrdenesRequisicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrdenesRequisicion.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrdenesRequisicion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrdenesRequisicion.Location = new System.Drawing.Point(30, 34);
            this.dgvOrdenesRequisicion.Name = "dgvOrdenesRequisicion";
            this.dgvOrdenesRequisicion.RowHeadersVisible = false;
            this.dgvOrdenesRequisicion.Size = new System.Drawing.Size(1325, 580);
            this.dgvOrdenesRequisicion.TabIndex = 2;
            this.dgvOrdenesRequisicion.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrdenesRequisicion.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOrdenesRequisicion.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOrdenesRequisicion.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOrdenesRequisicion.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOrdenesRequisicion.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrdenesRequisicion.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrdenesRequisicion.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvOrdenesRequisicion.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrdenesRequisicion.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrdenesRequisicion.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrdenesRequisicion.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOrdenesRequisicion.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvOrdenesRequisicion.ThemeStyle.ReadOnly = false;
            this.dgvOrdenesRequisicion.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrdenesRequisicion.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrdenesRequisicion.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrdenesRequisicion.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOrdenesRequisicion.ThemeStyle.RowsStyle.Height = 22;
            this.dgvOrdenesRequisicion.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrdenesRequisicion.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FrmMenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 732);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.pn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.pn2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesRequisicion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Panel pn2;
        private Guna.UI2.WinForms.Guna2Button btnReportes;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOrdenesRequisicion;
        private Guna.UI2.WinForms.Guna2Button btnCrearRequisicion;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmpresa;
        private System.Windows.Forms.Label label1;
    }
}

