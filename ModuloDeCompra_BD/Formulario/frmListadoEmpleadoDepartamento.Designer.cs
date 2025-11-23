namespace ModuloDeCompra_BD.Formulario
{
    partial class frmListaEmpleadosDepartamentos
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
            this.btnSelecEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarEmpleadoPendiente = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvListaEmpleados = new System.Windows.Forms.DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelecEmpleado
            // 
            this.btnSelecEmpleado.BorderRadius = 10;
            this.btnSelecEmpleado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelecEmpleado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelecEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelecEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelecEmpleado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnSelecEmpleado.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnSelecEmpleado.Location = new System.Drawing.Point(238, 120);
            this.btnSelecEmpleado.Name = "btnSelecEmpleado";
            this.btnSelecEmpleado.Size = new System.Drawing.Size(120, 26);
            this.btnSelecEmpleado.TabIndex = 7;
            this.btnSelecEmpleado.Text = "Seleccionar";
            this.btnSelecEmpleado.Click += new System.EventHandler(this.btnSelecRequi_Click);
            // 
            // txtBuscarEmpleadoPendiente
            // 
            this.txtBuscarEmpleadoPendiente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarEmpleadoPendiente.DefaultText = "";
            this.txtBuscarEmpleadoPendiente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarEmpleadoPendiente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarEmpleadoPendiente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarEmpleadoPendiente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarEmpleadoPendiente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarEmpleadoPendiente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarEmpleadoPendiente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarEmpleadoPendiente.Location = new System.Drawing.Point(29, 120);
            this.txtBuscarEmpleadoPendiente.Name = "txtBuscarEmpleadoPendiente";
            this.txtBuscarEmpleadoPendiente.PlaceholderText = "";
            this.txtBuscarEmpleadoPendiente.SelectedText = "";
            this.txtBuscarEmpleadoPendiente.Size = new System.Drawing.Size(178, 26);
            this.txtBuscarEmpleadoPendiente.TabIndex = 6;
            // 
            // dgvListaEmpleados
            // 
            this.dgvListaEmpleados.AllowUserToAddRows = false;
            this.dgvListaEmpleados.AllowUserToDeleteRows = false;
            this.dgvListaEmpleados.AllowUserToResizeColumns = false;
            this.dgvListaEmpleados.AllowUserToResizeRows = false;
            this.dgvListaEmpleados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEmpleados.GridColor = System.Drawing.Color.Silver;
            this.dgvListaEmpleados.Location = new System.Drawing.Point(29, 152);
            this.dgvListaEmpleados.Name = "dgvListaEmpleados";
            this.dgvListaEmpleados.ReadOnly = true;
            this.dgvListaEmpleados.RowHeadersVisible = false;
            this.dgvListaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaEmpleados.Size = new System.Drawing.Size(548, 280);
            this.dgvListaEmpleados.TabIndex = 5;
            this.dgvListaEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaEmpleados_CellDoubleClick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(611, 89);
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(221, 34);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(194, 24);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Listado De Empleados";
            // 
            // frmListaEmpleadosDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.btnSelecEmpleado);
            this.Controls.Add(this.txtBuscarEmpleadoPendiente);
            this.Controls.Add(this.dgvListaEmpleados);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmListaEmpleadosDepartamentos";
            this.Text = "frmListaEmpleadosDepartamentos";
            this.Load += new System.EventHandler(this.frmListaEmpleadosDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSelecEmpleado;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarEmpleadoPendiente;
        private System.Windows.Forms.DataGridView dgvListaEmpleados;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}