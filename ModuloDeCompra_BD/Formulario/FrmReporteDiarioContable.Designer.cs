﻿namespace ModuloDeCompra_BD.Formulario
{
    partial class frmReporteDiarioContable
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
            this.btnDiario = new Guna.UI2.WinForms.Guna2Button();
            this.txtDiarioID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAnio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDiario = new System.Windows.Forms.Label();
            this.cmbPeriodos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCheck
            // 
            this.pnlCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlCheck.Controls.Add(this.cmbPeriodos);
            this.pnlCheck.Controls.Add(this.btnDiario);
            this.pnlCheck.Controls.Add(this.txtDiarioID);
            this.pnlCheck.Controls.Add(this.txtAnio);
            this.pnlCheck.Controls.Add(this.lblPeriodo);
            this.pnlCheck.Controls.Add(this.lblAnio);
            this.pnlCheck.Controls.Add(this.btnGenerarReporte);
            this.pnlCheck.Controls.Add(this.label2);
            this.pnlCheck.Controls.Add(this.lblDiario);
            this.pnlCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCheck.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCheck.Location = new System.Drawing.Point(0, 0);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.Size = new System.Drawing.Size(451, 332);
            this.pnlCheck.TabIndex = 0;
            // 
            // btnDiario
            // 
            this.btnDiario.Animated = true;
            this.btnDiario.AutoRoundedCorners = true;
            this.btnDiario.BorderRadius = 17;
            this.btnDiario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDiario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDiario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDiario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDiario.FillColor = System.Drawing.Color.Green;
            this.btnDiario.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiario.ForeColor = System.Drawing.Color.White;
            this.btnDiario.Location = new System.Drawing.Point(259, 267);
            this.btnDiario.Name = "btnDiario";
            this.btnDiario.Size = new System.Drawing.Size(180, 36);
            this.btnDiario.TabIndex = 14;
            this.btnDiario.Text = "Escoger Diario";
            this.btnDiario.Click += new System.EventHandler(this.btnDiario_Click);
            // 
            // txtDiarioID
            // 
            this.txtDiarioID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiarioID.DefaultText = "";
            this.txtDiarioID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiarioID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiarioID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiarioID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiarioID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiarioID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiarioID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiarioID.Location = new System.Drawing.Point(27, 267);
            this.txtDiarioID.Name = "txtDiarioID";
            this.txtDiarioID.PlaceholderText = "";
            this.txtDiarioID.SelectedText = "";
            this.txtDiarioID.Size = new System.Drawing.Size(200, 36);
            this.txtDiarioID.TabIndex = 13;
            // 
            // txtAnio
            // 
            this.txtAnio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnio.DefaultText = "";
            this.txtAnio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAnio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAnio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAnio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnio.Location = new System.Drawing.Point(27, 71);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.PlaceholderText = "";
            this.txtAnio.SelectedText = "";
            this.txtAnio.Size = new System.Drawing.Size(200, 36);
            this.txtAnio.TabIndex = 10;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(23, 130);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(67, 19);
            this.lblPeriodo.TabIndex = 9;
            this.lblPeriodo.Text = "Periodo";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(23, 39);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(38, 19);
            this.lblAnio.TabIndex = 8;
            this.lblAnio.Text = "Año";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Animated = true;
            this.btnGenerarReporte.AutoRoundedCorners = true;
            this.btnGenerarReporte.BorderRadius = 17;
            this.btnGenerarReporte.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarReporte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarReporte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerarReporte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerarReporte.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnGenerarReporte.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(259, 71);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(180, 36);
            this.btnGenerarReporte.TabIndex = 3;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reporte de Diario Contable";
            // 
            // lblDiario
            // 
            this.lblDiario.AutoSize = true;
            this.lblDiario.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiario.Location = new System.Drawing.Point(23, 228);
            this.lblDiario.Name = "lblDiario";
            this.lblDiario.Size = new System.Drawing.Size(76, 19);
            this.lblDiario.TabIndex = 1;
            this.lblDiario.Text = "Diario ID";
            // 
            // cmbPeriodos
            // 
            this.cmbPeriodos.BackColor = System.Drawing.Color.Transparent;
            this.cmbPeriodos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPeriodos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPeriodos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPeriodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPeriodos.ItemHeight = 30;
            this.cmbPeriodos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbPeriodos.Location = new System.Drawing.Point(27, 164);
            this.cmbPeriodos.Name = "cmbPeriodos";
            this.cmbPeriodos.Size = new System.Drawing.Size(200, 36);
            this.cmbPeriodos.TabIndex = 15;
            // 
            // frmReporteDiarioContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 332);
            this.Controls.Add(this.pnlCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmReporteDiarioContable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Auditoria";
            this.Load += new System.EventHandler(this.frmReporteDiarioContable_Load);
            this.pnlCheck.ResumeLayout(false);
            this.pnlCheck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDiario;
        private Guna.UI2.WinForms.Guna2Button btnGenerarReporte;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblAnio;
        private Guna.UI2.WinForms.Guna2Button btnDiario;
        private Guna.UI2.WinForms.Guna2TextBox txtDiarioID;
        public Guna.UI2.WinForms.Guna2ComboBox cmbPeriodos;
        public Guna.UI2.WinForms.Guna2TextBox txtAnio;
    }
}