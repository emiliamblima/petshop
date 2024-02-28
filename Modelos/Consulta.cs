namespace PetShop.Modelos;
internal class Consulta

{
    public Consulta(int id, Medico medico, Pet pet, DateTime hora)
    {
        this.id = id;
        this.medico = medico;
        this.pet = pet;
        this.hora = hora;
    }

    public int id { get; }
    public Medico medico { get; }
    public Pet pet { get; }
    public DateTime hora { get; }

    public void DetalhesConsulta()
    {
        Console.WriteLine($"id Da consulta: {id}");
        Console.WriteLine($"Hora da consulta: {hora}");
        Console.WriteLine($"Medico: {medico.nome}");
        Console.WriteLine($"Pet: {pet.nome}");
    }




}