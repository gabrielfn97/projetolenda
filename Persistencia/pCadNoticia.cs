using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistencia
{
   public class pCadNoticia
  
    {
        String idNoticia;
        String noticia;
        String data;


        public void inserir(String noticia, String data)
        {
            String SQL = "INSERT INTO dbo.noticia (noticia) VALUES('" + noticia + "','" + data + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void alterar(String idNoticia, String noticia, String data)
        {
            String SQL = "UPDATE dbo.noticia";
            SQL += " SET noticia = '" + noticia + "', data = '" + data + "'";
            SQL += " WHERE idNoticia = " + idNoticia;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void apagar(String idNoticia, String noticia, String data)
        {
            String SQL = "DELETE dbo.noticia WHERE idNoticia =" + idNoticia;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public DataSet consultarTodos()
        {
            String SQL = "SELECT * FROM dbo.noticia";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }


    }
}