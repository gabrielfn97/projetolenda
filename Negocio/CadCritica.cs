using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
    public class CadCritica
    {
        String idCritica;
        String nome;
        String critica;
        String data;

        public void inserir(String nome, String critica, String data)
        {
            pCadCritica objCadCritica = new pCadCritica();
            objCadCritica.inserir(nome,critica,data);
        }
        public void alterar(String idCritica, String nome, String critica, String data) 
        {
            pCadCritica objCadCritica = new pCadCritica();
            objCadCritica.alterar(idCritica, nome, critica, data);
        }
        public void apagar (String idCritica, String nome, String critica, String data)
        {
            pCadCritica objCadCritica = new pCadCritica();
            objCadCritica.apagar(idCritica, nome, critica, data);
        }

        public DataSet consultarTodos()
        {
            pCadCritica objCadCritica = new pCadCritica();
            return objCadCritica.consultarTodos();
        }

        public DataSet reTodasCriticas()
        {
            pCadCritica objCadCritica = new pCadCritica();
            return objCadCritica.reTodasCriticas();
        }
    }

}
