public class ContaBancaria{
    public string numConta{get;set;}
    public double Saldo{get;set;}

    public ContaBancaria(string numeroConta){
        this.numConta = numeroConta;
        this.Saldo = 0;
    }

    public void Depositar(double valor){
        this.Saldo += valor;
    }

    public void Sacar(double valor){
        if (valor > Saldo){
            Console.WriteLine("Saldo insuficiente!");
        }
        else{
            Saldo -= valor;
        }
    }

    public void mostrarSaldo(){
        Console.WriteLine("Saldo da conta: " + this.Saldo);
    }
}