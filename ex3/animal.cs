/*Sobreposição ou sobrescrita ocorre quando uma classe herda um método de sua classe base e sobreescreve oque aquele metodo faz.*/

public class animal{
    public virtual void emitirSom(){
        Console.WriteLine("animal fazendo barulho");
    }
}