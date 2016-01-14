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
        String TipoNoticia;


        public void inserir(String noticia, String data, String TipoNoticia)
        {
            String SQL = "INSERT INTO dbo.noticia (noticia, data, TipoNoticia) VALUES('" + noticia + "','" + data + "' , '"+ TipoNoticia +"')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void alterar(String idNoticia, String noticia, String data, String TipoNoticia)
        {
            String SQL = "UPDATE dbo.noticia";
            SQL += " SET noticia = '" + noticia + "', data = '" + data + "' ,  '"+TipoNoticia+ "')";
            SQL += " WHERE idNoticia = " + idNoticia;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void apagar(String idNoticia, String noticia, String data, String TipoNoticia)
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

       public DataSet dtListarTodasNoticias()
        {
            String SQL = "SELECT notica, data, TipoNoticia FROM dbo.noticia";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }

    }
}