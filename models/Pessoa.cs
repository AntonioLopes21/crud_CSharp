using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace NovoProjetoPOOO.models
{
    public class Pessoa
    {

        public string Nome;
        public long Cpf;
        public Pessoa(string nome, long cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá! me chamo {Nome} e meu cpf é {Cpf}.");
        }

        public void AdicionarPessoa()
        {

        }

        public void RemoverPessoa()
        {

        }

        public void ListarPessoa()
        {

        }

    }
}