namespace Menú
{
    partial class FrmMenuJefeDepartamental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuJefeDepartamental));
            this.pn1 = new System.Windows.Forms.Panel();
            this.btnReportes = new Guna.UI2.WinForms.Guna2Button();
            this.btnRequisicionesPendientes = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrdenCompra = new Guna.UI2.WinForms.Guna2Button();
            this.pn2 = new System.Windows.Forms.Panel();
            this.dgvOrdenesRequisicion = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pn1.SuspendLayout();
            this.pn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesRequisicion)).BeginInit();
            this.SuspendLayout();
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.Black;
            this.pn1.Controls.Add(this.label1);
            this.pn1.Controls.Add(this.btnReportes);
            this.pn1.Controls.Add(this.btnRequisicionesPendientes);
            this.pn1.Controls.Add(this.btnOrdenCompra);
            this.pn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn1.Location = new System.Drawing.Point(0, 0);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(1370, 69);
            this.pn1.TabIndex = 0;
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
            this.btnReportes.Location = new System.Drawing.Point(1222, 12);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(133, 45);
            this.btnReportes.TabIndex = 1;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnRequisicionesPendientes
            // 
            this.btnRequisicionesPendientes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRequisicionesPendientes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRequisicionesPendientes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRequisicionesPendientes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRequisicionesPendientes.FillColor = System.Drawing.Color.Black;
            this.btnRequisicionesPendientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequisicionesPendientes.ForeColor = System.Drawing.Color.White;
            this.btnRequisicionesPendientes.HoverState.ForeColor = System.Drawing.Color.Yellow;
            this.btnRequisicionesPendientes.Location = new System.Drawing.Point(810, 12);
            this.btnRequisicionesPendientes.Name = "btnRequisicionesPendientes";
            this.btnRequisicionesPendientes.Size = new System.Drawing.Size(177, 45);
            this.btnRequisicionesPendientes.TabIndex = 7;
            this.btnRequisicionesPendientes.Text = "Ver Requisiciones pendientes";
            this.btnRequisicionesPendientes.Click += new System.EventHandler(this.btnRequisicionesPendientes_Click);
            // 
            // btnOrdenCompra
            // 
            this.btnOrdenCompra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrdenCompra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrdenCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrdenCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrdenCompra.FillColor = System.Drawing.Color.Black;
            this.btnOrdenCompra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenCompra.ForeColor = System.Drawing.Color.White;
            this.btnOrdenCompra.HoverState.ForeColor = System.Drawing.Color.Yellow;
            this.btnOrdenCompra.Location = new System.Drawing.Point(1013, 12);
            this.btnOrdenCompra.Name = "btnOrdenCompra";
            this.btnOrdenCompra.Size = new System.Drawing.Size(177, 45);
            this.btnOrdenCompra.TabIndex = 7;
            this.btnOrdenCompra.Text = "Crear Orden de Compra";
            this.btnOrdenCompra.Click += new System.EventHandler(this.btnOrdenCompra_Click);
            // 
            // pn2
            // 
            this.pn2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pn2.Controls.Add(this.dgvOrdenesRequisicion);
            this.pn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn2.Location = new System.Drawing.Point(0, 69);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(1370, 663);
            this.pn2.TabIndex = 1;
            // 
            // dgvOrdenesRequisicion
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvOrdenesRequisicion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenesRequisicion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrdenesRequisicion.ColumnHeadersHeight = 4;
            this.dgvOrdenesRequisicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrdenesRequisicion.DefaultCellStyle = dataGridViewCellStyle3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seccion Jefe Departamental";
            // 
            // FrmMenuJefeDepartamental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 732);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.pn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuJefeDepartamental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuJefeDepartamental_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.pn2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesRequisicion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Panel pn2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOrdenesRequisicion;
        private Guna.UI2.WinForms.Guna2Button btnRequisicionesPendientes;
        private Guna.UI2.WinForms.Guna2Button btnReportes;
        private Guna.UI2.WinForms.Guna2Button btnOrdenCompra;
        private System.Windows.Forms.Label label1;
    }
}

