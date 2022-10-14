using ContaBancaria.Models;


//Classe Alunos herda da classe pessoa

Alunos a1 = new Alunos();
a1.Nome = "Paulo";
a1.Idade = 30;
a1.Email = "ola@gmail.com";
a1.Nota = 10;
a1.Apresentar();

//Criando Polimorfismo
Professor p1 = new Professor();
p1.Nome = "João Pedro";
p1.Idade = 50;
p1.Salario = 2000;
p1.Apresentar();


/**
//Instanciando a classe
//Criando um objeto da classe

ContaBank c1 = new ContaBank(123, 1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();
**/
