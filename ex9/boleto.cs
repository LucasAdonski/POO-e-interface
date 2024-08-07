public class Boleto : IMetodoPagamento{
    public bool transferenciaConfirmada{get;set;}
    public double valorDoPagamento{get;set;}
    public void RealizarPagamento(double valor){
        this.valorDoPagamento= valor;
        Console.WriteLine("Boleto de " + valorDoPagamento + " gerado e aguardando pagamento." + "\n");
        this.transferenciaConfirmada = true;    
    }

    public void gerarRecibo(string nomeCliente, string metodoPagamento){
        Console.WriteLine("--Comprovante de Pagamento!--");
        Console.WriteLine("Cliente: " + nomeCliente);
        Console.WriteLine("Método de Pagamento: " + metodoPagamento);
        Console.WriteLine("Valor: " + this.valorDoPagamento + "\n");
    }

    public void VerificarStatusPagamento(){
        if (transferenciaConfirmada == true){
            Console.WriteLine("Transferência confirmada" + "\n");
        }
        else{
            Console.WriteLine("Transferência não confirmada" + "\n");
        }
    }
}