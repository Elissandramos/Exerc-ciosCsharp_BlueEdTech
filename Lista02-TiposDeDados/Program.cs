using System;
using System.Globalization;
using System.Text;

namespace ExercíciosAula02 {
    class Program {
        static void Main(string[] args)
        {
            Exercício01();
            // Faça um programa que pergunte ao usuário ano de nascimento e imprima sua idade.

            //Exercício02();
            // Escreva um programa que leia 10 valores inteiros e ao final exiba a soma dos números.

            //Exercício03();
            /* Escreva um programa que leia o número de horas trabalhadas e um funcionário, o valor
               que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário,
               com duas casas decimais. */

            //Exercício04();
            // Leia um valor inteiro correspondente à idade de uma pessoa e mostre-a em anos, meses e dias.
            // Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca
            //haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas um exercício com objetivo
            //de testar raciocínio matemático simples.                

            //Exercício05();
            //   Construa um conversor de moedas:
            /*Crie um programa que solicite um valor em real ao usuário e converta esse valor, para:
                DOLAR, EURO, LIBRA ESTERLINA, DÓLAR CANADENSE, PESO ARGENTINO,PESO CHILENO
                Para esse exercício você precisará realizar uma pesquisa para saber a cotação de cada moeda em real.
                Mostrar o resultado no formato símbolo da moeda e valor, como o exemplo R$ 10,00 para a moeda real. */
        }
        static void Exercício01()
        {
            // Faça um programa que pergunte ao usuário ano de nascimento e imprima sua idade.
            Console.WriteLine("Digite ano do seu nascimento");
            int anoNascimento = int.Parse(Console.ReadLine());
            int idade = 2022 - anoNascimento;
            Console.WriteLine("Sua idade é:" + idade);
        }
        static void Exercício02()
        {    // Escreva um programa que leia 10 valores inteiros e ao final exiba a soma dos números.
            int soma = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite um número para a posição {i}: ");
                int numero = int.Parse(Console.ReadLine());
                soma = numero + soma;
            }
            Console.WriteLine("A soma dos números é:" + soma);
        }
        static void Exercício03()
        {    /* Escreva um programa que leia o número de horas trabalhadas e um funcionário, o valor
                   que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário,
                   com duas casas decimais. */
            Console.WriteLine("----Cadastro----");
            Console.Write("Número de horas trabalhadas : ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.Write("Valor da hora de trabalho : ");
            int valorHora = int.Parse(Console.ReadLine());

            double salario = horasTrabalhadas * valorHora;

            Console.WriteLine("---------------------");
            //Console.WriteLine("o salário é: " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"o salário é: {salario.ToString("F2")}");
            // trocar o ponto pela vírgula também
            Console.WriteLine($"o salário é: {salario.ToString().Replace('.', ',')}");
        }
        static void Exercício04()
        {     /* Leia um valor inteiro correspondente à idade de uma pessoa e mostre-a em anos, meses e dias.
              Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. */

            Console.WriteLine("Digite sua idade: ");
            int idadeAnos = int.Parse(Console.ReadLine());

            int idadeMeses = idadeAnos * 12;
            int idadeDias = idadeMeses * 365;

            Console.WriteLine("------------");
            Console.WriteLine($"idadeMeses {idadeMeses}\n idadeDias {idadeDias}");
        }
        static void Exercício05()
        {
            // lembrar de adicionar a biblioteca  "System.Text";
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Digite seu valor em Reais : ");
            double reais = double.Parse(Console.ReadLine());
            double dolar = 4.55 * reais;
            double euro = 6.48 * reais;

            Console.WriteLine("----------------");
            Console.WriteLine($"O valor R$ {reais.ToString("F2").Replace('.', ',')} " +
                $"\n em dolar é $ {dolar.ToString("F2").Replace('.', ',')}" +
                $"\n em euro é € {euro.ToString("F2").Replace('.', ',')}");
        }
    }
}
