ContaCorrente conta1 = new ContaCorrente("123");
ContaPoupanca conta2 = new ContaPoupanca("456");
ContaEmpresarial conta3 = new ContaEmpresarial("789");

conta1.Depositar(500);
conta2.Depositar(200);
conta3.Depositar(300);

conta1.Sacar(200);
conta2.Sacar(100);
conta3.Sacar(400);

conta2.calcularJuros();

conta1.mostrarSaldo();
conta2.mostrarSaldo();
conta3.mostrarSaldo();
