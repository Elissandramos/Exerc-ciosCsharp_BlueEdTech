using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosAula07_ {
    class ContaBancaria {

        // atributos já sendo aplicados com autopropriedades
        public int NumeroConta { get; private set; }
        // o set nao esta como private pois o nome do cliente pode mudar
        public string NomeCliente { get; set; }
        public double Saldo { get; private set; }

        // construtor com dois argumentos
        public ContaBancaria(int numeroConta, string nomeCliente)
        {
            NumeroConta = numeroConta;
            NomeCliente = nomeCliente;
        }
        // construtor com 3 argumentos, sendo que 2 são subscritos, herdado do construtor superior indicado pelo :
        public ContaBancaria(int numeroConta, string nomeCliente, double saldo) : this(numeroConta, nomeCliente)
        {
            Saldo = saldo;
        }

        //metodos personalizados
        public string AterarNome(string nomeatualizado)
        {
            NomeCliente = nomeatualizado;
            return NomeCliente;
        }
        public double RealizarDeposito(double deposito)
        {
            Saldo = Saldo + deposito;
            return Saldo;
        }

        // uso do Tostring um metodo especial de objetos usado apenas para imprimir de forma personalizada.
        public override string ToString()
        {
            return $"Conta:{NumeroConta}, Titular:{NomeCliente}, Saldo: R${Saldo.ToString("")}";
        }




    }
}
