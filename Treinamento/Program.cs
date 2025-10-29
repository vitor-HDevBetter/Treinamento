
using Treinamento;
using static System.Runtime.InteropServices.JavaScript.JSType;

var novoUsuario =
    new Usuario(
        "Vitor Gabriel",
       "vitorg_98@outlook.com",
 new DateTime(1998, 06, 01),
     new Carteira
     {
         Saldo = 150000,
         DataCriacao = DateTime.Now
     });

var carros = CadastrarCarros();

ObterCarroDesejado(novoUsuario);

static List<Carro> CadastrarCarros()
{
    return
    [
        new()
        {
            Marca = "Toyota",
            Modelo = "Corolla",
            Preco = 190000
        },
        new()
        {
            Ano = 2021,
            Marca = "Honda",
            Modelo = "Civic",
            Preco = 90000
        },
        new()
        {
            Marca = "Volks",
            Modelo = "Nivus",
            Preco = 120000
        }
    ];
}

void ObterCarroDesejado(Usuario usuario)
{
    try
    {
        var ano = carros.FirstOrDefault(c
            => c.Modelo == "Nivus").Ano.Value;

        Console.WriteLine($"Ano do carro desejado: {ano}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro ao obter o ano do carro desejado: {ex.Message}");
    }

    Console.ReadKey();
}
