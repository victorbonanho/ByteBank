using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "Andre Silva";
//conta1.conta = "10123-X";
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Agencia Central";
//conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Amanda Silva";
//conta2.conta = "111999-X";
//conta2.numero_agencia = 58;
//conta2.nome_agencia = "Agência Central";
//conta2.saldo = 100;

//Console.WriteLine("Saldo da Amanda pré-transferênncia: " + conta2.saldo);
//Console.WriteLine("Saldo do André pré-transferênncia: " + conta1.saldo);
////conta1.Transferir(50, conta2);
//bool transferencia = conta1.Transferir(50, conta2);
//Console.WriteLine("Transferencia realizada com sucesso " + transferencia);
//Console.WriteLine("Saldo da Amanda pós-transferênncia: " + conta2.saldo);
//Console.WriteLine("Saldo do André pós-transferênncia: " + conta1.saldo);

//conta1 = conta2;
//Console.WriteLine(conta1 == conta2);

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Número Agencia: " + conta1.numero_agencia);
//Console.WriteLine("Nome Agencia: " + conta1.nome_agencia);
//Console.WriteLine("Saldo: " + conta1.saldo);

//ContaCorrente conta = new ContaCorrente();
//Console.WriteLine($"Titular da conta: {conta.titular}");
//Console.WriteLine($"Número da conta: {conta.conta}");
//Console.WriteLine($"Agência: {conta.numero_agencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");
//double saldo = 100;
//double saldo2 = conta1.saldo;
//Console.WriteLine(saldo == conta1.saldo);
//Console.WriteLine(saldo == saldo2);

//Console.WriteLine("Saldo da Amanda pré-saque " + conta2.saldo);
//conta2.Sacar(50);

//bool saque = conta2.Sacar(50);
//Console.WriteLine("Saque realizado?" + saque);

//Console.WriteLine("Saldo da Amanda pós-saque " + conta2.saldo);

//conta2.Depositar(60);
//bool depositar = conta2.Depositar(60); Não posso converter void em boleano

//Console.WriteLine("Saldo da Amanda pós-depósito " + conta2.saldo);

//Cliente cliente = new Cliente();
//cliente.nome = "Andre Silva";
//cliente.cpf = "13242535";
//cliente.profissao = "Programador C#";

//bytebank.Titular.Cliente sarah = new bytebank.Titular.Cliente();
//Cliente sarah = new Cliente();
//Console.WriteLine("Olá!"); //Já é pre definida a classe Console e seu using

//Cliente cliente = new Cliente();
//cliente.nome = "Andre Silva";
//cliente.cpf = "234567456";
//cliente.profissao = "Programador C#";

//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular = new Cliente();
//conta3.titular.nome = "André Silva";
//conta3.titular.profissao = "Programador C#";
//conta3.titular.cpf = "123456";
//conta3.conta = "4567898-X";
//conta3.numero_agencia = 35;
//conta3.nome_agencia = "Agencia Central";

////Console.WriteLine(cliente.nome);
////Console.WriteLine(conta3.titular.nome);
//if(conta3.titular==null)
//{
//    Console.WriteLine("O campo titular esta nulo");
//}

//Cliente sarah = new Cliente();
//sarah.Nome = "Sarah Silva";

//ContaCorrente conta4 = new ContaCorrente(235, "123456-X");
//conta4.Saldo = 100;//Boa prática
//conta4.Titular = sarah;
////conta4.Numero_Agencia = -10;
////conta4.Conta = "";
//Console.WriteLine(conta4.Titular.Nome);
//Console.WriteLine(conta4.Saldo);
//Console.WriteLine(conta4.Numero_Agencia);
//Console.WriteLine(conta4.Conta);

//Console.WriteLine("Saldo: " + conta4.GetSaldo());

//Isso não dá bom -> Terá que adicionar a condição no contructor
//ContaCorrente conta5 = new ContaCorrente(367, "765454-X");
//conta5.TotalDeContasCriadas = 1;
//ContaCorrente conta6 = new ContaCorrente(258, "234565-X");
//conta6.TotalDeContasCriadas += 1;
//Console.WriteLine(conta5.TotalDeContasCriadas);
//Console.WriteLine(conta6.TotalDeContasCriadas);

//Mas isso da bom
ContaCorrente conta5 = new ContaCorrente(new Cliente(), "Bancao", 159, "152869-x");
ContaCorrente conta6 = new ContaCorrente(new Cliente(), "Bancao", 159, "152869-x");

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
Console.WriteLine(conta6);

Cliente sarah = new Cliente();
sarah.Nome = "Sarah Silva";
sarah.Profissao = "Professora";
sarah.Cpf = "11111111-12";

Cliente ester = new Cliente();
ester.Nome = "Ester Almeida";
ester.Profissao = "Advogada";
ester.Cpf = "868524125-32";

Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);

ContaCorrente contaAndre = new ContaCorrente(new Cliente(),"Bancao",159, "152869-x");
contaAndre.Titular = new Cliente();
contaAndre.Titular.Nome = " André Pereira";
contaAndre.Titular.Profissao = "Auxiliar Administrativo";
contaAndre.Saldo = 100;

Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);

Console.ReadKey();
