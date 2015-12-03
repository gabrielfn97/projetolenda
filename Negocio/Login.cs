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

        public void alterar(String login, String senha)
        {
            pLogin objLogin = new pLogin();
            objLogin.alterar(senha, login);
        }

        public void apagar(String login, String senha)
        {
            pLogin objLogin = new pLogin();
            objLogin.apagar(senha, login);
        }

        public Object consultarTodos()
        {
            pLogin objLogin = new pLogin();
            return objLogin.consultarTodos();
        }

    }
}
