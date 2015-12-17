using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
    public class Usuarios
    {
        private String email;
        private String usuario;
        private String senha;
        public String idUsuario { get; set; }

        public void inserir(String email, String usuario, String senha)
        {
            pUsuarios objCadLogin = new pUsuarios();
            objCadLogin.inserir(email, usuario, senha);
        }

        public void alterar(String email, String usuario, String senha, String idCadLogin)
        {
            pUsuarios objCadLogin = new pUsuarios();
            objCadLogin.alterar(email, usuario, senha, idCadLogin);
        }

        public void apagar(String email, String usuario, String senha, String idCadLogin)
        {
            pUsuarios objCadLogin = new pUsuarios();
            objCadLogin.apagar(email, usuario, senha, idCadLogin);
        }

        public DataSet consultarTodos()
        {
            pUsuarios objCadLogin = new pUsuarios();
            return objCadLogin.consultarTodos();
        }

        public void logar(String usuario, String senha)
        {
            pUsuarios objCadLogin = new pUsuarios();
            objCadLogin.logar(usuario, senha);
            this.idUsuario = objCadLogin.idCadLogin;
        }
    }
}
