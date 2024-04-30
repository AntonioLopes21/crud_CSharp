using NovoProjetoPOOO.models;

internal class Program
{
    private static void Main(string[] args)
    {


        Pessoa p1 = new Pessoa("Paulo", 12345678910);
        p1.Apresentar();



        Console.WriteLine("Bem vindo ao sistema de cadastro de comprador e intermediador! o que você é:\n Comprador = 1  Vendedor = 2\n");
        int tipo = Convert.ToInt32(Console.ReadLine());

        if (tipo == 1)
        {

            int menu = 0;
            switch (menu)
            {
                case 1:
                    Console.WriteLine("adicionar comprador:");
                    break;

                case 2:
                    Console.WriteLine("remover comprador:");
                    break;

                case 3:
                    Console.WriteLine("listar comprador:");
                    break;

                case 4:
                    Console.WriteLine("editar comprador:");
                    break;

                case 5:
                    Console.WriteLine("encerrar programa:");
                    menu = 1;
                    Console.WriteLine("programa encerrado com sucesso!");
                    break;
            }
        }
        if (tipo == 2)
        {
            int menu = 0;
            switch (menu)
            {
                case 1:
                    Console.WriteLine("adicionar vendedor:");
                    break;

                case 2:
                    Console.WriteLine("remover vendedor:");
                    break;

                case 3:
                    Console.WriteLine("listar comprador:");
                    break;

                case 4:
                    Console.WriteLine("editar comprador:");
                    break;

                case 5:
                    Console.WriteLine("encerrar programa:");
                    menu = 1;
                    Console.WriteLine("programa encerrado com sucesso!");
                    break;
            }
        }
        else
        {
            AgradecimentosPorUtilizarOPrograma();
            Environment.Exit(0);
        }
    }


    //finalizando o programa e agradecendo o user
    public static void AgradecimentosPorUtilizarOPrograma()
    {
        Console.WriteLine("Obrigado por utilizar o programa!");
    }
}