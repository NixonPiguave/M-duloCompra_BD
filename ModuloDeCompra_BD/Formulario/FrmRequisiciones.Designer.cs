namespace Menú.Formularios
{
    partial class FrmRequisiciones
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCrearRequi = new Guna.UI2.WinForms.Guna2Button();
            this.dgvProductosAgregados = new System.Windows.Forms.DataGridView();
            this.txtMotivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.btnAgregarP = new Guna.UI2.WinForms.Guna2Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lbProduc = new System.Windows.Forms.Label();
            this.panelSelectProducto = new System.Windows.Forms.Panel();
            this.dgvListadoProductos = new System.Windows.Forms.DataGridView();
            this.btnProducto = new Guna.UI2.WinForms.Guna2Button();
            this.labelListaProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroProduc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAgregados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.panelSelectProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.panel5);
            this.guna2Panel1.Controls.Add(this.panelSelectProducto);
            this.guna2Panel1.Controls.Add(this.labelListaProduct);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1211, 652);
            this.guna2Panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 32);
            this.label3.TabIndex = 38;
            this.label3.Text = "CREAR REQUISICIÓN";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.panel5.Controls.Add(this.btnCrearRequi);
            this.panel5.Controls.Add(this.dgvProductosAgregados);
            this.panel5.Controls.Add(this.txtMotivo);
            this.panel5.Location = new System.Drawing.Point(81, 418);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1050, 209);
            this.panel5.TabIndex = 27;
            // 
            // btnCrearRequi
            // 
            this.btnCrearRequi.BorderRadius = 10;
            this.btnCrearRequi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearRequi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearRequi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearRequi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearRequi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnCrearRequi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearRequi.ForeColor = System.Drawing.Color.White;
            this.btnCrearRequi.Location = new System.Drawing.Point(704, 162);
            this.btnCrearRequi.Name = "btnCrearRequi";
            this.btnCrearRequi.Size = new System.Drawing.Size(200, 44);
            this.btnCrearRequi.TabIndex = 7;
            this.btnCrearRequi.Text = "Crear Requisición";
            this.btnCrearRequi.Click += new System.EventHandler(this.btnCrearRequi_Click);
            // 
            // dgvProductosAgregados
            // 
            this.dgvProductosAgregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosAgregados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductosAgregados.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductosAgregados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductosAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosAgregados.Location = new System.Drawing.Point(25, 21);
            this.dgvProductosAgregados.Name = "dgvProductosAgregados";
            this.dgvProductosAgregados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductosAgregados.RowHeadersVisible = false;
            this.dgvProductosAgregados.Size = new System.Drawing.Size(516, 173);
            this.dgvProductosAgregados.TabIndex = 7;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotivo.DefaultText = "";
            this.txtMotivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMotivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMotivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMotivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotivo.Location = new System.Drawing.Point(618, 21);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PlaceholderText = "";
            this.txtMotivo.SelectedText = "";
            this.txtMotivo.Size = new System.Drawing.Size(396, 135);
            this.txtMotivo.TabIndex = 8;
            // 
            // txtProducto
            // 
            this.txtProducto.BorderRadius = 5;
            this.txtProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProducto.DefaultText = "";
            this.txtProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProducto.Location = new System.Drawing.Point(569, 77);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PlaceholderText = "";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.SelectedText = "";
            this.txtProducto.Size = new System.Drawing.Size(162, 36);
            this.txtProducto.TabIndex = 7;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.Color.White;
            this.lbCantidad.Location = new System.Drawing.Point(610, 126);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(87, 22);
            this.lbCantidad.TabIndex = 11;
            this.lbCantidad.Text = "Cantidad";
            this.lbCantidad.Click += new System.EventHandler(this.lbCantidad_Click);
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.BorderRadius = 10;
            this.btnAgregarP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnAgregarP.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarP.ForeColor = System.Drawing.Color.White;
            this.btnAgregarP.Location = new System.Drawing.Point(588, 192);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(120, 45);
            this.btnAgregarP.TabIndex = 25;
            this.btnAgregarP.Text = "AGREGAR";
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click_1);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(588, 148);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 10;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // lbProduc
            // 
            this.lbProduc.AutoSize = true;
            this.lbProduc.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduc.ForeColor = System.Drawing.Color.White;
            this.lbProduc.Location = new System.Drawing.Point(607, 52);
            this.lbProduc.Name = "lbProduc";
            this.lbProduc.Size = new System.Drawing.Size(91, 22);
            this.lbProduc.TabIndex = 9;
            this.lbProduc.Text = "Producto";
            // 
            // panelSelectProducto
            // 
            this.panelSelectProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.panelSelectProducto.Controls.Add(this.lbID);
            this.panelSelectProducto.Controls.Add(this.txtID);
            this.panelSelectProducto.Controls.Add(this.txtProducto);
            this.panelSelectProducto.Controls.Add(this.dgvListadoProductos);
            this.panelSelectProducto.Controls.Add(this.lbCantidad);
            this.panelSelectProducto.Controls.Add(this.btnProducto);
            this.panelSelectProducto.Controls.Add(this.btnAgregarP);
            this.panelSelectProducto.Controls.Add(this.txtFiltroProduc);
            this.panelSelectProducto.Controls.Add(this.nudCantidad);
            this.panelSelectProducto.Controls.Add(this.lbProduc);
            this.panelSelectProducto.Location = new System.Drawing.Point(137, 84);
            this.panelSelectProducto.Name = "panelSelectProducto";
            this.panelSelectProducto.Size = new System.Drawing.Size(978, 295);
            this.panelSelectProducto.TabIndex = 31;
            // 
            // dgvListadoProductos
            // 
            this.dgvListadoProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProductos.Location = new System.Drawing.Point(23, 50);
            this.dgvListadoProductos.Name = "dgvListadoProductos";
            this.dgvListadoProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListadoProductos.RowHeadersVisible = false;
            this.dgvListadoProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoProductos.Size = new System.Drawing.Size(481, 200);
            this.dgvListadoProductos.TabIndex = 4;
            // 
            // btnProducto
            // 
            this.btnProducto.BorderRadius = 10;
            this.btnProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnProducto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Location = new System.Drawing.Point(370, 8);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(134, 40);
            this.btnProducto.TabIndex = 0;
            this.btnProducto.Text = "SELECCIONAR";
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click_1);
            // 
            // labelListaProduct
            // 
            this.labelListaProduct.AutoSize = true;
            this.labelListaProduct.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaProduct.Location = new System.Drawing.Point(186, 59);
            this.labelListaProduct.Name = "labelListaProduct";
            this.labelListaProduct.Size = new System.Drawing.Size(168, 22);
            this.labelListaProduct.TabIndex = 29;
            this.labelListaProduct.Text = "Listado Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Productos Seleccionados";
            // 
            // txtFiltroProduc
            // 
            this.txtFiltroProduc.BorderRadius = 5;
            this.txtFiltroProduc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroProduc.DefaultText = "";
            this.txtFiltroProduc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltroProduc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltroProduc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltroProduc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltroProduc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltroProduc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltroProduc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltroProduc.IconRight = global::ModuloDeCompra_BD.Properties.Resources.brows_browsing_find_search_seo_web_zoom_icon_123196;
            this.txtFiltroProduc.Location = new System.Drawing.Point(33, 8);
            this.txtFiltroProduc.Name = "txtFiltroProduc";
            this.txtFiltroProduc.PlaceholderText = "";
            this.txtFiltroProduc.SelectedText = "";
            this.txtFiltroProduc.Size = new System.Drawing.Size(200, 36);
            this.txtFiltroProduc.TabIndex = 30;
            this.txtFiltroProduc.TextChanged += new System.EventHandler(this.txtFiltroProduc_TextChanged);
            this.txtFiltroProduc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltroProduc_KeyUp_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(910, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Motivo de la Requisición";
            // 
            // txtID
            // 
            this.txtID.BorderRadius = 5;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(754, 77);
            this.txtID.Name = "txtID";
            this.txtID.PlaceholderText = "";
            this.txtID.ReadOnly = true;
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(44, 36);
            this.txtID.TabIndex = 26;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(759, 52);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(30, 22);
            this.lbID.TabIndex = 27;
            this.lbID.Text = "ID";
            // 
            // FrmRequisiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1386, 676);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRequisiciones";
            this.Text = "FrmRequisiciones";
            this.Load += new System.EventHandler(this.FrmRequisiciones_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAgregados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.panelSelectProducto.ResumeLayout(false);
            this.panelSelectProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductosAgregados;
        private Guna.UI2.WinForms.Guna2Button btnCrearRequi;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtMotivo;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox txtProducto;
        private System.Windows.Forms.Label lbCantidad;
        private Guna.UI2.WinForms.Guna2Button btnAgregarP;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lbProduc;
        private System.Windows.Forms.Panel panelSelectProducto;
        private System.Windows.Forms.DataGridView dgvListadoProductos;
        private Guna.UI2.WinForms.Guna2Button btnProducto;
        private System.Windows.Forms.Label labelListaProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltroProduc;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.Label lbID;
    }
}