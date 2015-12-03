using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pCadEstado
    {
   
        String estado;
        String sigla;

        public void inserir( String estado, String sigla)
        {
            String SQL = "INSERT INTO dbo.CadEstado( estado, sigla) VALUES(''" + estado + "','" + sigla + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }


        public void alterar(String estado, String sigla)
        {
            String SQL = "UPDATE dbo.CadEstado";
            SQL += "'SET estado = '" + estado + "', sigla = '" + sigla + "'";
            SQL += "WHERE estado = " + estado;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();

        }

        public void apagar(String estado, String sigla)
        {
            String SQL = "DELETE dbo.CadEstado WHERE estado =" + estado;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public Object consultarTodos()
        {
            String SQL = "SELECT * FROM dbo.CadEstado";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }


    }
}
