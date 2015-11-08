using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pCadEstado
    {
   
        String estado;
        String sigla;

        public void inserir( String estado, String sigla)
        {
            String SQL = "INSERT INTO dbo.CadEstado( estado, sigla) VALUES(''" + estado + "','" + sigla + "')";
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


    }
}
