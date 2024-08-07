public class CartaoCredito : iPagamento{
    public double preco{get;set;}
    public string produto{get;set;}

    public void ProcessarPagamento(double valor)
    {
        if(valor >= preco){
            System.Console.WriteLine("Pagamento efetuado por credito");
        }
        else{
            System.Console.WriteLine("Saldo insuficiente!");
        }
    }
}