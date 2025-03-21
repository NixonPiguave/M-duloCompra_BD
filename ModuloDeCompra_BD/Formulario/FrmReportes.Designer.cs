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
            this.btnCategoria = new Guna.UI2.WinForms.Guna2Button();
            this.btnDetalles = new Guna.UI2.WinForms.Guna2Button();
            this.btnProducto = new Guna.UI2.WinForms.Guna2Button();
            this.btnProveedor = new Guna.UI2.WinForms.Guna2Button();
            this.btnCompras = new Guna.UI2.WinForms.Guna2Button();
            this.btnDevoluciones = new Guna.UI2.WinForms.Guna2Button();
            this.btnstock = new Guna.UI2.WinForms.Guna2Button();
            this.btnIva = new Guna.UI2.WinForms.Guna2Button();
            this.btnmovimientos = new Guna.UI2.WinForms.Guna2Button();
            this.btnrequisicion = new Guna.UI2.WinForms.Guna2Button();
            this.btnusuario = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnreport
            // 
            this.btnreport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnreport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnreport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnreport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnreport.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.White;
            this.btnreport.Location = new System.Drawing.Point(12, 12);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(179, 97);
            this.btnreport.TabIndex = 0;
            this.btnreport.Text = "El Reporte por Ordenes";
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategoria.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCategoria.Location = new System.Drawing.Point(206, 12);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(179, 97);
            this.btnCategoria.TabIndex = 1;
            this.btnCategoria.Text = "Categoria y Detalles";
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetalles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetalles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetalles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetalles.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalles.ForeColor = System.Drawing.Color.White;
            this.btnDetalles.Location = new System.Drawing.Point(405, 12);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(179, 97);
            this.btnDetalles.TabIndex = 2;
            this.btnDetalles.Text = "Ordenes Detalles";
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProducto.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Location = new System.Drawing.Point(604, 12);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(179, 97);
            this.btnProducto.TabIndex = 3;
            this.btnProducto.Text = "Producto Detalles";
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProveedor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProveedor.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.ForeColor = System.Drawing.Color.White;
            this.btnProveedor.Location = new System.Drawing.Point(802, 12);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(179, 97);
            this.btnProveedor.TabIndex = 4;
            this.btnProveedor.Text = "Reporte Proveedor";
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompras.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCompras.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCompras.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCompras.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Location = new System.Drawing.Point(12, 135);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(179, 97);
            this.btnCompras.TabIndex = 5;
            this.btnCompras.Text = "Reporte Compras";
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDevoluciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDevoluciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDevoluciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDevoluciones.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevoluciones.ForeColor = System.Drawing.Color.White;
            this.btnDevoluciones.Location = new System.Drawing.Point(206, 135);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Size = new System.Drawing.Size(188, 97);
            this.btnDevoluciones.TabIndex = 6;
            this.btnDevoluciones.Text = "Reporte Devoluciones";
            this.btnDevoluciones.Click += new System.EventHandler(this.btnDevoluciones_Click);
            // 
            // btnstock
            // 
            this.btnstock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnstock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnstock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnstock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnstock.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstock.ForeColor = System.Drawing.Color.White;
            this.btnstock.Location = new System.Drawing.Point(405, 135);
            this.btnstock.Name = "btnstock";
            this.btnstock.Size = new System.Drawing.Size(188, 97);
            this.btnstock.TabIndex = 7;
            this.btnstock.Text = "Reporte stock";
            this.btnstock.Click += new System.EventHandler(this.btnstock_Click);
            // 
            // btnIva
            // 
            this.btnIva.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIva.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIva.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIva.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIva.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIva.ForeColor = System.Drawing.Color.White;
            this.btnIva.Location = new System.Drawing.Point(604, 135);
            this.btnIva.Name = "btnIva";
            this.btnIva.Size = new System.Drawing.Size(158, 97);
            this.btnIva.TabIndex = 8;
            this.btnIva.Text = "Reporte Iva Productos_Servicios";
            this.btnIva.Click += new System.EventHandler(this.btnIva_Click);
            // 
            // btnmovimientos
            // 
            this.btnmovimientos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmovimientos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmovimientos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmovimientos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmovimientos.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmovimientos.ForeColor = System.Drawing.Color.White;
            this.btnmovimientos.Location = new System.Drawing.Point(802, 135);
            this.btnmovimientos.Name = "btnmovimientos";
            this.btnmovimientos.Size = new System.Drawing.Size(179, 97);
            this.btnmovimientos.TabIndex = 9;
            this.btnmovimientos.Text = "Reporte Movimientos";
            this.btnmovimientos.Click += new System.EventHandler(this.btnmovimientos_Click);
            // 
            // btnrequisicion
            // 
            this.btnrequisicion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnrequisicion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnrequisicion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnrequisicion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnrequisicion.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrequisicion.ForeColor = System.Drawing.Color.White;
            this.btnrequisicion.Location = new System.Drawing.Point(12, 258);
            this.btnrequisicion.Name = "btnrequisicion";
            this.btnrequisicion.Size = new System.Drawing.Size(187, 97);
            this.btnrequisicion.TabIndex = 10;
            this.btnrequisicion.Text = "Reporte Requisiciones";
            this.btnrequisicion.Click += new System.EventHandler(this.btnrequisicion_Click);
            // 
            // btnusuario
            // 
            this.btnusuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnusuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnusuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnusuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnusuario.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuario.ForeColor = System.Drawing.Color.White;
            this.btnusuario.Location = new System.Drawing.Point(222, 258);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(187, 97);
            this.btnusuario.TabIndex = 11;
            this.btnusuario.Text = "Reporte Usuarios";
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1291, 666);
            this.Controls.Add(this.btnusuario);
            this.Controls.Add(this.btnrequisicion);
            this.Controls.Add(this.btnmovimientos);
            this.Controls.Add(this.btnIva);
            this.Controls.Add(this.btnstock);
            this.Controls.Add(this.btnDevoluciones);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnreport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportes";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnreport;
        private Guna.UI2.WinForms.Guna2Button btnCategoria;
        private Guna.UI2.WinForms.Guna2Button btnDetalles;
        private Guna.UI2.WinForms.Guna2Button btnProducto;
        private Guna.UI2.WinForms.Guna2Button btnProveedor;
        private Guna.UI2.WinForms.Guna2Button btnCompras;
        private Guna.UI2.WinForms.Guna2Button btnDevoluciones;
        private Guna.UI2.WinForms.Guna2Button btnstock;
        private Guna.UI2.WinForms.Guna2Button btnIva;
        private Guna.UI2.WinForms.Guna2Button btnmovimientos;
        private Guna.UI2.WinForms.Guna2Button btnrequisicion;
        private Guna.UI2.WinForms.Guna2Button btnusuario;
    }
}

