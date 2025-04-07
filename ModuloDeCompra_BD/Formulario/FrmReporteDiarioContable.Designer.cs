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
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cbUsuarios = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtAnio = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPeriodo = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCheck
            // 
            this.pnlCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlCheck.Controls.Add(this.txtPeriodo);
            this.pnlCheck.Controls.Add(this.txtAnio);
            this.pnlCheck.Controls.Add(this.lblPeriodo);
            this.pnlCheck.Controls.Add(this.lblAnio);
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
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(34, 131);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(67, 19);
            this.lblPeriodo.TabIndex = 9;
            this.lblPeriodo.Text = "Periodo";
            this.lblPeriodo.Click += new System.EventHandler(this.lblHasta_Click);
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(33, 39);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(38, 19);
            this.lblAnio.TabIndex = 8;
            this.lblAnio.Text = "Año";
            this.lblAnio.Click += new System.EventHandler(this.lblDesde_Click);
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
            this.btnGenerarReporte.Location = new System.Drawing.Point(259, 267);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(180, 36);
            this.btnGenerarReporte.TabIndex = 3;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.Visible = false;
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(37, 245);
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
            this.cbUsuarios.Location = new System.Drawing.Point(37, 267);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(205, 36);
            this.cbUsuarios.TabIndex = 0;
            this.cbUsuarios.Visible = false;
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
            this.txtAnio.Location = new System.Drawing.Point(37, 73);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.PlaceholderText = "";
            this.txtAnio.SelectedText = "";
            this.txtAnio.Size = new System.Drawing.Size(200, 36);
            this.txtAnio.TabIndex = 10;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPeriodo.DefaultText = "";
            this.txtPeriodo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPeriodo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPeriodo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPeriodo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPeriodo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPeriodo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPeriodo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPeriodo.Location = new System.Drawing.Point(37, 175);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.PlaceholderText = "";
            this.txtPeriodo.SelectedText = "";
            this.txtPeriodo.Size = new System.Drawing.Size(200, 36);
            this.txtPeriodo.TabIndex = 11;
            // 
            // frmReporteDiarioContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 332);
            this.Controls.Add(this.pnlCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmReporteDiarioContable";
            this.Text = "Reporte Auditoria";
            this.Load += new System.EventHandler(this.frmReporteDiarioContable_Load);
            this.pnlCheck.ResumeLayout(false);
            this.pnlCheck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private Guna.UI2.WinForms.Guna2ComboBox cbUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnGenerarReporte;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblAnio;
        private Guna.UI2.WinForms.Guna2TextBox txtPeriodo;
        private Guna.UI2.WinForms.Guna2TextBox txtAnio;
    }
}