public class Carro : Veiculo{
    public int numPortas{get;set;}

    public Carro(string marca, string modelo, int ano, int numeroPortas) : base(marca, modelo, ano){
        this.numPortas = numeroPortas;
    }

    public void exibirDetalhes()
    {
        base.exibirDetalhes();
        Console.WriteLine("Numero de portas: " + this.numPortas + "\n");
    }
}