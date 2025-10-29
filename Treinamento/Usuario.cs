namespace Treinamento;

public sealed class Usuario
{
    public Usuario(string nome, string email,
        DateTime dataNascimento, Carteira carteira)
    {
        Nome = nome;
        Email = email;
        DataNascimento = dataNascimento;
        Carteira = carteira;
    }

    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime DataNascimento { get; set; }
    public List<Carro> Carros { get; set; } = [];
    public Carteira Carteira { get; set; }
}
