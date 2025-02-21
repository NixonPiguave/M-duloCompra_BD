﻿namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmProductos
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
            this.gnLbProducto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnRegistrarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.btnDetalleProducto = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtFiltrarProductos = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gnLbProducto
            // 
            this.gnLbProducto.BackColor = System.Drawing.Color.Transparent;
            this.gnLbProducto.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnLbProducto.ForeColor = System.Drawing.Color.Indigo;
            this.gnLbProducto.Location = new System.Drawing.Point(325, 41);
            this.gnLbProducto.Name = "gnLbProducto";
            this.gnLbProducto.Size = new System.Drawing.Size(164, 52);
            this.gnLbProducto.TabIndex = 0;
            this.gnLbProducto.Text = "Producto";
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.BorderRadius = 20;
            this.btnRegistrarProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrarProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnRegistrarProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistrarProducto.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarProducto.Location = new System.Drawing.Point(41, 117);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(128, 45);
            this.btnRegistrarProducto.TabIndex = 1;
            this.btnRegistrarProducto.Text = "Registrar nuevo producto";
            // 
            // btnDetalleProducto
            // 
            this.btnDetalleProducto.BorderRadius = 20;
            this.btnDetalleProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetalleProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetalleProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetalleProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetalleProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnDetalleProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetalleProducto.ForeColor = System.Drawing.Color.White;
            this.btnDetalleProducto.Location = new System.Drawing.Point(41, 180);
            this.btnDetalleProducto.Name = "btnDetalleProducto";
            this.btnDetalleProducto.Size = new System.Drawing.Size(128, 45);
            this.btnDetalleProducto.TabIndex = 4;
            this.btnDetalleProducto.Text = "Detalle producto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(221, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 292);
            this.dataGridView1.TabIndex = 5;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(564, 90);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(96, 19);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Buscar Productos";
            // 
            // txtFiltrarProductos
            // 
            this.txtFiltrarProductos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrarProductos.DefaultText = "";
            this.txtFiltrarProductos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltrarProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltrarProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarProductos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarProductos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarProductos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltrarProductos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarProductos.Location = new System.Drawing.Point(666, 90);
            this.txtFiltrarProductos.Name = "txtFiltrarProductos";
            this.txtFiltrarProductos.PlaceholderText = "";
            this.txtFiltrarProductos.SelectedText = "";
            this.txtFiltrarProductos.Size = new System.Drawing.Size(108, 21);
            this.txtFiltrarProductos.TabIndex = 7;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFiltrarProductos);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDetalleProducto);
            this.Controls.Add(this.btnRegistrarProducto);
            this.Controls.Add(this.gnLbProducto);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel gnLbProducto;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarProducto;
        private Guna.UI2.WinForms.Guna2Button btnDetalleProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarProductos;
    }
}