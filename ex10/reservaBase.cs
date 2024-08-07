public class ReservaBase : iReserva{
    public string status = "Pendente";

    public void ReservarVoo(){
        status = "Confirmada";
        Console.WriteLine("Reserva confirmada.");
    }

    public void CancelarReserva(){
        status = "Cancelada";
        Console.WriteLine("Reserva cancelada.");
    }

    public void VerificarStatus(){
        System.Console.WriteLine("Reserva esta: " + status);
    }
}