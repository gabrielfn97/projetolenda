using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
    public class Categoria
    {
        String idCategoria;
        String descricao;

        public void inserir(String idCategoria, String descricao)
        {
            pCategoria objCategoria = new pCategoria();
            objCategoria.inserir(descricao);
        }

        public void alterar(String idCategoria, String descricao)
        {
            pCategoria objCategoria = new pCategoria();
            objCategoria.alterar(idCategoria, descricao);
        }

        public void apagar(String idCategoria, String descricao)
        {
            pCategoria objCategoria = new pCategoria();
            objCategoria.apagar(idCategoria, descricao);
        }

        public DataSet consultarTodos()
        {
            pCategoria objCategoria = new pCategoria();
            return objCategoria.consultarTodos();
        }


    }
}
