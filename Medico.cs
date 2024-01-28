class Medico
{
    public Medico(string nome, string telefone)
    {
        this.nome = nome;
        this.telefone = telefone;
    }

    public string nome { get; }
    public string telefone { get; }
    public List<Consulta> consultas { get; }

}

