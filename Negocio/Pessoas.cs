using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class Pessoas
    {
        String cpf;
        String nome;
        String dataNascimento;

        public void inserir(String cpf, String nome, String dataNascimento) 
        {
            pPessoas objPessoas = new pPessoas();
            objPessoas.inserir(cpf, nome, dataNascimento);
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
