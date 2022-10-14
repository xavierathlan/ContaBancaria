using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaBancaria.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        //Permite subscrever os métodos das outras classes com a palavra (virtual)
        //Nas outras classes, usamos a palavra override para criarmos nosso próprio 
        //método Apresentar (Polimorfismo)
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}