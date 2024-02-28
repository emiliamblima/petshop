using PetShop.Modelos;


namespace PetShop.Menus;

internal class MenuSair:Menu
{
    public override void Executar(Dictionary<string ,Pet> petsRegistrados ) 
    {
        Console.WriteLine("Tchau tchau ;) ");
    }
}
