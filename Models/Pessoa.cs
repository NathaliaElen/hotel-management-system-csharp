namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    // construtor padrão
    public Pessoa() { }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    private string _nome = string.Empty;
    private string _sobrenome = string.Empty;

    public string Nome
    {
        get => _nome;

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome não pode ser vazio ou nulo.");
            }
            else if (value.Length > 30)
            {
                throw new ArgumentException("O nome não pode ter mais de 30 caracteres.");
            }
            else if (value.Length < 3)
            {
                throw new ArgumentException("O nome deve ter pelo menos 3 caracteres.");
            }
            _nome = value;
        }
    }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}