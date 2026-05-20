// /////////////////////////////
// using prova_sobre_objeto;

// Pessoa pessoa =  new Pessoa();
// Aluno aluno =  new Aluno();
// Professor professor =  new Professor();
// Diretor diretor = new Diretor();

// /////////
// pessoa.Nome = "Samuel Gomes";
// pessoa.Idade = 17 ;
// pessoa.Apresentar();

// aluno.Nome = "Mateus";
// aluno.Idade = 17 ;
// aluno.Nota = 9.5 ;
// aluno.Apresentar();

// professor.Nome = "Flexa BYD";
// professor.Salario = 10000;
// professor.Apresentar();

// diretor.Nome = "Elvis Presley";
// diretor.Salario = 10000;
// diretor.Apresentar();

// //// questao 2 ////////
// using prova_sobre_objeto;


// Funcionario funcionario = new Funcionario();
// funcionario.Nome = "Samuel";
// funcionario.Salario = 1600;
// funcionario.Mostrar();


// Gerente gerente = new Gerente();
// gerente.Nome = "Flexa/BYD";
// gerente.Mostrar();
// Console.WriteLine(" O gerente recebe um salário com bonus de aproximadamente" + (gerente.Salario + gerente.CalcularBonus()));
// Console.WriteLine("O bônus é R$" + (gerente.CalcularBonus()));

// Desenvolvedor desenvolvedor = new Desenvolvedor();
// desenvolvedor.Nome = "Marquinhos devs";
// Console.WriteLine("O bônus é R$" + (desenvolvedor.CalcularBonus()));
// Console.WriteLine(" O desenvolvedor recebe um salário com bonus de aproximadamente" + (desenvolvedor.Salario + desenvolvedor.CalcularBonus()));
// desenvolvedor.Mostrar();

// Estagiarios estagiarios = new Estagiarios();
// estagiarios.Nome = "Samuel e Alice";
// Console.WriteLine("O bônus é R$" + (estagiarios.CalcularBonus()));
// Console.WriteLine(" O estagiario recebe um salário com bonus de aproximadamente" + (estagiarios.Salario + estagiarios.CalcularBonus()));
// estagiarios.Mostrar();


// /questao 3
// using prova_sobre_objeto;

// ContaCorrente contacorrente = new ContaCorrente();

// Console.WriteLine("Valor Inicial = R$" + contacorrente.Saldo);

// contacorrente.Numero = 1;
// contacorrente.Titular = "Matheus";

// contacorrente.TaxaSaque = 5;

// Console.WriteLine("Depositando R$1000...");
// contacorrente.Depositar(1000);
// Console.WriteLine("R$" + contacorrente.Saldo);
// Console.WriteLine("Sacando R$100...");
// contacorrente.Sacar(100);
// Console.WriteLine($"Saldo Conta Corrente: {contacorrente.Saldo}");


// ContaPoupanca contapoupanca = new ContaPoupanca();
// contapoupanca.Numero = 2;
// contapoupanca.Titular = "Carlos";

// Console.WriteLine("Depositando R$2000...");
// contapoupanca.Depositar(2000);
// Console.WriteLine("R$" + contapoupanca.Saldo);
// contapoupanca.Render(0.10);

// Console.WriteLine("Rendeu 10% !!! ");
// Console.WriteLine($"Saldo Conta Poupança: {contapoupanca.Saldo}");