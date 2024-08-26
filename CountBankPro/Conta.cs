class Conta
{
    public Conta(Titular titular, int agencia, int numero, double saldo, double limite)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroDaConta = numero;
        Saldo = saldo;
        Limite = limite;
    }

    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; }
    public double Limite { get; set; }

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";

    public void TesteDeVoid()
    {
        Console.WriteLine(new string('=', 50));
        Console.WriteLine("INFORMAÇÕES DA CONTA");
        Console.WriteLine(new string('=', 50));
        Console.WriteLine(Informacoes);
        Console.WriteLine(new string('=', 50));
    }
}