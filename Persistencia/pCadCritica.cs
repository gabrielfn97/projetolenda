using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pCadCritica
    {
        String idCritica;
        String nome;
        String critica;
        String data;


        public void inserir(String nome, String critica, String data)
        {
            String SQL = "INSERT INTO dbo.Critica3 (nome,critica,data) VALUES('" + nome + "','" + critica + "','" + data + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void alterar(String nome, String critica, String data)
        {
            String SQL = "UPDATE dbo.Critica3";
            SQL += " SET nome = '" + nome + "',  critica = '" + critica + "', data = '" + data + "'";
            SQL += " WHERE idCritica = " + idCritica;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void apagar(String nome, String critica, String data)
        {
            String SQL = "DELETE dbo.Critica3 WHERE idCritica =" + idCritica;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public DataSet consultarTodos()
        {
            String SQL = "SELECT * FROM dbo.Critica3";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }

        public DataSet reTodasCriticas()
        {
            String SQL = "SELECT * FROM dbo.CadCritica3";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }

    }
}