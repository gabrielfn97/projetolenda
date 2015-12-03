using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pCadFilmes
    {
        String idFilmes;
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
            String SQL = "INSERT INTO dbo.CadFilmes(NomeFilmes, Classificacao, Genero, Iframe, UrlImg, Nota, DataLacamento, AtoresPrincipais, Nacionalidade) VALUES('" + NomeFilmes + "','" + Classificacao + "','" + Genero + "','" + Iframe + "','" + UrlImg + "','" + Nota + "','" + DataLacamento + "','" + AtoresPrincipais + "','" + Nacionalidade + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void alterar(String NomeFilmes, String Classificacao, String Genero, String Iframe, String UrlImg, String Nota, String DataLacamento, String AtoresPrincipais, String Nacionalidade)
        {
            String SQL = "UPDATE dbo.CadFilmes";
            SQL += "'SET NomeFilmes = '" + NomeFilmes + "',  Classificacao = '" +  Classificacao + "', Genero = '" + Genero + "', Iframe = '" + Iframe +"', UrlImg = '" + UrlImg +"', Nota = '" +Nota+"', DataLancamento = '" + DataLacamento+ "', AtoresPrincipais = '" + AtoresPrincipais+"', Nacionalidade = '" + Nacionalidade +"'";
            SQL += "WHERE idFilmes = " + idFilmes;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

       

        public void apagar(String NomeFilmes, String Classificacao, String Genero, String Iframe, String UrlImg, String Nota, String DataLacamento, String AtoresPrincipais, String Nacionalidade)
        {
            String SQL = "DELETE dbo.CadFilmes WHERE idFilmes =" + idFilmes;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public Object consultarTodos()
        {
            String SQL = "SELECT * FROM dbo.CadFilmes";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }


    }
}
