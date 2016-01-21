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
        public String idCadLogin { get; set; }
        private String email;
        private String usuario;
        private String senha;

        public void inserir(String email, String usuario, String senha)
        {
            String SQL = "INSERT INTO dbo.CadLogin(email, usuario, senha) VALUES('" + email + "','" + usuario + "','" + senha + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }


        public void alterar(String email, String usuario, String senha,String idCadLogin)
        {
            String SQL = "UPDATE dbo.CadLogin";
            SQL += " SET email = '" + email + "', usuario = '" + usuario + "', senha = '" + senha + "'";
            SQL += " WHERE idCadLogin = " + idCadLogin;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void apagar(String email, String usuario, String senha,String idCadLogin)
        {
            String SQL = "DELETE dbo.CadLogin WHERE idCadLogin =" + idCadLogin;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public DataSet consultarTodos()
        {
            String SQL = "SELECT * FROM dbo.CadLogin";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }

        public void logar(String usuario, String senha)
        {
            String SQL = "SELECT * FROM dbo.CadLogin WHERE usuario = '" + usuario + "'  AND senha= '" + senha + "'";
            Conexao oConexao = new Conexao("SQLServer");

            SqlDataReader dr = oConexao.executeReader(SQL);

            while (dr.Read())
            {
                this.idCadLogin = Convert.ToString(dr["idCadLogin"]);
            }
            dr.Close();

            oConexao.fechaConexao();           
        }

        public void RecSenha(String idCadLogin, String email, String usuario, String senha)
        {
            String SQL = "SELECT idCadLogin, email, usuario, senha FROM dbo.CadLogin WHERE email = '" + email + "'  AND usuario= '" + usuario + "' UPDATE dbo.CadLogin";
            SQL += " SET senha = " + senha;
            Conexao oConexao = new Conexao("SQLServer");

            SqlDataReader dr = oConexao.executeReader(SQL);

            while (dr.Read())
            {
                this.idCadLogin = Convert.ToString(dr["idCadLogin"]);
            }
            dr.Close();

            oConexao.fechaConexao();
        }
    }
}
