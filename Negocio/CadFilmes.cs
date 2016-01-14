using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

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

        public void alterar(String NomeFilmes, String Classificacao, String Genero, String Iframe, String UrlImg, String Nota, String DataLacamento, String AtoresPrincipais, String Nacionalidade, String idFilmes)
        {
            pCadFilmes objCadFilmes = new pCadFilmes();
            objCadFilmes.alterar(NomeFilmes, Classificacao, Genero, Iframe, UrlImg, Nota, DataLacamento, AtoresPrincipais, Nacionalidade, idFilmes);
        }

        public void apagar(String idFilmes,String NomeFilmes, String Classificacao, String Genero, String Iframe, String UrlImg, String Nota, String DataLacamento, String AtoresPrincipais, String Nacionalidade)
        {
            pCadFilmes objCadFilmes = new pCadFilmes();
            objCadFilmes.apagar(idFilmes,NomeFilmes, Classificacao, Genero, Iframe, UrlImg, Nota, DataLacamento, AtoresPrincipais, Nacionalidade);
        }

        public DataSet consultarTodos()
        {
            pCadFilmes objCadFilmes = new pCadFilmes();
            return objCadFilmes.consultarTodos();
        }
    }
}
