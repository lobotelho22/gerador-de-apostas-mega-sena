using gerador_de_aposta.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

Aposta aposta = new Aposta();

bool exibirMenu = true;



while (exibirMenu)
{
    Console.WriteLine("1 - Exibir os números mais sorteados da Mega Sena");
    Console.WriteLine("2 - Criar aposta entre os mais sorteados");
    Console.WriteLine("3 - Criar aposta padrão");
    Console.WriteLine("4 - Sair");

    switch(Console.ReadLine())
    {
        case "1":
            Console.WriteLine(aposta.MaisSorteados());
            break;
        
        case "2":
            Console.Write(aposta.CriarApostaMaisSorteados());
            break;

        case "3":
            Console.Write(aposta.CriarAposta());
            break;

        case "4":
            exibirMenu = false;
            break;
        
        default:
            Console.WriteLine("Digite uma opção válida");
            break;
    }
    Console.WriteLine("");
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("Bye, bye.");
