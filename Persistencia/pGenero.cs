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
        String generos;


        public void inserir(String generos)
        {
            String SQL = "INSERT INTO dbo.Generos (generos) VALUES('" + generos + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void alterar(String generos)
        {
            String SQL = "UPDATE dbo.Generos";
            SQL += "'SET generos = '" + generos + "'";
            SQL += "WHERE generos = " + generos;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void apagar(String generos)
        {
            String SQL = "DELETE dbo.Generos WHERE generos =" + generos;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public Object consultarTodos()
        {
            String SQL = "SELECT * FROM dbo.Generos";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }


    }
}