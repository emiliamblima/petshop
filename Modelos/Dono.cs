namespace PetShop.Modelos;
internal class Dono 
{
    private List<Pet> pets = new List<Pet>();
    public Dono(string nome, string telefone, string email)
    {
        this.nome = nome;
        this.telefone = telefone;
        this.email = email;
    }

    public string nome { get; }
    public string telefone { get; }

    public string email { get; }




}