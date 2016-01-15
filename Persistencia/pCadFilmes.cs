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
            String SQL = "INSERT INTO dbo.CadFilmes1(nome, fkClassificacao, fkGenero, iframe, urlimag, nota, dataLancamento, atoresprincipais, nacionalidade) VALUES('" + NomeFilmes + "','" + Classificacao + "','" + Genero + "','" + Iframe + "','" + UrlImg + "','" + Nota + "','" + DataLacamento + "','" + AtoresPrincipais + "','" + Nacionalidade + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void alterar(String NomeFilmes, String Classificacao, String Genero, String Iframe, String UrlImg, String Nota, String DataLacamento, String AtoresPrincipais, String Nacionalidade, String idFilmes)
        {
            String SQL = "UPDATE dbo.CadFilmes1";
            SQL += " SET nome = '" + NomeFilmes + "',  fkClassificacao = '" +  Classificacao + "', fkGenero = '" + Genero + "', iframe = '" + Iframe +"', urlimag = '" + UrlImg +"', nota = '" + Nota +"', dataLancamento = '" + DataLacamento+ "', atoresprincipais = '" + AtoresPrincipais+"', nacionalidade = '" + Nacionalidade +"'";
            SQL += " WHERE idFilmes = " + idFilmes;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

       

        public void apagar(String idFilmes,String NomeFilmes, String Classificacao, String Genero, String Iframe, String UrlImg, String Nota, String DataLacamento, String AtoresPrincipais, String Nacionalidade)
        {
            String SQL = "DELETE dbo.CadFilmes1 WHERE idFilmes =" + idFilmes;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public DataSet consultarTodos()
        {
            String SQL = "SELECT idFilmes as ID, nome as Nome_do_Filme, fkClassificacao as Classificação_Indicativa, fkGenero as Genero, nota as Nota, atoresprincipais as Atores, nacionalidade as Nacionalidade, iframe as URL_YouTube, urlimag as Link_da_Imagem, dataLancamento as Data_do_Lançamento FROM dbo.CadFilmes1 inner join dbo.Categoria on idCategoria = fkClassificacao inner join dbo.Generos on idGeneros = fkGenero";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }
        public DataSet dtListarTodosfilmes()
        {
            String SQL = "SELECT nome as Nome_do_Filme, fkClassificacao as Classificação_Indicativa, fkGenero as Genero, nota as Nota, atoresprincipais as Atores, nacionalidade as Nacionalidade FROM dbo.CadFilmes1";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }
        

        
    }
}
