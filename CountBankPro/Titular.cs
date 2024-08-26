class Titular
{

    public Titular(string nome, string cpf, string endereco  )
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }
    public string Nome { get; set; }
    public string Cpf { get; }
    public string Endereco { get; set; }

    public void ExibirFixaTitular()
    {
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("TABELA DE VALIDAÇÃO DOS DADOS DE CLIENTE");
        Console.WriteLine(new string('-', 50));
        Console.WriteLine($"Nome      : {Nome}");
        Console.WriteLine($"CPF       : {Cpf}");
        Console.WriteLine($"Endereço  : {Endereco}");
        Console.WriteLine(new string('-', 50));
    }
}
