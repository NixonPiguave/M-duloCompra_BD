using ModuloDeCompra_BD.Clases;
using reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class frmReporteDiarioContable : Form
    {
        public frmReporteDiarioContable()
        {
            InitializeComponent();
        }

        private void frmReporteDiarioContable_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiarioID.Text))
            {
                int ide = Convert.ToInt32(txtDiarioID.Text);
                string sentencia = $"select 1 as NUM,YEAR(DH.Fecha) AS ANIO, MONTH(DH.Fecha) AS MES,CONVERT(date, DH.Fecha) AS Fecha,CuentaDebito as Cuenta,\r\n(select Nombre from [CG-CatalogoCuentasContables] where Cuenta= DH.CuentaDebito) AS NombreCuenta,\r\n(select Descripcion from [CG-CatalogoCuentasContables] where Cuenta= DH.CuentaDebito) as Descripcion, \r\n(select Categoria from [CG-CatalogoCuentasContables] where Cuenta= DH.CuentaDebito) as Categoria, DH.Usuario, DH.Fuente, DH.DiarioFuente AS Referencia, DH.Debito, null as Credito, DH.Diario\r\nfrom [CG-DiarioCont_Header] DH where DH.Diario={ide}\r\nunion \r\nselect 2 as NUM,YEAR(DH.Fecha) AS ANIO, MONTH(DH.Fecha) AS MES,CONVERT(date, DH.Fecha) AS Fecha,CuentaCredito as Cuenta,\r\n(select Nombre from [CG-CatalogoCuentasContables] where Cuenta= DH.CuentaCredito) AS NombreCuenta,\r\n(select Descripcion from [CG-CatalogoCuentasContables] where Cuenta= DH.CuentaCredito) as Descripcion, \r\n(select Categoria from [CG-CatalogoCuentasContables] where Cuenta= DH.CuentaCredito) as Categoria, DH.Usuario, DH.Fuente, DH.DiarioFuente AS Referencia, null as Debito ,DH.Credito, DH.Diario\r\nfrom [CG-DiarioCont_Header] DH where DH.Diario={ide}";
                frmreport ventas = new frmreport(sentencia, "DsContable", "Reporte.RptDiarioContable.rdlc");
                ventas.ShowDialog();
            }
        }

        private void btnDiario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAnio.Text) || cmbPeriodos.SelectedIndex == -1)
            {
                string periodo = cmbPeriodos.SelectedItem.ToString();
                FrmListadoDiario diario = new FrmListadoDiario();
                diario.Anio1 = txtAnio.Text;
                diario.Periodo1 = periodo;
                diario.ShowDialog();
                txtDiarioID.Text = diario.ID;
            }
            else
                MessageBox.Show("Rellene los campos");
        }
    }
}
