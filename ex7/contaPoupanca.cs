public class ContaPoupanca : ContaBancaria
{
    public double TaxaJuros = 0.03;

    public ContaPoupanca(string numeroConta) : base(numeroConta){
    }

    public void calcularJuros(){
        double juros = base.Saldo * TaxaJuros;
        base.Saldo += juros;
    }

    public void mostrarSaldo(){
        Console.WriteLine("Saldo da conta poupança: " + base.Saldo);
    }
}