using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistencia
{
    public class pCategoria
    {
        String descricao;
        int idClassificacao;

        public void inserir(String descricao, String idClassificacao)
        {
            String SQL = "INSERT INTO Categoria(descricao, idClassificacao) VALUES('" + descricao + "', " + Convert.ToInt32(idClassificacao) + ")";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void alterar()
        {

        }

        public void deletar()
        {

        }

        public Object consultarTodos()
        {
            return 1;
        }

        
    }
}
