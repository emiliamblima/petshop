using PetShop.Menus;
using PetShop.Modelos;


Dictionary<string, Pet> PetsRegistrados = new();
Dictionary<string, Medico> MedicosRegistrados = new();
Dictionary<int, Consulta> ConsultasRegistradas = new();

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarPet());
opcoes.Add(2, new MenuRegistrarDono());
opcoes.Add(3, new MenuMostrarPetsRegistrados());
opcoes.Add(4, new MenuRegistrarMedico());
opcoes.Add(5, new MenuMostrarMedicosRegistrados());
opcoes.Add(6, new MenuRegistrarConsulta());
opcoes.Add(7, new MenuExibirDetalhesdoPet());
opcoes.Add(8, new MenuExibirDetalhesConsulta());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

███████████████████████████████████████████████████████████████████████
█▄─▄▄─█▄─▀█▀─▄█▄─▄▄─█─▄▄─█▄─▄▄▀█▄─▄█▄─██─▄█▄─▀█▀─▄███▄─▄▄─█▄─▄▄─█─▄─▄─█
██─▄█▀██─█▄█─███─▄▄▄█─██─██─▄─▄██─███─██─███─█▄█─█████─▄▄▄██─▄█▀███─███
▀▄▄▄▄▄▀▄▄▄▀▄▄▄▀▄▄▄▀▀▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▀▀▄▄▄▄▀▀▄▄▄▀▄▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▄▀▀▄▄▄▀▀
");
    Console.WriteLine("Boas vindas ao Emporium Pet!");
}

void ExibirOpcoesDoMenu()

{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um Pet");
    Console.WriteLine("Digite 2 para registrar um Dono");
    Console.WriteLine("Digite 3 para mostrar todos os Pets");
    Console.WriteLine("Digite 4 para registrar medico");
    Console.WriteLine("Digite 5 para mostrar medicos registrados");
    Console.WriteLine("Digite 6 para registrar uma consulta");
    Console.WriteLine("Digite 7 para mostrar detalhes de um Pet");
    Console.WriteLine("Digite 8 para mostrar detalhes de uma Consulta");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        if (opcaoEscolhidaNumerica == 4 || opcaoEscolhidaNumerica == 5)
        {
            menuASerExibido.Executar(MedicosRegistrados);
        }
        else if (opcaoEscolhidaNumerica == 8)
        {
            menuASerExibido.Executar(ConsultasRegistradas);
        }
        else if (opcaoEscolhidaNumerica == 6)
        {
            menuASerExibido.Executar(ConsultasRegistradas,MedicosRegistrados,PetsRegistrados);
        }

        else
        {
            menuASerExibido.Executar(PetsRegistrados);
        }
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}

ExibirOpcoesDoMenu();