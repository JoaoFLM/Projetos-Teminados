ContaCorrente conta_ficticia01 = new ContaCorrente(01);
ContaPoupanca conta_ficticia02 = new ContaPoupanca(02);

Console.WriteLine(new Transacao("Deposito", 300, conta_ficticia01).resultado);
Console.WriteLine(conta_ficticia01.saldo);
Console.WriteLine(new Transacao("saque", 120, conta_ficticia01).resultado);
Console.WriteLine(conta_ficticia01.saldo);
Console.WriteLine(new Transacao("DepositO", 230, conta_ficticia01).resultado);
Console.WriteLine(conta_ficticia01.saldo);
Console.WriteLine(new Transacao("Saque", 400, conta_ficticia01).resultado);
Console.WriteLine(conta_ficticia01.saldo);
Console.WriteLine(new Transacao("Deposito", 120, conta_ficticia01).resultado);
Console.WriteLine(conta_ficticia01.saldo);
Console.WriteLine(new Transacao("Saque", 50, conta_ficticia01).resultado);
Console.WriteLine(conta_ficticia01.saldo);

Console.WriteLine(new Transacao("Deposito", 300, conta_ficticia02).resultado);
Console.WriteLine(conta_ficticia02.saldo);
Console.WriteLine(new Transacao("saque", 300, conta_ficticia02).resultado);
Console.WriteLine(conta_ficticia02.saldo);
Console.WriteLine(new Transacao("Deposito", 300, conta_ficticia02).resultado);
Console.WriteLine(conta_ficticia02.saldo);
Console.WriteLine(new Transacao("saque", 150, conta_ficticia02).resultado);
Console.WriteLine(conta_ficticia02.saldo);
Console.WriteLine(new Transacao("saque", 150, conta_ficticia02).resultado);
Console.WriteLine(conta_ficticia02.saldo);




