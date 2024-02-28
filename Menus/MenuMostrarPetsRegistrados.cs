using PetShop.Modelos;

namespace PetShop.Menus
{
    internal class MenuMostrarPetsRegistrados: Menu
    {
        public override void Executar(Dictionary<string, Pet> PetsRegistrados)
        {
            base.Executar(PetsRegistrados);
            Console.WriteLine("Exibindo todas as pets registradas na nossa aplicação");

            foreach (string pet in PetsRegistrados.Keys)
            {
                Console.WriteLine($"pet: {pet}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
