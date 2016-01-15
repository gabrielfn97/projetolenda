using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;


namespace Negocio
{
    public class DadosComplementares
    {
        String fkCadLogin;
        String idDadosComplementares;
        String endereco;
        String telefone;
        String bairro;
        String estadoCivil;
        String ImgPerfilUrl;
        String DataNascimento;
        String sexo;
    

        public void inserir(String idDadosComplementares, String fkCadLogin, String endereco,String telefone,String bairro,String estadoCivil,String ImgPerfilUrl,String DataNascimento,String sexo)
        {
            pDadosComplementares objDadosComplementares = new pDadosComplementares();
            objDadosComplementares.inserir(idDadosComplementares, fkCadLogin, endereco, telefone, bairro, estadoCivil, ImgPerfilUrl, DataNascimento, sexo);
        }

        public void alterar(String idDadosComplementares, String fkCadLogin, String endereco, String telefone, String bairro, String estadoCivil, String ImgPerfilUrl, String DataNascimento, String sexo)
        {
            pDadosComplementares objDadosComplementares = new pDadosComplementares();
            objDadosComplementares.alterar(idDadosComplementares, fkCadLogin, endereco, telefone, bairro, estadoCivil, ImgPerfilUrl, DataNascimento, sexo);
        }

        public void apagar(String idDadosComplementares, String endereco, String telefone, String bairro, String estadoCivil, String ImgPerfilUrl, String DataNascimento, String sexo)
        {
            pDadosComplementares objDadosComplementares = new pDadosComplementares();
            objDadosComplementares.apagar(idDadosComplementares, endereco, telefone, bairro, estadoCivil, ImgPerfilUrl, DataNascimento, sexo);
        }

        public DataSet consultarTodos()
        {
            pDadosComplementares objDadosComplementares = new pDadosComplementares();
            return objDadosComplementares.consultarTodos();
        }


    }
}
