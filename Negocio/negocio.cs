using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class Categorias
    {
        String generos;


        public void inserir(string generos)
        {
            pCategorias objCategorias = new pCategorias();
            objCategorias.inserir(generos);

        }

        public void alterar()
        {

        }

        public void apagar()
        {

        }

        public Object consultarTodos()
        {
            return 1;
        }

     

    }
}
