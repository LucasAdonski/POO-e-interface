Transferencia transferencia = new Transferencia();

cartaoCredito cartaoCredito1 = new cartaoCredito();

cartaoCredito cartaoCredito2 = new cartaoCredito();

Boleto boleto = new Boleto();

transferencia.RealizarPagamento(200);
cartaoCredito1.RealizarPagamento(20);
boleto.RealizarPagamento(100);

transferencia.CancelarTransferencia();

cartaoCredito1.ValidarNumero("1234567891234567");
cartaoCredito2.ValidarNumero("345275289");

boleto.gerarRecibo("Lucas", "Boleto Bancario");

transferencia.VerificarStatusPagamento();
cartaoCredito1.VerificarStatusPagamento();
cartaoCredito2.VerificarStatusPagamento();
boleto.VerificarStatusPagamento();

