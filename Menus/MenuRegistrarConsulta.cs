using PetShop.Modelos;
namespace PetShop.Menus;

internal class MenuRegistrarConsulta: Menu
{
    public override void Executar(Dictionary<int, Consulta> ConsultasRegistradas, Dictionary<string, Medico> MedicosRegistrados, Dictionary<string, Pet> PetsRegistrados)
    {
        base.Executar(ConsultasRegistradas, MedicosRegistrados, PetsRegistrados);
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
    }

}
