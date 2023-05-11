// See https://aka.ms/new-console-template for more information
using Ex001.Entities;
using Ex001.Repositories;

Console.WriteLine("\n ~ CONTROLE DE CLIENTES ~ \n");

var cliente = new Cliente();

try
{
    Console.Write("INFORME O ID DO CLIENTE: ");
    cliente.Id = int.Parse(Console.ReadLine());

    Console.Write("INFORME O NOME DO CLIENTE: ");
    cliente.Nome = Console.ReadLine();

    Console.Write("INFORME O CPF DO CLIENTE: ");
    cliente.Cpf = Console.ReadLine();

    Console.Write("INFORME E-MAIL DO CLIENTE: ");
    cliente.Email = Console.ReadLine();

    var clienteRepository = new ClienteRepository();

    clienteRepository.GravarDados(cliente);

    Console.WriteLine("\n~ DADOS GRAVADOS COM SUCESSO ~");

    Console.Write("\nDESEJA LER OS DADOS? [S/N]: ");
    var opcao = Console.ReadLine();

    if (opcao.ToUpper().Equals("S"))
    {
        var conteudo = clienteRepository.LerDados();
        Console.WriteLine(conteudo);
    }
   
    Console.WriteLine("\nFIM DO PROGRAMA");


}
catch (Exception e)
{
    Console.WriteLine("\nOCORREU UM ERRO: " + e.Message);

    Console.Write("\nDESEJA TENTAR NOVAMENTE?[S/N]: ");
    var opcao = Console.ReadLine();

    if (opcao.ToUpper().Equals("S"))
    {
        Console.Clear();
        //Consertar mais tarde kkk cansadao pprt
    }
    else
    {
        Console.WriteLine("\nFIM DO PROGRAMA");
    }
}

Console.ReadKey();
