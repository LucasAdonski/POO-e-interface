public class cartaoCredito : IMetodoPagamento{
    public string numCartao{get;set;}
    public bool transferenciaConfirmada{get;set;} 
    public void RealizarPagamento(double valor){
        Console.WriteLine("Pagamento de " + valor + " realizado com cartão de crédito." + "\n");
    }

    public void ValidarNumero(string numeroCartao){
        if (numeroCartao.Length != 16)
        {
            System.Console.WriteLine("A quantidade de numeros do seu cartao nao eh valida!" + "\n");
        }
        else{
            System.Console.WriteLine("Valor debitado!" + "\n");
            transferenciaConfirmada = true;
        }
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
