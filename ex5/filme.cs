public class Filme{
    public string Titulo{get;set;}
    public string Genero{get;set;}
    public int Duracao{get;set;}
    public bool Disponivel{get;set;}

    public Filme(string titulo, string genero, int duracao){
        Titulo = titulo;
        Genero = genero;
        Duracao = duracao;
        Disponivel = true;
    }

    public void Locacao(){
        if (Disponivel == true)
        {
            System.Console.WriteLine(this.Titulo + " foi alocado!");
            Disponivel = false;
        }
        else{
            System.Console.WriteLine("Filme indisponivel!");
        }
    }

    public void Devolucao(){
        if (Disponivel == false)
        {
            System.Console.WriteLine(this.Titulo + " foi devolvido");
            Disponivel = true;
        }
        else{
            System.Console.WriteLine("Voce nao alocou este filme, porque ele esta disponivel!");
        }
    }

    public void estaDisponivel(){
        if (Disponivel == false)
        {
            System.Console.WriteLine(this.Titulo + " esta indisponivel");
        }
        else{
            System.Console.WriteLine(this.Titulo + " esta disponivel!");
        }
    }
}