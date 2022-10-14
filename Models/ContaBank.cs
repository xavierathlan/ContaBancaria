using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaBancaria.Models
{
    public class ContaBank
    {
        //Criando um construtor
        public ContaBank(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        //Criando duas propriedades para a classe
        public int NumeroConta { get; set; }

        private decimal saldo;

        //Criando um método para a classe
        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Você não possui saldo suficiente para efetuar este saque!");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é:" + saldo);
        }
    }
}