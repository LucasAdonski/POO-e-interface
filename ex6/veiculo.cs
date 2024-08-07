public class Veiculo{
    public string Marca{get;set;}
    public string Modelo{get;set;}
    public int Ano{get;set;}

    public Veiculo(string marca, string modelo, int ano)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Ano = ano;
    }

    public virtual void exibirDetalhes()
    {
        Console.WriteLine("Marca: " + this.Marca);
        Console.WriteLine("Modelo: " + this.Modelo);
        Console.WriteLine("Ano: " + this.Ano);
    }
}