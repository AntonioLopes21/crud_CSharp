using NovoProjetoPOOO.models;

internal class Program
{
    private static void Main(string[] args)
    {


        Pessoa p1 = new Pessoa("Paulo", 12345678910);
        p1.Apresentar();


        string[] funcao = new string[] { "comprador", "vendedor", "intermediador" };


        Console.WriteLine("Bem vindo ao sistema de cadastro de comprador e intermediador! o que você é:\n Comprador = 1  Vendedor = 2 Intermediador = 3\n");
        int tipo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("você quer \n1.adicionar\n2.remover\n3.listar\n4.editar");
        int menu = Convert.ToInt32(Console.ReadLine());

        switch (menu)
        {
            case 1:
                Console.WriteLine("Adicionar " + funcao[tipo - 1]);
                break;

            case 2:
                Console.WriteLine("remover " + funcao[tipo -1]);
                break;

            case 3:
                Console.WriteLine("listar " + funcao[tipo -1]);
                break;

            case 4:
                Console.WriteLine("editar " + funcao[tipo -1]);
                break;

            case 5:
                Console.WriteLine("encerrar programa:");
                menu = 1;
                Console.WriteLine("programa encerrado com sucesso!");
                break;

            default:
                AgradecimentosPorUtilizarOPrograma();
                Environment.Exit(0);
                break;
        }

        
    }


    //finalizando o programa e agradecendo o user
    public static void AgradecimentosPorUtilizarOPrograma()
    {
        Console.WriteLine("Obrigado por utilizar o programa!");
    }

    //isso é uma tupla
    //     (int, string, string) tupla = (21,"Paulo", "Paulo@PAULO.com");
    //      Console.WriteLine(tupla.Item1)

}