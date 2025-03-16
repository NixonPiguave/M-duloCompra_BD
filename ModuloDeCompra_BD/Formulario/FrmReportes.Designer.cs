namespace reporte
{
    partial class FrmReportes
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
            this.btnreport = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnreport
            // 
            this.btnreport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnreport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnreport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnreport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnreport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnreport.ForeColor = System.Drawing.Color.White;
            this.btnreport.Location = new System.Drawing.Point(475, 192);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(342, 214);
            this.btnreport.TabIndex = 0;
            this.btnreport.Text = "El Reporte";
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 666);
            this.Controls.Add(this.btnreport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportes";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnreport;
    }
}

