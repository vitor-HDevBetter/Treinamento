
using Treinamento;

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

ComprarCarro(novoUsuario);

static List<Carro> CadastrarCarros()
{
    return
    [
        new()
        {
            Ano = 2020,
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
            Ano = 2022,
            Marca = "Volks",
            Modelo = "Nivus",
            Preco = 120000
        }
    ];
}

void ComprarCarro(Usuario usuario)
{
    var teste = carros[1];

}
