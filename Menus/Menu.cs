using PetShop.Modelos;

namespace PetShop.Menus;

internal class Menu
{
    public virtual void Executar(Dictionary<string,Pet> PetsRegistrados) 
    {
        Console.Clear();
    }

    public virtual void Executar(Dictionary<string, Medico> MedicosRegistrados)
    {
        Console.Clear();
    }

    public virtual void Executar(Dictionary<int, Consulta> ConsultasRegistradas)
    {
        Console.Clear();
    }

    public virtual void Executar(Dictionary<int, Consulta> ConsultasRegistradas, Dictionary<string, Medico> MedicosRegistrados, Dictionary<string, Pet> PetsRegistrados)
    {
        Console.Clear();
    }




}
