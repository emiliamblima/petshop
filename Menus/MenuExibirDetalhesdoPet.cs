using PetShop.Modelos;

namespace PetShop.Menus
{
    internal class MenuExibirDetalhesdoPet:Menu
    {
        public override void Executar(Dictionary<string, Pet> PetsRegistrados)
        {
            base.Executar(PetsRegistrados);
            Console.Write("Digite do pet a qual quer verificar todos os detalhes: ");
            string nomeDoPet = Console.ReadLine()!;
            if (PetsRegistrados.ContainsKey(nomeDoPet))
            {
                Pet pet = PetsRegistrados[nomeDoPet];
                pet.DetalhesPet();
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
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
}
