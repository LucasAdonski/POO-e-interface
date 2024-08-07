/*Aqui é a superclasse ela que possui as variaveis principais que serao herdadas da subclasse*/

public class funcionario{
    public string nome{get;set;}
    public float salario{get;set;}

    public void info(){
        System.Console.WriteLine("Nome: " + this.nome + "\n" + "Salario: " + this.salario);
    }
}