namespace ModuloDeCompra_BD.Formulario
{
    partial class frmReporteAuditoria
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
            this.pnlCheck = new Guna.UI2.WinForms.Guna2Panel();
            this.cbUsuarios = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new Guna.UI2.WinForms.Guna2Button();
            this.chbGeneral = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbUsuario = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlCheck.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCheck
            // 
            this.pnlCheck.Controls.Add(this.guna2Panel2);
            this.pnlCheck.Controls.Add(this.btnGenerarReporte);
            this.pnlCheck.Controls.Add(this.label2);
            this.pnlCheck.Controls.Add(this.lblUsuario);
            this.pnlCheck.Controls.Add(this.cbUsuarios);
            this.pnlCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCheck.Location = new System.Drawing.Point(0, 0);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.Size = new System.Drawing.Size(402, 241);
            this.pnlCheck.TabIndex = 0;
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.cbUsuarios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuarios.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUsuarios.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbUsuarios.ItemHeight = 30;
            this.cbUsuarios.Location = new System.Drawing.Point(32, 127);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(205, 36);
            this.cbUsuarios.TabIndex = 0;
            this.cbUsuarios.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(32, 111);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reporte de auditoria por usuario";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Animated = true;
            this.btnGenerarReporte.AutoRoundedCorners = true;
            this.btnGenerarReporte.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarReporte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarReporte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerarReporte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerarReporte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(114, 169);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(180, 45);
            this.btnGenerarReporte.TabIndex = 3;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.Visible = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // chbGeneral
            // 
            this.chbGeneral.AutoSize = true;
            this.chbGeneral.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbGeneral.CheckedState.BorderRadius = 0;
            this.chbGeneral.CheckedState.BorderThickness = 0;
            this.chbGeneral.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbGeneral.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGeneral.Location = new System.Drawing.Point(3, 12);
            this.chbGeneral.Name = "chbGeneral";
            this.chbGeneral.Size = new System.Drawing.Size(109, 19);
            this.chbGeneral.TabIndex = 4;
            this.chbGeneral.Text = "Reporte general";
            this.chbGeneral.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbGeneral.UncheckedState.BorderRadius = 0;
            this.chbGeneral.UncheckedState.BorderThickness = 0;
            this.chbGeneral.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbGeneral.CheckedChanged += new System.EventHandler(this.chbGeneral_CheckedChanged);
            // 
            // chbUsuario
            // 
            this.chbUsuario.AutoSize = true;
            this.chbUsuario.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbUsuario.CheckedState.BorderRadius = 0;
            this.chbUsuario.CheckedState.BorderThickness = 0;
            this.chbUsuario.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUsuario.Location = new System.Drawing.Point(3, 35);
            this.chbUsuario.Name = "chbUsuario";
            this.chbUsuario.Size = new System.Drawing.Size(130, 19);
            this.chbUsuario.TabIndex = 5;
            this.chbUsuario.Text = "Reporte por usuario";
            this.chbUsuario.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbUsuario.UncheckedState.BorderRadius = 0;
            this.chbUsuario.UncheckedState.BorderThickness = 0;
            this.chbUsuario.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbUsuario.CheckedChanged += new System.EventHandler(this.chbUsuario_CheckedChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.chbGeneral);
            this.guna2Panel2.Controls.Add(this.chbUsuario);
            this.guna2Panel2.Location = new System.Drawing.Point(32, 42);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(150, 66);
            this.guna2Panel2.TabIndex = 6;
            // 
            // frmReporteAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 241);
            this.Controls.Add(this.pnlCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmReporteAuditoria";
            this.Text = "frmReporteAuditoria";
            this.Load += new System.EventHandler(this.frmReporteAuditoria_Load);
            this.pnlCheck.ResumeLayout(false);
            this.pnlCheck.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private Guna.UI2.WinForms.Guna2ComboBox cbUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnGenerarReporte;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CheckBox chbGeneral;
        private Guna.UI2.WinForms.Guna2CheckBox chbUsuario;
    }
}