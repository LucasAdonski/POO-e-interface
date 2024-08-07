/*Interfaces em orientação a objetos são contratos que definem um conjunto de métodos e propriedades que uma classe deve implementar.
Elas são usadas para definir um comportamento comum que várias classes podem seguir. Em C#, uma interface é declarada usando a palavra-chave interface.
A importância das interfaces na construção de sistemas em C# está relacionada à flexibilidade e extensibilidade que elas proporcionam ao código.
(essa explicação foi o chatGPT que respondeu professor), segundo essa base eu ja implementei as variaveis dentro da interface mas ficou estranho
no program.cs mas funcionou. Pensei que assim as outras classes iriam herda elas mas infelizmente so consegui fazer rodar fazendo a declaracao em
todas as classes!*/

public interface iPagamento{
    public string produto{get;set;}
    public double preco{get;set;}
    void ProcessarPagamento(double valor);
}