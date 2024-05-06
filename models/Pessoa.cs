using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace NovoProjetoPOOO.models
{

    //List<string> AdicaoDePessoa = new List<string>();
    public class Pessoa
    {

        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }

        string[] funcao = new string[] { "comprador", "vendedor", "intermediador" };
        public static List<Pessoa> ListaDePessoa = new List<Pessoa>();

        public void Apresentar()
        {

        }

        public void AdicionarPessoa(string Nome)
        {
            if (Nome != null)
            {
                Pessoa pessoa = new Pessoa(Nome);
                Console.WriteLine($"o nome " + Nome + " foi cadastrado com sucesso");
                ListaDePessoa.Add(pessoa);
            }
            else
            {
                Console.WriteLine("o nome não pode ser nulo");
            }
        }

        public bool RemoverPessoa(string Nome)
        {
            if (Nome != null)
            {
                Pessoa pessoaParaRemover = ListaDePessoa.Find(p => p.Nome == Nome);

                if (pessoaParaRemover != null)
                {
                    ListaDePessoa.Remove(pessoaParaRemover);
                    Console.WriteLine($"O nome {Nome} foi removido com sucesso");
                    return true;
                }

                else
                {
                    Console.WriteLine($"O nome {Nome} não foi encontrado na lista");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("o nome não pode ser nulo");
                return false;
            }


        }

        public void ListarPessoa()
        {
            if (ListaDePessoa.Count == 0)
            {
                Console.WriteLine("Nenhuma pessoa está cadastrada no momento.");
                return;
            }
            Console.WriteLine("Lista de pessoas:");
            foreach (var pessoa in ListaDePessoa)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
            }

        }

        public void EditarPessoa(string nome, string novoNome)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(novoNome))
            {
                Pessoa pessoaParaEditar = ListaDePessoa.Find(p => p.Nome == nome);
                if (pessoaParaEditar != null)
                {
                    pessoaParaEditar.Nome = novoNome;
                    Console.WriteLine("Pessoa editada com sucesso!\n\n");
                }
                else
                {
                    Console.WriteLine("Pessoa não encontrada na lista.\n\n");
                }
            }
            else
            {
                Console.WriteLine("Nome inválido.\n\n");
            }
        }

    }
}