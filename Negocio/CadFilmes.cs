using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;


namespace Negocio
{
    public class CadFilmes
    {
        String NomeFilmes;
        String Classificacao;
        String Genero;
        String Iframe;
        String UrlImg;
        String Nota;
        String DataLacamento;
        String AtoresPrincipais;
        String Nacionalidade;

        public void inserir(String NomeFilmes, String Classificacao, String Genero, String Iframe, String UrlImg, String Nota, String DataLacamento, String AtoresPrincipais, String Nacionalidade)
        {
            pCadFilmes objCadFilmes = new pCadFilmes();
            objCadFilmes.inserir(NomeFilmes, Classificacao, Genero, Iframe, UrlImg, Nota, DataLacamento, AtoresPrincipais, Nacionalidade);
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
