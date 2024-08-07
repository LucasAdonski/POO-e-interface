public class ContaEmpresarial : ContaBancaria{
    public const double TaxaJuros = 0.3;
    public const double SaldoMinimo = 1000;

    public ContaEmpresarial(string numeroConta) : base(numeroConta){
    }

    public void mostrarSaldo(){
        Console.WriteLine("Saldo da conta empresarial: " + base.Saldo);
    }

    public void Sacar(double valor){
        if (base.Saldo - valor < SaldoMinimo){
            Console.WriteLine("Saldo insuficiente para saque, mantenha o saldo mínimo!");
        }
        else{
            base.Sacar(valor);
        }
    }
}