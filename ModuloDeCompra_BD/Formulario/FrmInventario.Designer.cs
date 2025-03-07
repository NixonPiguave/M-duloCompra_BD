namespace ModuloDeCompra_BD.Formulario
{
    partial class FrmInventario
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
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnlistadoproducto = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtIDProductoListado = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnlistadobodegas = new Guna.UI2.WinForms.Guna2Button();
            this.txtcantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.CA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtIDBodega = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDBodegaListado = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.txtID_Inventario = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToOrderColumns = true;
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(483, 49);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowTemplate.Height = 18;
            this.dgvInventario.Size = new System.Drawing.Size(649, 588);
            this.dgvInventario.TabIndex = 20;
            this.dgvInventario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellDoubleClick);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.guna2Panel2.Controls.Add(this.btnlistadoproducto);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel2.Controls.Add(this.txtIDProductoListado);
            this.guna2Panel2.Controls.Add(this.btnlistadobodegas);
            this.guna2Panel2.Controls.Add(this.txtcantidad);
            this.guna2Panel2.Controls.Add(this.btnAgregar);
            this.guna2Panel2.Controls.Add(this.CA);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Controls.Add(this.txtIDBodega);
            this.guna2Panel2.Controls.Add(this.txtIDBodegaListado);
            this.guna2Panel2.Controls.Add(this.btnModificar);
            this.guna2Panel2.Controls.Add(this.txtID_Inventario);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(434, 701);
            this.guna2Panel2.TabIndex = 21;
            // 
            // btnlistadoproducto
            // 
            this.btnlistadoproducto.BorderRadius = 20;
            this.btnlistadoproducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlistadoproducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlistadoproducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlistadoproducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlistadoproducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnlistadoproducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnlistadoproducto.ForeColor = System.Drawing.Color.White;
            this.btnlistadoproducto.Location = new System.Drawing.Point(242, 388);
            this.btnlistadoproducto.Name = "btnlistadoproducto";
            this.btnlistadoproducto.Size = new System.Drawing.Size(133, 53);
            this.btnlistadoproducto.TabIndex = 34;
            this.btnlistadoproducto.Text = "Seleccionar IDProducto";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(56, 370);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(116, 22);
            this.guna2HtmlLabel5.TabIndex = 33;
            this.guna2HtmlLabel5.Text = "ID listaProducto";
            // 
            // txtIDProductoListado
            // 
            this.txtIDProductoListado.BorderRadius = 10;
            this.txtIDProductoListado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDProductoListado.DefaultText = "";
            this.txtIDProductoListado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDProductoListado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDProductoListado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProductoListado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProductoListado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProductoListado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDProductoListado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProductoListado.Location = new System.Drawing.Point(14, 398);
            this.txtIDProductoListado.Name = "txtIDProductoListado";
            this.txtIDProductoListado.PlaceholderText = "";
            this.txtIDProductoListado.SelectedText = "";
            this.txtIDProductoListado.Size = new System.Drawing.Size(194, 31);
            this.txtIDProductoListado.TabIndex = 32;
            // 
            // btnlistadobodegas
            // 
            this.btnlistadobodegas.BorderRadius = 20;
            this.btnlistadobodegas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlistadobodegas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlistadobodegas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlistadobodegas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlistadobodegas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnlistadobodegas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnlistadobodegas.ForeColor = System.Drawing.Color.White;
            this.btnlistadobodegas.Location = new System.Drawing.Point(242, 312);
            this.btnlistadobodegas.Name = "btnlistadobodegas";
            this.btnlistadobodegas.Size = new System.Drawing.Size(133, 53);
            this.btnlistadobodegas.TabIndex = 31;
            this.btnlistadobodegas.Text = "Seleccionar IDBodega";
            // 
            // txtcantidad
            // 
            this.txtcantidad.BorderRadius = 10;
            this.txtcantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcantidad.DefaultText = "";
            this.txtcantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcantidad.Location = new System.Drawing.Point(14, 252);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.PlaceholderText = "";
            this.txtcantidad.SelectedText = "";
            this.txtcantidad.Size = new System.Drawing.Size(194, 31);
            this.txtcantidad.TabIndex = 28;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(130, 456);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 53);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            // 
            // CA
            // 
            this.CA.BackColor = System.Drawing.Color.Transparent;
            this.CA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CA.ForeColor = System.Drawing.SystemColors.Control;
            this.CA.Location = new System.Drawing.Point(56, 224);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(67, 22);
            this.CA.TabIndex = 25;
            this.CA.Text = "Cantidad";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(56, 294);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(108, 22);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = "ID listaBodega";
            // 
            // txtIDBodega
            // 
            this.txtIDBodega.BorderRadius = 10;
            this.txtIDBodega.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDBodega.DefaultText = "";
            this.txtIDBodega.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDBodega.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDBodega.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDBodega.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDBodega.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDBodega.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDBodega.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDBodega.Location = new System.Drawing.Point(105, 571);
            this.txtIDBodega.Name = "txtIDBodega";
            this.txtIDBodega.PlaceholderText = "";
            this.txtIDBodega.SelectedText = "";
            this.txtIDBodega.Size = new System.Drawing.Size(195, 31);
            this.txtIDBodega.TabIndex = 21;
            // 
            // txtIDBodegaListado
            // 
            this.txtIDBodegaListado.BorderRadius = 10;
            this.txtIDBodegaListado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDBodegaListado.DefaultText = "";
            this.txtIDBodegaListado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDBodegaListado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDBodegaListado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDBodegaListado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDBodegaListado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDBodegaListado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDBodegaListado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDBodegaListado.Location = new System.Drawing.Point(14, 322);
            this.txtIDBodegaListado.Name = "txtIDBodegaListado";
            this.txtIDBodegaListado.PlaceholderText = "";
            this.txtIDBodegaListado.SelectedText = "";
            this.txtIDBodegaListado.Size = new System.Drawing.Size(194, 31);
            this.txtIDBodegaListado.TabIndex = 20;
            // 
            // btnModificar
            // 
            this.btnModificar.BorderRadius = 20;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(144)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(139, 608);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(133, 53);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            // 
            // txtID_Inventario
            // 
            this.txtID_Inventario.BorderRadius = 10;
            this.txtID_Inventario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID_Inventario.DefaultText = "";
            this.txtID_Inventario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID_Inventario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID_Inventario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID_Inventario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID_Inventario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID_Inventario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID_Inventario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID_Inventario.Location = new System.Drawing.Point(105, 70);
            this.txtID_Inventario.Name = "txtID_Inventario";
            this.txtID_Inventario.PlaceholderText = "";
            this.txtID_Inventario.SelectedText = "";
            this.txtID_Inventario.Size = new System.Drawing.Size(210, 35);
            this.txtID_Inventario.TabIndex = 6;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(158, 42);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(94, 22);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "ID Inventario";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(158, 543);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(80, 22);
            this.guna2HtmlLabel3.TabIndex = 1;
            this.guna2HtmlLabel3.Text = "ID Bodega";
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 701);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.dgvInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvInventario;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnlistadoproducto;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtIDProductoListado;
        private Guna.UI2.WinForms.Guna2Button btnlistadobodegas;
        private Guna.UI2.WinForms.Guna2TextBox txtcantidad;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2HtmlLabel CA;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtIDBodega;
        private Guna.UI2.WinForms.Guna2TextBox txtIDBodegaListado;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2TextBox txtID_Inventario;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}