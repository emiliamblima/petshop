
using PetShop.Modelos;
namespace PetShop.Menus;

internal class MenuMostrarMedicosRegistrados: Menu
{
    public override void Executar(Dictionary<string, Medico> MedicosRegistrados)
    {
      
            base.Executar(MedicosRegistrados);
            Console.WriteLine("Exibindo todas as Medicos registradas na nossa aplicação");

            foreach (string medico in MedicosRegistrados.Keys)
            {
                Console.WriteLine($"Medico: {medico}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
    }

}
