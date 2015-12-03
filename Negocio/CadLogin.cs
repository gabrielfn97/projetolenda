using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class CadLogin
    {
        String email;
        String usuario;
        String senha;

        public void inserir(String email, String usuario, String senha)
        {
            pCadLogin objCadLogin = new pCadLogin();
            objCadLogin.inserir(email, usuario, senha);
        }

        public void alterar(String email, String usuario, String senha)
        {
            pCadLogin objCadLogin = new pCadLogin();
            objCadLogin.alterar(email, usuario, senha);
        }

        public void apagar(String email, String usuario, String senha)
        {
            pCadLogin objCadLogin = new pCadLogin();
            objCadLogin.apagar(email, usuario, senha);
        }

        public Object consultarTodos()
        {
            pCadLogin objCadLogin = new pCadLogin();
            return objCadLogin.consultarTodos();
        }

        public Object logar()
        {
            pCadLogin objCadLogin = new pCadLogin();
            return objCadLogin.logar();
        }
    }
}
