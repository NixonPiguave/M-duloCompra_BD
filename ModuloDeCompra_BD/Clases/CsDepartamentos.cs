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
            string query = $"insert into Departamento (Nombre_Departamento) values ('{Depa}')";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarDepartamento()
        {
            string query = $"Update Departamento set Nombre_Departamento = '{Depa}' where ID_Depa = {DepaID}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarDepartamento()
        {
            string query = $"Delete from Departamento where ID_Depa = {DepaID}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListaCategoria(string m)
        {
            string query = $"Select * from Categoria where Categoria like '%{m}%'";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
