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
    public partial class FrmFunciones : Form
    {
        string[] vectorNombre= new string[18];
        int[] vectorID;
        int cont = 0;
        public FrmFunciones()
        {
            InitializeComponent();
        }

        private void btnSeleccionarFuncion_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBID1.Checked) vectorNombre[cont++] = CBID1.Text;
                if (CBID2.Checked) vectorNombre[cont++] = CBID2.Text;
                if (CBID3.Checked) vectorNombre[cont++] = CBID3.Text;
                if (CBID4.Checked) vectorNombre[cont++] = CBID4.Text;
                if (CBID5.Checked) vectorNombre[cont++] = CBID5.Text;
                if (CBID6.Checked) vectorNombre[cont++] = CBID6.Text;
                if (CBID7.Checked) vectorNombre[cont++] = CBID7.Text;
                if (CBID8.Checked) vectorNombre[cont++] = CBID8.Text;
                if (CBID9.Checked) vectorNombre[cont++] = CBID9.Text;
                if (CBID10.Checked) vectorNombre[cont++] = CBID10.Text;
                if (CBID11.Checked) vectorNombre[cont++] = CBID11.Text;
                if (CBID12.Checked) vectorNombre[cont++] = CBID12.Text;
                if (CBID13.Checked) vectorNombre[cont++] = CBID13.Text;
                if (CBID14.Checked) vectorNombre[cont++] = CBID14.Text;
                if (CBID15.Checked) vectorNombre[cont++] = CBID15.Text;
                if (CBID16.Checked) vectorNombre[cont++] = CBID16.Text;
                if (CBID17.Checked) vectorNombre[cont++] = CBID17.Text;
                if (CBID18.Checked) vectorNombre[cont++] = CBID18.Text;
                Array.Resize(ref vectorNombre, cont);
                int obtenerid = vectorNombre.Length;
                vectorID = new int[obtenerid];
                for (int i = 0; i < obtenerid; i++)
                {
                    string idobt = vectorNombre [i];
                    int ID = CsComandosSql.obtenerID($"select ID_Funcion from Funciones where Funcion = '{idobt}'");
                    vectorID[i] = ID;
                }
                FrmRol funcion = new FrmRol();
                funcion.Funcion = vectorID;
                MessageBox.Show("Funciones obtenidas correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
