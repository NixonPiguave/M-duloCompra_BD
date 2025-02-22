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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
           DataTable tb= CsComandosSql.RetornaDatos("select * from IVA");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cmbIVA.Items.Add(tb.Rows[i]["Valor_IVA"].ToString());
            }
        }
    }
}
