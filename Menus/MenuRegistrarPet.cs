using PetShop.Modelos;

namespace PetShop.Menus;

internal class MenuRegistrarPet: Menu
{
    public override void Executar(Dictionary<string, Pet> PetsRegistrados)
    {
        base.Executar(PetsRegistrados);
        Console.Write("Digite o nome do pet que deseja registrar: ");
        string nomeDoPet = Console.ReadLine()!;
        Console.Write("Digite a idade do pet: ");
        int idadeDoPet = int.Parse(Console.ReadLine()!);
        Pet pet = new Pet(nomeDoPet, idadeDoPet);
        PetsRegistrados.Add(nomeDoPet, pet);
        Console.WriteLine($"o Pet {nomeDoPet} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }

}
