using Treinamento;

var usuario =
    new Usuario(
        "Lucas Araujo",
       "lucas_97@outlook.com",
 new DateTime(1998, 06, 01),
     new Carteira
     {
         Saldo = 150000,
         DataCriacao = DateTime.Now
     });

List<Carro>? carros = CadastrarCarros();

Console.WriteLine("Digite o modelo do carro desejado:");
var modelo = Console.ReadLine();

var carroEscolhido = carros.FirstOrDefault(c => c.Modelo == modelo);

if (SaldoSuficiente())
{
    Console.WriteLine($"Compra realizada: {carroEscolhido.Modelo}");
}
else
{
    Console.WriteLine("Saldo insuficiente");
}

static List<Carro> CadastrarCarros()
{
    return new List<Carro>
        {
            new () { Marca = "Toyota", Modelo = "Corolla", Ano = 2020, Preco = 195000 },
            new () { Marca = "Honda", Modelo = "Civic", Ano = 2021, Preco = 110000 },
        };
}

bool SaldoSuficiente()
{
    usuario.Carteira.Saldo -= carroEscolhido.Preco;

    return usuario.Carteira.Saldo > 0;
}

Console.ReadKey();