namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        // public Reserva () {}

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public class SuiteException : ArgumentException
        {
            public SuiteException(string message) : base(message) { }
        }

        public class HospedeException : ArgumentException
        {
            public HospedeException(string message) : base(message) { }
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Validação: lista nula ou vazia
            if (hospedes == null || hospedes.Count == 0)
            {
                throw new HospedeException("A lista de hóspedes não pode ser nula ou vazia.");
            }

            // Se a capacidade for suficiente, atribui os hóspedes à propriedade Hospedes
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
                return; // importante para não continuar e lançar exceção abaixo
            }

            throw new HospedeException("A capacidade da suíte é menor que o número de hóspedes informados.");
        }

        public void CadastrarSuite(Suite suite)
        {
            // Validação: suíte nula, capacidade inválida ou valor da diária inválido
            if (suite == null)
            {
                throw new SuiteException("A suíte não pode ser nula.");
            }
            if (suite.Capacidade <= 0)
            {
                throw new SuiteException("A capacidade da suíte deve ser maior que zero.");
            }
            if (suite.ValorDiaria <= 0)
            {
                throw new SuiteException("O valor da diária da suíte não pode ser 0 ou negativo.");
            }

            // Se a suíte for válida, atribui à propriedade Suite
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = 0;

            if (Hospedes != null)
            {
                quantidadeHospedes = Hospedes.Count;
            }
            
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = 0;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (true)
            {
                valor = 0;
            }

            return valor;
        }
    }
}