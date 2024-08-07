public class CursoEspanhol : Curso{

    public CursoEspanhol(string nome, int duracaoHoras, int nivel) : base(nome, duracaoHoras, nivel){  
    }

    public void gerarCertificado(){
        base.gerarCertificado();
    }
}
