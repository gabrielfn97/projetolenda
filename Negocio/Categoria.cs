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
        int idClassificacao;

        public void inserir(String descricao, String idClassificacao)
        {
            pCategoria objCategoria = new pCategoria();
            objCategoria.inserir(descricao, idClassificacao);
        }

        public void alterar(String descricao, int idClassificacao, String idCategoria)
        {
            pCategoria objCategoria = new pCategoria();
            objCategoria.alterar(descricao, idClassificacao, idCategoria);
        }

        public void apagar(String idCategoria, String descricao, int idClassificacao)
        {
            pCategoria objCategoria = new pCategoria();
            objCategoria.apagar(idCategoria, descricao, idClassificacao);
        }

        public DataSet consultarTodos()
        {
            pCategoria objCategoria = new pCategoria();
            return objCategoria.consultarTodos();
        }


    }
}
