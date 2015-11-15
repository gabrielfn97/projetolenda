using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pCadFilmes
    {
        String NomeFilmes;
        String Classificacao;
        String Genero;
        String Iframe;
        String UrlImg;
        String Nota;
        String DataLancamento;
        String AtoresPrincipais;
        String Nacionalidade;

        public void inserir(String NomeFilmes, String Classificacao, String Genero, String Iframe, String UrlImg, String Nota, String DataLancamento, String AtoresPrincipais, String Nacionalidade)
        {
            String SQL = "INSERT INTO dbo.CadLogin(NomeFilmes, Classificacao, Genero, Iframe, UrlImg, Nota, DataLancamento, AtoresPrincipais, Nacionalidade) VALUES('" + NomeFilmes + "','" + Classificacao + "','" + Genero + "','" + Iframe + "','" + UrlImg + "','" + Nota + "','" + DataLancamento + "','" + AtoresPrincipais + "','" + Nacionalidade + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
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
