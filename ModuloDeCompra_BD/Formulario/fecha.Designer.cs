namespace ModuloDeCompra_BD.Clases
{
    partial class fecha
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
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDesde = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnGenerarReporte = new Guna.UI2.WinForms.Guna2Button();
            this.chbGeneralFecha = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbFecha = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(237, 203);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(52, 19);
            this.lblHasta.TabIndex = 19;
            this.lblHasta.Text = "Hasta";
            this.lblHasta.Visible = false;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(12, 203);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(53, 19);
            this.lblDesde.TabIndex = 18;
            this.lblDesde.Text = "Desde";
            this.lblDesde.Visible = false;
            // 
            // dtpHasta
            // 
            this.dtpHasta.BorderRadius = 5;
            this.dtpHasta.Checked = true;
            this.dtpHasta.FillColor = System.Drawing.Color.White;
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpHasta.Location = new System.Drawing.Point(240, 222);
            this.dtpHasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHasta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(199, 36);
            this.dtpHasta.TabIndex = 17;
            this.dtpHasta.Value = new System.DateTime(2025, 3, 24, 17, 47, 5, 996);
            this.dtpHasta.Visible = false;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Animated = true;
            this.dtpDesde.BorderRadius = 5;
            this.dtpDesde.Checked = true;
            this.dtpDesde.FillColor = System.Drawing.Color.White;
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDesde.Location = new System.Drawing.Point(12, 222);
            this.dtpDesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDesde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 36);
            this.dtpDesde.TabIndex = 12;
            this.dtpDesde.Value = new System.DateTime(2025, 3, 24, 17, 44, 11, 930);
            this.dtpDesde.Visible = false;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Animated = true;
            this.btnGenerarReporte.AutoRoundedCorners = true;
            this.btnGenerarReporte.BorderRadius = 21;
            this.btnGenerarReporte.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarReporte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarReporte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerarReporte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerarReporte.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnGenerarReporte.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(120, 275);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(180, 45);
            this.btnGenerarReporte.TabIndex = 16;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.Visible = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // chbGeneralFecha
            // 
            this.chbGeneralFecha.AutoSize = true;
            this.chbGeneralFecha.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbGeneralFecha.CheckedState.BorderRadius = 0;
            this.chbGeneralFecha.CheckedState.BorderThickness = 0;
            this.chbGeneralFecha.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbGeneralFecha.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGeneralFecha.Location = new System.Drawing.Point(142, 101);
            this.chbGeneralFecha.Name = "chbGeneralFecha";
            this.chbGeneralFecha.Size = new System.Drawing.Size(125, 19);
            this.chbGeneralFecha.TabIndex = 14;
            this.chbGeneralFecha.Text = "Sin rango de fecha";
            this.chbGeneralFecha.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbGeneralFecha.UncheckedState.BorderRadius = 0;
            this.chbGeneralFecha.UncheckedState.BorderThickness = 0;
            this.chbGeneralFecha.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbGeneralFecha.CheckedChanged += new System.EventHandler(this.chbGeneralFecha_CheckedChanged);
            // 
            // chbFecha
            // 
            this.chbFecha.AutoSize = true;
            this.chbFecha.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbFecha.CheckedState.BorderRadius = 0;
            this.chbFecha.CheckedState.BorderThickness = 0;
            this.chbFecha.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbFecha.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.chbFecha.Location = new System.Drawing.Point(142, 137);
            this.chbFecha.Name = "chbFecha";
            this.chbFecha.Size = new System.Drawing.Size(110, 19);
            this.chbFecha.TabIndex = 13;
            this.chbFecha.Text = "Rango de Fecha";
            this.chbFecha.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbFecha.UncheckedState.BorderRadius = 0;
            this.chbFecha.UncheckedState.BorderThickness = 0;
            this.chbFecha.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbFecha.CheckedChanged += new System.EventHandler(this.chbFecha_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Reporte de GRN ";
            // 
            // fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 332);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.chbGeneralFecha);
            this.Controls.Add(this.chbFecha);
            this.Controls.Add(this.label2);
            this.Name = "fecha";
            this.Text = "fecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHasta;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDesde;
        private Guna.UI2.WinForms.Guna2Button btnGenerarReporte;
        private Guna.UI2.WinForms.Guna2CheckBox chbGeneralFecha;
        private Guna.UI2.WinForms.Guna2CheckBox chbFecha;
        private System.Windows.Forms.Label label2;
    }
}