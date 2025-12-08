using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDeCompra_BD.Clases
{
    internal class CsDepartamentos
    {
        string departamento;
        int DepartamentoID;

        public int DepaID { get => DepartamentoID; set => DepartamentoID = value; }
        public string Depa{ get => departamento; set => departamento = value; }
        public bool AñadirDepartamento()
        {
            string cadenaXML = $@"<Departamentos>
                    <Departamento>
                            <Nombre_Departamento>{departamento}</Nombre_Departamento>
                    </Departamento>
                </Departamentos>";
            string query = $@"exec spAgregarDepartamento '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarDepartamento()
        {
            string cadenaXML = $@"<Departamentos>
                    <Departamento>
                        <ID_Depa>{DepartamentoID}</ID_Depa>
                        <Nombre_Departamento>{departamento}</Nombre_Departamento>
                    </Departamento>
                </Departamentos>";
            string query = $@"exec spModificarDepartamento '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarDepartamento()
        {
            string cadenaXML = $@"<Departamentos>
                    <Departamento>
                        <ID_Depa>{DepartamentoID}</ID_Depa>
                    </Departamento>
                </Departamentos>";
            string query = $@"exec spEliminarDepartamento '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListaCategoria(string m)
        {
            string query = $"Select * from [IN-Categoria] where Categoria like '%{m}%'";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
