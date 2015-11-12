using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class Genero
    {
        String generos;

        public void inserir(String generos)
        {
            pGenero objGenero = new pGenero();
            objGenero.inserir(generos);
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
