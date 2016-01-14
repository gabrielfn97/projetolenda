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
        String TipoNoticia;

        public void inserir(String noticia, String data, String TipoNoticia)
        {
            pCadNoticia objnoticia = new pCadNoticia();
            objnoticia.inserir(noticia, data, TipoNoticia);
        }

        public void alterar(String idNoticia, String noticia, String data, String TipoNoticia)
        {
            pCadNoticia objnoticia = new pCadNoticia();
            objnoticia.alterar(idNoticia, noticia, data, TipoNoticia);
        }

        public void apagar(String idNoticia, String noticia, String data, String TipoNoticia)
        {
            pCadNoticia objnoticia = new pCadNoticia();
            objnoticia.alterar(idNoticia, noticia, data, TipoNoticia);
        }

        public DataSet consultarTodos()
        {
            pCadNoticia objnoticia = new pCadNoticia();
            return objnoticia.consultarTodos();
        }

        public DataSet consultarNoticiasCinema()
        {
            pCadNoticia objnoticiacinema = new pCadNoticia();
            return objnoticiacinema.consultarNoticiasCinema();
        }

    }
}
  