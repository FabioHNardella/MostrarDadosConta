public class Conta
{
    public Titular Titular { get; set; }
    public string Agencia { get; set; }

    public int NumeroConta { get; set; }

    public int Saldo { get; set; }

    public int Limite { get; set; }
    public void mostrarInformacoes()
    {
        System.Console.WriteLine($"Dados Conta:\n");
        System.Console.WriteLine($"Nome: {Titular.Nome}");
        System.Console.WriteLine($"Endereço: {Titular.Endereco}");
        System.Console.WriteLine($"Cpf: {Titular.Cpf}");
        System.Console.WriteLine($"Agencia: {Agencia}");
        System.Console.WriteLine($"Numero da Conta: {NumeroConta}");
        System.Console.WriteLine($"Saldo: {Saldo}");
        System.Console.WriteLine($"Limite: {Limite}");
    }
}