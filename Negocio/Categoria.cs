using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class Categoria
    {
        String descricao;
        int idClassificacao;

        public void inserir(String descricao, String idClassificacao)
        {
            pCategoria objCategoria = new pCategoria();
            objCategoria.inserir(descricao, idClassificacao);
        }

        public void alterar()
        {

        }

        public void deletar()
        {

        }

        public Object consultarTodos()
        {
            return 1;
        }


    }
}
