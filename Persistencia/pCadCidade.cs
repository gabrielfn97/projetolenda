using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pCadCidade
    {
        String idCadCidade;
        String cidade;
        String fkEstado;

        public void inserir(String fkEstado, String cidade)
        {
            String SQL = "INSERT INTO dbo.CadCidade( fkEstado, cidade) VALUES('" + fkEstado + "','" + cidade + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }


        public void alterar(String fkEstado, String cidade, String idCadCidade)
        {
            String SQL = "UPDATE dbo.CadCidade";
            SQL += " SET fkEstado = '" + fkEstado + "', cidade = '" + cidade + "'";
            SQL += " WHERE idCadCidade = " + idCadCidade;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();

        }

        public void apagar(String idCadCidade, String cidade)
        {
            String SQL = "DELETE dbo.CadCidade WHERE idCadCidade = " + idCadCidade;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public DataSet consultarTodos()
        {
            String SQL = "SELECT idCadCidade as ID, sigla as Estado, cidade as Cidade, fkEstado FROM dbo.CadCidade inner join dbo.CadEstado on idCadEstado = fkEstado";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }
    }
}
