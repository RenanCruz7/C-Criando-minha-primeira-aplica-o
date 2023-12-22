string mensagem = "Ola Mundo do Renan Cruz dos Santos";
//List<string> listaDasBandas = new List<string> {"Linkin Park","Iron Maiden","Calipsooooooooo"};
Dictionary<string,List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park",new List<int> {10,9,10});
bandasRegistradas.Add("System of a Down", new List<int> { 7, 9, 8 });

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
██████╗░███████╗███╗░░██╗░█████╗░███╗░░██╗██╗░░██╗████████╗░█████╗░███╗░░██╗
██╔══██╗██╔════╝████╗░██║██╔══██╗████╗░██║██║░██╔╝╚══██╔══╝██╔══██╗████╗░██║
██████╔╝█████╗░░██╔██╗██║███████║██╔██╗██║█████═╝░░░░██║░░░██║░░██║██╔██╗██║
██╔══██╗██╔══╝░░██║╚████║██╔══██║██║╚████║██╔═██╗░░░░██║░░░██║░░██║██║╚████║
██║░░██║███████╗██║░╚███║██║░░██║██║░╚███║██║░╚██╗░░░██║░░░╚█████╔╝██║░╚███║
╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚══╝

██████╗░██████╗░░█████╗░░██████╗░██████╗░░█████╗░███╗░░░███╗
██╔══██╗██╔══██╗██╔══██╗██╔════╝░██╔══██╗██╔══██╗████╗░████║
██████╔╝██████╔╝██║░░██║██║░░██╗░██████╔╝███████║██╔████╔██║
██╔═══╝░██╔══██╗██║░░██║██║░░╚██╗██╔══██╗██╔══██║██║╚██╔╝██║
██║░░░░░██║░░██║╚█████╔╝╚██████╔╝██║░░██║██║░░██║██║░╚═╝░██║
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝");
    Console.WriteLine(mensagem);

}

void ExibirMenu()
{
    ExibirMensagemDeBoasVindas();
    Console.WriteLine("\nDigite 1 para registar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("Digite a opção desejada: ");
    string opcao = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcao);

    switch (opcaoNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: ExibirMedia();
            break;
        case -1: Console.WriteLine("Tchau Tchau");
            break;
        default: Console.WriteLine("Opção Invalida");
            break;
    }

}


void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
     string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Console.Clear();
    Thread.Sleep(1000);
    ExibirMenu();
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Listagem de Bandas");
    /*
    for(int i =0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }
    */
    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }


    Console.WriteLine("\nDigite uma tecla para voltar para o menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}


void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da Banda que seja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine("Nota salva com sucesso");
        Thread.Sleep(1000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}


void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();

    }
    else
    {
        Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("Digite ma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }


}




ExibirMenu();
