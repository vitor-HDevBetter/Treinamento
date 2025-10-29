namespace Treinamento;

public sealed class Carteira
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public decimal Saldo { get; set; }
    public DateTime DataCriacao { get; set; }
    public List<string> Transacoes { get; set; } = [];
}
