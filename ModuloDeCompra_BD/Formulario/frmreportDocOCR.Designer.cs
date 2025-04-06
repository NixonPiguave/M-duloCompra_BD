namespace ModuloDeCompra_BD.Formulario
{
    partial class frmreportDocOCR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreportDocOCR));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEnviarDoc = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCuerpo = new System.Windows.Forms.RichTextBox();
            this.txtAsunto = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDestinatario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCuentaEnvio = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnEnviarDoc);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.txtCuerpo);
            this.guna2Panel1.Controls.Add(this.txtAsunto);
            this.guna2Panel1.Controls.Add(this.txtDestinatario);
            this.guna2Panel1.Controls.Add(this.txtCuentaEnvio);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(418, 553);
            this.guna2Panel1.TabIndex = 7;
            // 
            // btnEnviarDoc
            // 
            this.btnEnviarDoc.Animated = true;
            this.btnEnviarDoc.BorderRadius = 10;
            this.btnEnviarDoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnviarDoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnviarDoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnviarDoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnviarDoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnEnviarDoc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarDoc.ForeColor = System.Drawing.Color.White;
            this.btnEnviarDoc.IndicateFocus = true;
            this.btnEnviarDoc.Location = new System.Drawing.Point(222, 388);
            this.btnEnviarDoc.Name = "btnEnviarDoc";
            this.btnEnviarDoc.Size = new System.Drawing.Size(180, 45);
            this.btnEnviarDoc.TabIndex = 27;
            this.btnEnviarDoc.Text = "Enviar documento";
            this.btnEnviarDoc.Click += new System.EventHandler(this.btnEnviarDoc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cuerpo:";
            // 
            // txtCuerpo
            // 
            this.txtCuerpo.Location = new System.Drawing.Point(143, 206);
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.Size = new System.Drawing.Size(259, 136);
            this.txtCuerpo.TabIndex = 8;
            this.txtCuerpo.Text = "";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAsunto.DefaultText = "";
            this.txtAsunto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAsunto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAsunto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAsunto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAsunto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAsunto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAsunto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAsunto.Location = new System.Drawing.Point(143, 156);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.PlaceholderText = "";
            this.txtAsunto.SelectedText = "";
            this.txtAsunto.Size = new System.Drawing.Size(259, 26);
            this.txtAsunto.TabIndex = 7;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Animated = true;
            this.txtDestinatario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDestinatario.DefaultText = "";
            this.txtDestinatario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDestinatario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDestinatario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDestinatario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDestinatario.Enabled = false;
            this.txtDestinatario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDestinatario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDestinatario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDestinatario.Location = new System.Drawing.Point(143, 115);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.PlaceholderText = "";
            this.txtDestinatario.SelectedText = "";
            this.txtDestinatario.Size = new System.Drawing.Size(259, 26);
            this.txtDestinatario.TabIndex = 6;
            // 
            // txtCuentaEnvio
            // 
            this.txtCuentaEnvio.Animated = true;
            this.txtCuentaEnvio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCuentaEnvio.DefaultText = "";
            this.txtCuentaEnvio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCuentaEnvio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCuentaEnvio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCuentaEnvio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCuentaEnvio.Enabled = false;
            this.txtCuentaEnvio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCuentaEnvio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCuentaEnvio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCuentaEnvio.Location = new System.Drawing.Point(143, 74);
            this.txtCuentaEnvio.Name = "txtCuentaEnvio";
            this.txtCuentaEnvio.PlaceholderText = "";
            this.txtCuentaEnvio.SelectedText = "";
            this.txtCuentaEnvio.Size = new System.Drawing.Size(259, 26);
            this.txtCuentaEnvio.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documento Orden por Requisicion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Asunto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuenta de envio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Destinatario:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.reportViewer1.Location = new System.Drawing.Point(418, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(619, 553);
            this.reportViewer1.TabIndex = 6;
            // 
            // frmreportDocOCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 553);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmreportDocOCR";
            this.Text = "Documento";
            this.Load += new System.EventHandler(this.frmreportDocOCR_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnEnviarDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtCuerpo;
        private Guna.UI2.WinForms.Guna2TextBox txtAsunto;
        private Guna.UI2.WinForms.Guna2TextBox txtDestinatario;
        private Guna.UI2.WinForms.Guna2TextBox txtCuentaEnvio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}