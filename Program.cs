using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

var hospedeParaCadastrar = new[]
{
    new { Nome = "Nathália", Sobrenome = "Elen" },
    new { Nome = "João", Sobrenome = "Silva" },
    new { Nome = "Carlos", Sobrenome = "Souza" },
    new { Nome = "Maria", Sobrenome = "Eduarda" }
};

foreach (var p in hospedeParaCadastrar)
{
    try
    {
        var hospede = new Pessoa(p.Nome, p.Sobrenome);
        hospedes.Add(hospede);
        Console.WriteLine($"Hóspede cadastrado com sucesso: {hospede.NomeCompleto}");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Erro ao cadastrar hóspede '{p.Nome}': {ex.Message}");
    }
}

// // Cria a suíte
// Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// // Cria uma nova reserva, passando a suíte e os hóspedes
// Reserva reserva = new Reserva(diasReservados: 5);
// reserva.CadastrarSuite(suite);
// reserva.CadastrarHospedes(hospedes);

// // Exibe a quantidade de hóspedes e o valor da diária
// Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
// Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");