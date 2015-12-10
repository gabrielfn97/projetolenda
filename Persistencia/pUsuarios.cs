using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pUsuarios
    {
        String idCadLogin;
        String email;
        String usuario;
        String senha;

        public void inserir(String email, String usuario, String senha)
        {
            String SQL = "INSERT INTO dbo.CadLogin(email, usuario, senha) VALUES('" + email + "','" + usuario + "','" + senha + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }


        public void alterar(String email, String usuario, String senha)
        {
            String SQL = "UPDATE dbo.CadLogin";
            SQL += "'SET email = '" + email + "', usuario = '" + usuario + "', senha = '" + senha + "'";
            SQL += "WHERE idCadLogin = " + idCadLogin;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void apagar(String email, String usuario, String senha)
        {
            String SQL = "DELETE dbo.CadLogin WHERE idCadLogin =" + idCadLogin;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public Object consultarTodos()
        {
            String SQL = "SELECT * FROM dbo.CadLogin";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }

        public DataSet logar(String usuario, String senha)
        {
            String SQL = "SELECT * FROM dbo.CadLogin WHERE usuario = '" + usuario + "'  AND senha= '" + senha + "'";
            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }

    }
}
