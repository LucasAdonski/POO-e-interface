public class gerente : funcionario{
    /*aqui eu herdei " : " as variaveis de "funcionarios" e chamei a mesma funcao*/
    public void info(){
        System.Console.WriteLine("Nome: " + this.nome + "\n" + "Salario: " + this.salario);
    }

}