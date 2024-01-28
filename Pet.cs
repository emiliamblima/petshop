class Pet 
{
    public List<Consulta> consultas = new List<Consulta>();

    public Pet(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public string nome { get; }
    public int idade { get; }

    public Dono dono { get; set; }
 
    public void AdicionarDono(Dono dono)
    {
       this.dono = dono;
    }
    public int QuantidadeConsultas()
    {
        return consultas.Count;
    }


    public void DetalhesPet()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Dono: {dono.nome}");
        Console.WriteLine($"Qtd Consultas: {QuantidadeConsultas()}");
    }
    


}