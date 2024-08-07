/*Iniciei com a interface, do tipo de cada forma de pagamento,
declarei as variaveis e chamei a funcao de cada pagamento*/

iPagamento cartaoD = new cartaoDebito();
cartaoD.preco = 2000;
cartaoD.produto = "Geladeira";
cartaoD.ProcessarPagamento(2000);

iPagamento cartaoC = new CartaoCredito();
cartaoC.preco = 12;
cartaoC.produto = "Doritos";
cartaoC.ProcessarPagamento(11);

iPagamento Pix = new pix();
Pix.preco = 200;
Pix.produto = "Ventilador";
Pix.ProcessarPagamento(300);


