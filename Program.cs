using System.Security.Cryptography.X509Certificates;
using NovoProjetoPOOO.models;

internal class Program
{

    private static void Main(string[] args)
    {

        
        static void AgradecimentosPorUtilizarOPrograma()
        {
            Console.WriteLine("Obrigado por utilizar o programa!");
        }

        string[] funcao = new string[] { "comprador", "vendedor", "intermediador" };

        Console.WriteLine("Bem vindo ao sistema de cadastro de comprador e intermediador! o que você é:\n Comprador = 1  Vendedor = 2 Intermediador = 3\n");
        int tipo = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("você quer \n1.adicionar\n2.remover\n3.listar\n4.editar");
        int menu = Convert.ToInt32(Console.ReadLine());


        string Nome;
        Pessoa pessoa = new Pessoa("antonio dev");
        switch (menu)
        {
            case 1:
                Console.WriteLine("Bem vindo ao adicionar" + funcao[tipo - 1] + "! digite o nome da pessoa:\n");
                Nome = Console.ReadLine();

                if (!string.IsNullOrEmpty(Nome))
                {
                    pessoa.AdicionarPessoa(Nome);
                    Console.WriteLine("Pessoa cadastrada com sucesso!");
                }
                break;

            case 2:
                Console.WriteLine("Remover" + funcao[tipo - 1] + ":\n digite o nome da pessoa");
                Nome = Console.ReadLine();

                if (!string.IsNullOrEmpty(Nome))
                {
                    pessoa.RemoverPessoa(Nome);
                    Console.WriteLine(funcao[tipo - 1] + " removida com sucesso!");
                }
                else
                {
                    Console.WriteLine(funcao[tipo - 1] + " não foi localizada.");
                }
                break;

            case 3:
                Console.WriteLine("Bem vindo a lista de cadastrados!");
                pessoa.ListarPessoa();

                break;

            case 4:
                Console.WriteLine("editar " + funcao[tipo - 1]);
                Console.WriteLine("digite o nome que deseja alterar:");
                string nome = Console.ReadLine();

                if (!string.IsNullOrEmpty(nome))
                {
                    Console.WriteLine("Digite o novo nome da pessoa:");
                    string novoNome = Console.ReadLine();

                    Pessoa pessoaParaEditar = Pessoa.ListaDePessoas.Find(p => p.Nome == nome);
                    if (pessoaParaEditar != null)
                    {
                        pessoaParaEditar.Nome = novoNome;
                        Console.WriteLine("Pessoa editada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Pessoa não encontrada na lista.");
                    }

                }
                break;

            case 5:
                Console.WriteLine("encerrar programa:");
                menu = 1;
                Console.WriteLine("programa encerrado com sucesso!");
                break;

            default:
                Console.WriteLine("Comando inválido");
                AgradecimentosPorUtilizarOPrograma();
                Environment.Exit(0);
                break;
        }


    }


    //finalizando o programa e agradecendo o user


    //isso é uma tupla
    //     (int, string, string) tupla = (21,"Paulo", "Paulo@PAULO.com");
    //      Console.WriteLine(tupla.Item1)

}