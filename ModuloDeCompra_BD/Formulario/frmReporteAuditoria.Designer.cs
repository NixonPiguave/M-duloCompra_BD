﻿namespace ModuloDeCompra_BD.Formulario
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
            this.pnlFecha = new Guna.UI2.WinForms.Guna2Panel();
            this.chbGeneralFecha = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbFecha = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDesde = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.chbGeneral = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbUsuario = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnGenerarReporte = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cbUsuarios = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlCheck.SuspendLayout();
            this.pnlFecha.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCheck
            // 
            this.pnlCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlCheck.Controls.Add(this.pnlFecha);
            this.pnlCheck.Controls.Add(this.label1);
            this.pnlCheck.Controls.Add(this.lblHasta);
            this.pnlCheck.Controls.Add(this.lblDesde);
            this.pnlCheck.Controls.Add(this.dtpHasta);
            this.pnlCheck.Controls.Add(this.dtpDesde);
            this.pnlCheck.Controls.Add(this.guna2Panel2);
            this.pnlCheck.Controls.Add(this.btnGenerarReporte);
            this.pnlCheck.Controls.Add(this.label2);
            this.pnlCheck.Controls.Add(this.lblUsuario);
            this.pnlCheck.Controls.Add(this.cbUsuarios);
            this.pnlCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCheck.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCheck.Location = new System.Drawing.Point(0, 0);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.Size = new System.Drawing.Size(451, 332);
            this.pnlCheck.TabIndex = 0;
            // 
            // pnlFecha
            // 
            this.pnlFecha.Controls.Add(this.chbGeneralFecha);
            this.pnlFecha.Controls.Add(this.chbFecha);
            this.pnlFecha.Location = new System.Drawing.Point(207, 76);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(139, 66);
            this.pnlFecha.TabIndex = 12;
            this.pnlFecha.Visible = false;
            // 
            // chbGeneralFecha
            // 
            this.chbGeneralFecha.AutoSize = true;
            this.chbGeneralFecha.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbGeneralFecha.CheckedState.BorderRadius = 0;
            this.chbGeneralFecha.CheckedState.BorderThickness = 0;
            this.chbGeneralFecha.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbGeneralFecha.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGeneralFecha.Location = new System.Drawing.Point(12, 12);
            this.chbGeneralFecha.Name = "chbGeneralFecha";
            this.chbGeneralFecha.Size = new System.Drawing.Size(125, 19);
            this.chbGeneralFecha.TabIndex = 1;
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
            this.chbFecha.Location = new System.Drawing.Point(12, 37);
            this.chbFecha.Name = "chbFecha";
            this.chbFecha.Size = new System.Drawing.Size(110, 19);
            this.chbFecha.TabIndex = 0;
            this.chbFecha.Text = "Rango de Fecha";
            this.chbFecha.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbFecha.UncheckedState.BorderRadius = 0;
            this.chbFecha.UncheckedState.BorderThickness = 0;
            this.chbFecha.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbFecha.CheckedChanged += new System.EventHandler(this.chbFecha_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Movimientos de usuarios";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(238, 200);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(52, 19);
            this.lblHasta.TabIndex = 9;
            this.lblHasta.Text = "Hasta";
            this.lblHasta.Visible = false;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(13, 200);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(53, 19);
            this.lblDesde.TabIndex = 8;
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
            this.dtpHasta.Location = new System.Drawing.Point(241, 219);
            this.dtpHasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHasta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(199, 36);
            this.dtpHasta.TabIndex = 7;
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
            this.dtpDesde.Location = new System.Drawing.Point(13, 219);
            this.dtpDesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDesde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 36);
            this.dtpDesde.TabIndex = 0;
            this.dtpDesde.Value = new System.DateTime(2025, 3, 24, 17, 44, 11, 930);
            this.dtpDesde.Visible = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.chbGeneral);
            this.guna2Panel2.Controls.Add(this.chbUsuario);
            this.guna2Panel2.Location = new System.Drawing.Point(33, 76);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(150, 66);
            this.guna2Panel2.TabIndex = 6;
            // 
            // chbGeneral
            // 
            this.chbGeneral.AutoSize = true;
            this.chbGeneral.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbGeneral.CheckedState.BorderRadius = 0;
            this.chbGeneral.CheckedState.BorderThickness = 0;
            this.chbGeneral.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbGeneral.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGeneral.Location = new System.Drawing.Point(3, 12);
            this.chbGeneral.Name = "chbGeneral";
            this.chbGeneral.Size = new System.Drawing.Size(112, 19);
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
            this.chbUsuario.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUsuario.Location = new System.Drawing.Point(3, 35);
            this.chbUsuario.Name = "chbUsuario";
            this.chbUsuario.Size = new System.Drawing.Size(136, 19);
            this.chbUsuario.TabIndex = 5;
            this.chbUsuario.Text = "Reporte por usuario";
            this.chbUsuario.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbUsuario.UncheckedState.BorderRadius = 0;
            this.chbUsuario.UncheckedState.BorderThickness = 0;
            this.chbUsuario.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbUsuario.CheckedChanged += new System.EventHandler(this.chbUsuario_CheckedChanged);
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
            this.btnGenerarReporte.Location = new System.Drawing.Point(121, 272);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(180, 45);
            this.btnGenerarReporte.TabIndex = 3;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.Visible = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reporte de auditoria ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(33, 145);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 19);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Visible = false;
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.cbUsuarios.BorderRadius = 5;
            this.cbUsuarios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuarios.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUsuarios.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbUsuarios.ItemHeight = 30;
            this.cbUsuarios.Location = new System.Drawing.Point(33, 161);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(205, 36);
            this.cbUsuarios.TabIndex = 0;
            this.cbUsuarios.Visible = false;
            // 
            // frmReporteAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 332);
            this.Controls.Add(this.pnlCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmReporteAuditoria";
            this.Text = "Reporte Auditoria";
            this.Load += new System.EventHandler(this.frmReporteAuditoria_Load);
            this.pnlCheck.ResumeLayout(false);
            this.pnlCheck.PerformLayout();
            this.pnlFecha.ResumeLayout(false);
            this.pnlFecha.PerformLayout();
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
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHasta;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnlFecha;
        private Guna.UI2.WinForms.Guna2CheckBox chbGeneralFecha;
        private Guna.UI2.WinForms.Guna2CheckBox chbFecha;
    }
}