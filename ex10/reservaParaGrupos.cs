public class ReservaParaGrupos : ReservaBase{
    public void ReservarVoo(){
        Console.WriteLine("Reserva para grupo confirmada.");
        status = "Confirmada";
    }
}