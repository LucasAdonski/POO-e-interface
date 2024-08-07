public class Transferencia : IMetodoPagamento{
    public bool transferenciaConfirmada{get;set;}   
    public void RealizarPagamento(double valor){
        Console.WriteLine("Pagamento de " + valor + " realizado por transferência bancária." + "\n");
        transferenciaConfirmada = true;
    }

    public void CancelarTransferencia(){
        if (transferenciaConfirmada == true){
            Console.WriteLine("Transferência cancelada!" + "\n");
            transferenciaConfirmada = false;
        }
        else{
            Console.WriteLine("Não é possível cancelar a transferência!" + "\n");
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