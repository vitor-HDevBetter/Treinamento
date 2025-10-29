namespace Treinamento;

public sealed class Carro
{
    public Guid Id { get; set; } = Guid.NewGuid();  
    public int Ano { get; set; }
    public string Modelo { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public decimal Preco { get; set; } = 0;
}
