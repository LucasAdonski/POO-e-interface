public class Bicicleta : Veiculo{
    public int numMarchas{get; set;}

    public Bicicleta(string marca, string modelo, int ano, int numeroMarchas) : base(marca, modelo, ano){
        this.numMarchas = numeroMarchas;
    }

    public void exibirDetalhes(){
        base.exibirDetalhes();
        Console.WriteLine("Número de marchas: " + this.numMarchas + "\n");
    }
}