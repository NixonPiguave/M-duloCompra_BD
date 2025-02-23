using ModuloDeCompra_BD.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class FrmProveedores: Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            dvgProveedores.DataSource = CsComandosSql.RetornaDatos($"select * from Proveedores");
        }
    }
}
