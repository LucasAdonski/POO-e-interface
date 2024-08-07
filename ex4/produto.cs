public class Produto{
    public string Nome{get;set;}
    public double Preco{get;set;}
    public int QuantidadeEmEstoque{get;set;}

    public Produto(string nome, double preco, int quantidadeEmEstoque)
    {
        this.Nome = nome;
        this.Preco = preco;
        this.QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void addEstoque(int quantidade)
    {
        if (quantidade <= 0){
            System.Console.WriteLine("A quantidade a ser adicionada deve ser maior que zero.");
        }
        else{
            this.QuantidadeEmEstoque += quantidade;
            System.Console.WriteLine("Quantidade adicionada ao estoque");
        }
    }

    public void removerEstoque(int quantidade)
    {
        if (quantidade <= 0){
            System.Console.WriteLine("A quantidade a ser removida deve ser maior que zero.");
        }

        if(quantidade > QuantidadeEmEstoque){
            System.Console.WriteLine("Não há estoque suficiente para remover essa quantidade.");
        }
        else{
            this.QuantidadeEmEstoque -= quantidade;
            System.Console.WriteLine("Quantidade removida do estoque!");

        }
    }

    public void CalcularValorTotalEmEstoque()
    {
        double valor = Preco * QuantidadeEmEstoque;
        System.Console.WriteLine("O valor da quantidade total em estoque eh: " + valor);
    }
}