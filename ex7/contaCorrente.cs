public class ContaCorrente : ContaBancaria{
    public double valorInicial{get;set;}

    public ContaCorrente(string numeroConta) : base(numeroConta){
        this.numConta = numeroConta;
        this.valorInicial = 200;
        base.Saldo += this.valorInicial;
    }

    

    public void mostrarSaldo(){
        Console.WriteLine("Saldo da conta corrente: " + base.Saldo);
    }
}