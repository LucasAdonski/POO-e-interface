public class CursoIngles : Curso{

    public CursoIngles(string nome, int duracaoHoras, int nivel) : base(nome, duracaoHoras, nivel){
    }

    public void gerarCertificado(){
        base.gerarCertificado();
    }
}