using PetShop.Modelos;

namespace PetShop.Menus;

internal class MenuRegistrarDono: Menu
{
    public override void Executar(Dictionary<string, Pet> PetsRegistrados)
    {
        base.Executar(PetsRegistrados);
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
            pet.AdicionarDono(new Dono(nomeDono, telefoneDono, emailDono));
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
    }
}
