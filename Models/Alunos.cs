using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaBancaria.Models
{
    //Herdando da classe Pessoa
    public class Alunos : Pessoa
    {
        //Subscrevendo o método Apresentar da classe principal Pessoa
        //com a palavra override, e criando meu próprio método Apresentar (Polimorfismo)
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota 10");
        }
    }
}