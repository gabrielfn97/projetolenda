using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pDadosComplementares
    {
        String idDadosComplementares;
        String endereco;
        String telefone;
        String bairro;
        String estadoCivil;
        String ImgPerfilUrl;
        String DataNascimento;
        String sexo;


        public void inserir(String idDadosComplementares, String fkCadLogin, String endereco, String telefone, String bairro, String estadoCivil, String ImgPerfilUrl, String DataNascimento, String sexo)
        {
            String SQL = "INSERT INTO dbo.DadosComplementares1(fkCadLogin, endereco, telefone, bairro, estadoCivil, ImgPerfilUrl, DataNascimento, sexo) VALUES('" + fkCadLogin + "','" + endereco + "','" + telefone + "','" + bairro + "','" + estadoCivil + "','" + ImgPerfilUrl + "','" + DataNascimento + "','" + sexo + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void alterar(String idDadosComplementares, String fkCadLogin, String endereco, String telefone, String bairro, String estadoCivil, String ImgPerfilUrl, String DataNascimento, String sexo)
        {
            String SQL = "UPDATE dbo.DadosComplementares1";
            SQL += " SET fkCadLogin = '"+ fkCadLogin +"', endereco = '" + endereco + "',  telefone = '" + telefone + "', bairro = '" + bairro + "', estadoCivil = '" + estadoCivil + "', ImgPerfilUrl = '" + ImgPerfilUrl + "', DataNascimento = '" + DataNascimento + "', sexo = '" + sexo + "'";
            SQL += " WHERE idDadosComplementares = " + idDadosComplementares;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public void apagar(String idDadosComplementares, String endereco, String telefone, String bairro, String estadoCivil, String ImgPerfilUrl, String DataNascimento, String sexo)
        {
            String SQL = "DELETE dbo.DadosComplementares1 WHERE idDadosComplementares =" + idDadosComplementares;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        public DataSet consultarTodos()
        {
            String SQL = "SELECT idDadosComplementares as ID, fkCadLogin, endereco as Endereço, telefone as Telefone, bairro as Bairro, estadoCivil as Estado_Civil, ImgPerfilUrl as Img_Perfil, DataNascimento as Data_Nascimento, sexo as Sexo FROM dbo.DadosComplementares1 inner join dbo.CadLogin on idCadLogin = fkCadLogin";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }
    
    }
}
