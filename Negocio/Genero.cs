using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

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

        public void alterar(String generos,String idGeneros)
        {
            pGenero objGenero = new pGenero();
            objGenero.alterar(generos,idGeneros);
        }

        public void apagar(String idGeneros, String generos)
        {
            pGenero objGenero = new pGenero();
            objGenero.apagar(idGeneros, generos);
        }

        public DataSet consultarTodos()
        {
            pGenero objGenero = new pGenero();
            return objGenero.consultarTodos();
        }


    }
}
