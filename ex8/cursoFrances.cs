public class CursoFrances : Curso{

    public CursoFrances(string nome, int duracaoHoras, int nivel) : base(nome, duracaoHoras, nivel){
    }
    public void gerarCertificado(){
        base.gerarCertificado();
    }
}