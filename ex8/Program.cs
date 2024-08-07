CursoIngles cursoIngles = new CursoIngles("Ingles Avançado", 100, 3);
CursoEspanhol cursoEspanhol = new CursoEspanhol("Espanhol Basico", 60, 1);
CursoFrances cursoFrances = new CursoFrances("Frances Intermediario", 80, 2);

cursoIngles.AdicionarNota(7);
cursoIngles.AdicionarNota(5);
cursoIngles.AdicionarNota(10);

cursoEspanhol.AdicionarNota(8);
cursoEspanhol.AdicionarNota(9);
cursoEspanhol.AdicionarNota(4);

cursoFrances.AdicionarNota(9);
cursoFrances.AdicionarNota(10);
cursoFrances.AdicionarNota(8);


Console.WriteLine("Media do curso de Ingles: " + cursoIngles.CalcularMedia());
Console.WriteLine("Media do curso de Espanhol: " + cursoEspanhol.CalcularMedia());
Console.WriteLine("Media do curso de Frances: " + cursoFrances.CalcularMedia() + "\n");


cursoIngles.gerarCertificado();
cursoEspanhol.gerarCertificado();
cursoFrances.gerarCertificado();
