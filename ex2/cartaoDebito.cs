public class cartaoDebito : iPagamento{
    public double preco{get;set;}
    public string produto{get;set;}

    public void ProcessarPagamento(double valor)
    {
        if(valor >= preco){
            System.Console.WriteLine("Pagamento efetuado por debito");
        }
        else{
            System.Console.WriteLine("Saldo insuficiente!");
        }
    }
}