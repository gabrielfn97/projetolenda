using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pGenero
    {
        String idGeneros;
        String generos;


        public void inserir(String generos)
        {
            String SQL = "INSERT INTO dbo.Generos (generos) VALUES('" + generos + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void alterar(String generos, String idGeneros)
        {
            String SQL = "UPDATE dbo.Generos";
            SQL += " SET generos = '" + generos + "'";
            SQL += " WHERE idGeneros = " + idGeneros;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void apagar(String idGeneros, String generos)
        {
            String SQL = "DELETE dbo.Generos WHERE idGeneros =" + idGeneros;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public DataSet consultarTodos()
        {
            String SQL = "SELECT idGeneros as ID, generos as Genero FROM dbo.Generos";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }


    }
}