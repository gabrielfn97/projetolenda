using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pLogin
    {
        String login;
        String senha;

        public void inserir(String login, String senha)
        {
            String SQL = "INSERT INTO Pessoas(login, senha) VALUES(" + login + ",'" + senha + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void alterar(String login, String senha)
        {
            String SQL = "UPDATE dbo.Pessoas";
            SQL += "'SET login = '" + login + "', senha = '" + senha + "'";
            SQL += "WHERE login = " + login;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void apagar(String login, String senha)
        {
            String SQL = "DELETE dbo.Pessoas WHERE login =" + login;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public Object consultarTodos()
        {
            String SQL = "SELECT * FROM dbo.Pessoas";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }

    }
}
