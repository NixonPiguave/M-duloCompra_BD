using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDeCompra_BD.Clases
{
    class CsCategoria
    {
        string categoria;
        int IDCat;

        public int IdCat { get => IDCat; set => IDCat = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public bool AñadirCategoria()
        {
            string cadenaXML = $@"<Categorias>
                    <Categoria>
                        <Categoria>{categoria}</Categoria>
                    </Categoria>
                </Categorias>";
            string query = $@"exec spAgregarCategoria '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarCategoria()
        {
            string cadenaXML = $@"<Categorias>
                    <Categoria>
                        <ID_CAT>{IDCat}</ID_CAT>
                        <Categoria>{categoria}</Categoria>
                    </Categoria>
                </Categorias>";
            string query = $@"exec spModificarCategoria '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarCategoria()
        {
            string cadenaXML = $@"<Categorias>
                   <Categoria>
                        <ID_CAT>{IDCat}</ID_CAT>
                   </Categoria>
                </Categorias>";
            string query = $@"exec spEliminarCategoria '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListaCategoria(string m)
        {
            string query =$"select * from [IN-Categoria] where Categoria like '%{m}%'";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
