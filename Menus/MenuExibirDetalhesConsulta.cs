using PetShop.Modelos;

namespace PetShop.Menus;

internal class MenuExibirDetalhesConsulta: Menu
{
    public override void Executar(Dictionary<int, Consulta> ConsultasRegistradas)
    {
        base.Executar(ConsultasRegistradas);
        Console.Write("Digite o id da consulta para ver detalhes: ");
        int idConsulta = int.Parse(Console.ReadLine()!);
        if (ConsultasRegistradas.ContainsKey(idConsulta))
        {
            Consulta consulta = ConsultasRegistradas[idConsulta];
            consulta.DetalhesConsulta();
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO id {idConsulta} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
