using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pCadLogin
    {
        String email;
        String usuario;
        String senha;

        public void inserir(String email, String usuario, String senha)
        {
            String SQL = "INSERT INTO CadLogin(email, usuario, senha) VALUES(" + email + ",'" + usuario + "','" + senha + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
        //{
            //pCadLogin objCadLogin = new pCadLogin();
           // objCadLogin.inserir(email, usuario, senha);
        //}//

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
