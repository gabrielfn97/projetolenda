using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class Login
    {
        String login;
        String senha;

        public void inserir(String login, String senha)
        {
            pLogin objLogin = new pLogin();
            objLogin.inserir(senha, login);
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
