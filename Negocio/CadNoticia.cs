using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
    public class CadNoticia
    {
        String noticia;
        String idNoticia;
        String data;

        public void inserir(String noticia, String data)
        {
            pCadNoticia objnoticia = new pCadNoticia();
            objnoticia.inserir(noticia, data);
        }

        public void alterar(String idNoticia, String noticia, String data)
        {
            pCadNoticia objnoticia = new pCadNoticia();
            objnoticia.alterar(idNoticia, noticia, data);
        }

        public void apagar(String idNoticia, String noticia, String data)
        {
            pCadNoticia objnoticia = new pCadNoticia();
            objnoticia.alterar(idNoticia, noticia, data);
        }

        public DataSet consultarTodos()
        {
            pCadNoticia objnoticia = new pCadNoticia();
            return objnoticia.consultarTodos();
        }

    }
}
