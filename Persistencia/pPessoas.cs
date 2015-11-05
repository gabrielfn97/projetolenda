using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pPessoas
    {
        String cpf;
        String nome;
        String dataNascimento;

        public void inserir(String cpf, String nome, String dataNascimento) 
        {
            String SQL = "INSERT INTO dbo.Pessoas(cpf, nome, dtNasc) VALUES("+cpf+",'"+nome+"','"+dataNascimento+"')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void alterar() 
        {

        }

        public void apagar() 
        {
        
        }

        public Object consultarTodos() 
        {
            return 1;        
        }

        public String buscar_CPF()
        {
            return "";
        }

        public int calcularIdade()
        {
            return 1;        
        }


    }
}
