using ModuloDeCompra_BD.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
namespace ModuloDeCompra_BD.Formulario
{
    public partial class FrmFunciones : Form
    {
        string[] vectorNombre = new string[18];
        int[] vectorID;
        int cont = 0;
        int agregar;
        int tam,id;
        private FrmRol FormRol;
        public FrmFunciones(FrmRol formRol)
        {
            InitializeComponent();
            FormRol = formRol;
        }
        public int Agregar { get => agregar; set => agregar = value; }
        public int Tam { get => tam; set => tam = value; }
        public int[] VectorID { get => vectorID; set => vectorID = value; }
        public int Id { get => id; set => id = value; }

        private void FrmFunciones_Load(object sender, EventArgs e)
        {
            if (vectorID != null)
            {
                if (vectorID.Contains(1))
                    CBID1.CheckState = CheckState.Checked;
                if (vectorID.Contains(2))
                    CBID2.CheckState = CheckState.Checked;
                if (vectorID.Contains(3))
                    CBID3.CheckState = CheckState.Checked;
                if (vectorID.Contains(4))
                    CBID4.CheckState = CheckState.Checked;
                if (vectorID.Contains(5))
                    CBID5.CheckState = CheckState.Checked;
                if (vectorID.Contains(6))
                    CBID6.CheckState = CheckState.Checked;
                if (vectorID.Contains(7))
                    CBID7.CheckState = CheckState.Checked;
                if (vectorID.Contains(8))
                    CBID8.CheckState = CheckState.Checked;
                if (vectorID.Contains(9))
                    CBID9.CheckState = CheckState.Checked;
                if (vectorID.Contains(10))
                    CBID10.CheckState = CheckState.Checked;
                if (vectorID.Contains(11))
                    CBID11.CheckState = CheckState.Checked;
                if (vectorID.Contains(12))
                    CBID12.CheckState = CheckState.Checked;
                if (vectorID.Contains(13))
                    CBID13.CheckState = CheckState.Checked;
                if (vectorID.Contains(14))
                    CBID14.CheckState = CheckState.Checked;
                if (vectorID.Contains(15))
                    CBID15.CheckState = CheckState.Checked;
                if (vectorID.Contains(16))
                    CBID16.CheckState = CheckState.Checked;
                if (vectorID.Contains(17))
                    CBID17.CheckState = CheckState.Checked;
                if (vectorID.Contains(18))
                    CBID18.CheckState = CheckState.Checked;
            }
        }

        private void btnSeleccionarFuncion_Click(object sender, EventArgs e)
        {
            try
            {

                if (Agregar == 0)
                {
                    MessageBox.Show($"{Agregar}");
                    CsComandosSql.InserDeletUpdate($"DELETE FROM Roles_Funciones WHERE ID_Rol = {id}");
                }

                cont = 0;

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

                if (cont > 0)
                {
                    Array.Resize(ref vectorNombre, cont);
                    vectorID = new int[cont];

                    for (int i = 0; i < cont; i++)
                    {
                        string nombreFuncion = vectorNombre[i];
                        int funcionId = CsComandosSql.obtenerID($"SELECT ID_Funcion FROM Funciones WHERE Funcion = '{nombreFuncion}'");
                        vectorID[i] = funcionId;

                        CsComandosSql.InserDeletUpdate(
                            $"INSERT INTO Roles_Funciones (ID_Rol, ID_Funcion) VALUES ({id}, {funcionId})");
                    }
                }

                FormRol.Funcion = vectorID;
                MessageBox.Show("Funciones actualizadas correctamente");
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar funciones: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}