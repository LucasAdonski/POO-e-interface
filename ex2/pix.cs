public class pix : iPagamento{
    public double preco{get;set;}
    public string produto{get;set;}

    public void ProcessarPagamento(double valor)
    {
        if(valor >= preco){
            valor -= preco;
            System.Console.WriteLine("Pagamento efetuado por pix");
        }
        else{
            System.Console.WriteLine("Saldo insuficiente!");
        }
    }
}