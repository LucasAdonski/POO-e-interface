public class Curso{
    public string Nome{get;set;}
    public int DuracaoHoras{get;set;}
    public bool Concluido{get;set;}
    public int Nivel{get;set;}
    public List<int> notas = new List<int>();

    public Curso(string nome, int duracaoHoras, int nivel){
        this.Nome = nome;
        this.DuracaoHoras = duracaoHoras;
        this.Concluido = false;
        this.Nivel = nivel;
    }

    public void AdicionarNota(int nota){
        notas.Add(nota);
    }

    public double CalcularMedia()
    {
        if (Nivel == 3)
        {
            int soma = 0;
            foreach (int nota in notas){
            soma += nota;
            }

            return (double)soma / notas.Count;
            }

        else{
            Console.WriteLine("Apenas cursos de nivel avançado calculam media.");
            return double.NaN;
        }
    }

    public void gerarCertificado(){
        Console.WriteLine("Certificado de conclusao do curso: " + this.Nome);
    }
}