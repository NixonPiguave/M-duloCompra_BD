using ModuloDeCompra_BD.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class FrmProductosUsuarios : Form
    {
        int Id;
        int Id2;

        public FrmProductosUsuarios()
        {
            InitializeComponent();
        }

        private void FrmProductosUsuarios_Load(object sender, EventArgs e)
        {
            dgvService.DataSource = CsComandosSql.RetornaDatos("select ID_Servicio, Nom_Servicio, Precio_Unit from Servicios");
            dgvProducto.DataSource = CsComandosSql.RetornaDatos("select ID_Producto, Nom_Producto, Precio_Unit from Producto");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProducto.DataSource = CsComandosSql.RetornaDatos($"select ID_Producto, Nom_Producto, Precio_Unit from Producto where Nom_Producto = '{txtNombreProducto.Text}'");
            dgvService.DataSource = CsComandosSql.RetornaDatos($"select ID_Servicio, Nom_Servicio, Precio_Unit from Servicios where Nom_Producto = '{txtNombreProducto.Text}'");
        }
    }
}
