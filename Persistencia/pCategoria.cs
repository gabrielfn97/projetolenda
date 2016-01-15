using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistencia
{
    public class pCategoria
    {
        String idCategoria;
        String descricao;

        public void inserir(String descricao)
        {
            String SQL = "INSERT INTO dbo.Categoria(descricao) VALUES('" + descricao + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void alterar(String descricao, String idCategoria)
        {
            String SQL = "UPDATE dbo.Categoria";
            SQL += " SET descricao = '" + descricao + "'";
            SQL += " WHERE  idCategoria =  " + idCategoria;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void apagar(String idCategoria, String descricao)
        {
            String SQL = "DELETE dbo.Categoria WHERE idCategoria =" + idCategoria;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public DataSet consultarTodos()
        {
            String SQL = "SELECT idCategoria as ID, descricao as Descrição FROM dbo.Categoria";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }

        
    }
}
