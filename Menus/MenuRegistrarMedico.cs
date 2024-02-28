using PetShop.Modelos;

namespace PetShop.Menus
{
    internal class MenuRegistrarMedico:Menu
    {
        public override void Executar(Dictionary<string, Medico> MedicosRegistrados)
        {
            base.Executar(MedicosRegistrados);
            Console.Write("Cadastre um medico: ");
            String nomeMedico = Console.ReadLine()!;
            Console.Write("Cadastre o telefone do medico: ");
            String telefoneMedico = Console.ReadLine()!;
            Medico medico = new Medico(nomeMedico, telefoneMedico);
            MedicosRegistrados.Add(nomeMedico, medico);
            Console.WriteLine($"O Medico {nomeMedico} foi registrado com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
        }

    }
}
