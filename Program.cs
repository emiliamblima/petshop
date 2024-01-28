
Dictionary<string, Pet> PetsRegistrados = new();
Dictionary<string, Medico> MedicosRegistrados = new();
Dictionary<int, Consulta> ConsultasRegistradas = new();

void ExibirOpcoesDoMenu()
{
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

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarPet();
            break;
        case 2:
           RegistrarDono();
          break;
        case 3:
            MostrarPetsRegistradas();
            break;
        case 4:
            RegistrarMedico();
            break;
        case 5:
            MostrarMedicosRegistradas();
            break;
        case 6:
            RegistrarConsulta();
            break;
        case 7:
            ExibirDetalhesdoPet(); //registrar quantidade de consultas
            break;
        case 8:
            ExibirDetalhesConsulta(); 
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarPet()
{
    Console.Clear();
    Console.Write("Digite o nome do pet que deseja registrar: ");
    string nomeDoPet = Console.ReadLine()!;
    Console.Write("Digite a idade do pet: ");
    int idadeDoPet = int.Parse(Console.ReadLine()!);
    Pet pet = new Pet(nomeDoPet, idadeDoPet);
    PetsRegistrados.Add(nomeDoPet, pet);
    Console.WriteLine($"o Pet {nomeDoPet} foi registrada com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void RegistrarDono()
{
    Console.Clear();
    Console.Write("Digite do pet a qual quer registrar um dono ");
    string nomeDoPet = Console.ReadLine()!;
    if (PetsRegistrados.ContainsKey(nomeDoPet))
    {
        Console.Write("Agora digite o nome do dono: ");
        string nomeDono = Console.ReadLine()!;
        Pet pet = PetsRegistrados[nomeDoPet];
        Console.Write("Agora digite o telefone do dono: ");
        string telefoneDono = Console.ReadLine()!;
        Console.Write("Agora digite o email do dono: ");
        string emailDono = Console.ReadLine()!;
        pet.AdicionarDono(new Dono(nomeDono,telefoneDono,emailDono));
        Console.WriteLine($"O Dono {nomeDono} de {nomeDoPet} foi registrado com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();

    }
    else
    {
        Console.WriteLine($"\nO pet {nomeDoPet} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }

    ExibirOpcoesDoMenu();
}
void MostrarPetsRegistradas()
{
    Console.Clear();
    Console.WriteLine("Exibindo todas as pets registradas na nossa aplicação");

    foreach (string pet in PetsRegistrados.Keys)
    {
        Console.WriteLine($"pet: {pet}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void RegistrarMedico()
{
        Console.Clear();
        Console.Write("Cadastre um medico: ");
        String nomeMedico = Console.ReadLine()!;
        Console.Write("Cadastre o telefone do medico: ");
        String telefoneMedico = Console.ReadLine()!;
        Medico medico = new Medico(nomeMedico,telefoneMedico);
        MedicosRegistrados.Add(nomeMedico,medico);
        Console.WriteLine($"O Medico {nomeMedico} foi registrado com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();

    ExibirOpcoesDoMenu();
}

void MostrarMedicosRegistradas()
{
    Console.Clear();
    Console.WriteLine("Exibindo todas as Medicos registradas na nossa aplicação");

    foreach (string medico in MedicosRegistrados.Keys)
    {
        Console.WriteLine($"Medico: {medico}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void RegistrarConsulta()
{

    Console.Write("Digite o medico responsavel da consulta: ");
    string nomeDoMedico = Console.ReadLine()!;
    if (MedicosRegistrados.ContainsKey(nomeDoMedico))
    {
        Console.Write("Digite do pet a qual quer registrar um consulta: ");
        string nomeDoPet = Console.ReadLine()!;

        if (PetsRegistrados.ContainsKey(nomeDoPet))
        {
            Console.Write("Agora digite o id da consulta: ");
            int idConsulta = int.Parse(Console.ReadLine()!);
            Console.Write("Agora digite a hora da consulta: ");
            DateTime horaConsulta = DateTime.Parse(Console.ReadLine()!);
            Pet pet = PetsRegistrados[nomeDoPet];
            Medico medico = MedicosRegistrados[nomeDoMedico];
            Consulta consulta = new Consulta(idConsulta, medico, pet, horaConsulta);
            ConsultasRegistradas.Add(idConsulta, consulta);
            pet.consultas.Add(consulta);


            Console.WriteLine($"A consulta {idConsulta} do medico {nomeDoMedico} e do pet {nomeDoPet} foi registrado com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();

        }
        else
        {
            Console.WriteLine($"\nO pet {nomeDoPet} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
     }
    else
    {
        Console.WriteLine($"\nO pet {nomeDoMedico} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
        ExibirOpcoesDoMenu();
}

void ExibirDetalhesdoPet()
{
    Console.Clear();
    Console.Write("Digite do pet a qual quer verificar todos os detalhes: ");
    string nomeDoPet = Console.ReadLine()!;
    if (PetsRegistrados.ContainsKey(nomeDoPet)) 
    {
        Pet pet = PetsRegistrados[nomeDoPet];
        pet.DetalhesPet();
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nO pet {nomeDoPet} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }

}

void ExibirDetalhesConsulta()
{
    Console.Clear();
    Console.Write("Digite o id da consulta para ver detalhes: ");
    int idConsulta = int.Parse(Console.ReadLine()!);
    if (ConsultasRegistradas.ContainsKey(idConsulta))
    {
        Consulta consulta = ConsultasRegistradas[idConsulta];
        consulta.DetalhesConsulta();
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nO id {idConsulta} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }

}






ExibirOpcoesDoMenu();