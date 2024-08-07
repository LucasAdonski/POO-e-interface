public class Moto : Veiculo{
    public int Cilindrada{get;set;}

    public Moto(string marca, string modelo, int ano, int cilindrada) : base(marca, modelo, ano){
        this.Cilindrada = cilindrada;
    }

    public void exibirDetalhes()
    {
        base.exibirDetalhes();
        Console.WriteLine("Cilindrada: " + this.Cilindrada + "\n");
    }
}