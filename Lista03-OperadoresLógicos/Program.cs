using System;
using System.Globalization;
using System.Linq;

namespace ExercíciosAula03 {
    class Program {
        static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            //Exercicio04();
            Exercicio05();
        }
        static void Exercicio01()
        {  /*Leia um valor de ponto flutuante com duas casas decimais. 
            Este valor representa um valor monetário. A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2.
            */

            // qtde de cédulas de 100, 50, 20, 10, 5, 2
            int notaCem, notaCinquenta, notaVinte, notaDez, notaCinco, notaDois;

            Console.WriteLine("Digite um número com duas casas decimais:");
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // se dividir e converter, pega apenas o numero inteiro da divisão.
            notaCem = (int)number / 100;
            double resto = number % 100;

            notaCinquenta = (int)resto / 50;
            resto %= 50;
            //o mesmo que resto = resto % 50;

            notaVinte = (int)resto / 20;
            resto %= 20;

            notaDez = (int)resto / 10;
            resto %= 10;

            notaCinco = (int)resto / 5;
            resto %= 5;

            notaDois = (int)resto / 2;


            Console.WriteLine($"Quantidade de notas" +
                               "\n de 100: " + notaCem +
                               "\n de 50: " + notaCinquenta +
                               "\n de 20: " + notaVinte +
                               "\n de 10: " + notaDez +
                               "\n de 5: " + notaCinco +
                               "\n de 2: " + notaDois
                               );

        }
        static void Exercicio02()
        {   /* Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “x é o maior”.
            Exemplo de Entrada 7 14 106 ->  Exemplo de Saída 106 é o maior */

            int maior = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite um numero inteiro para a posição {i} : ");
                int number = int.Parse(Console.ReadLine());

                if (number > maior)
                {
                    maior = number;
                }
            }
            Console.WriteLine($"O maior número é: {maior}");
        }
        static void Exercicio03()
        {   /*  Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno. 
                Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal. 
                Imprima se o aluno foi aprovado ou reprovado considerando a média 7.   */

            double[] notas = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Digite a nota {i + 1} do aluno: ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            double media = (notas[0] + notas[1] + notas[2]) / 3;
            Console.WriteLine($"A média do aluno é:{media.ToString("F2").Replace('.', ',')}");

            //string result = media > 7 ? "O aluno está aprovado" : "O aluno está reprovado";
            //Console.WriteLine(result);

            // condição ? condição verdadeira : condição falsa
            string result = media > 7 ? "O aluno está aprovado" : (media < 7 && media > 5) ? "O aluno está de recuperação" : "O aluno está reprovado";

            Console.WriteLine(result);

            /*
            if (media > 7)
            {
                Console.WriteLine("O aluno está aprovado");
            }
            else if (media < 7 && media > 5)
            {
                Console.WriteLine("O aluno está de recuperação");
            }
            else
            {
                Console.WriteLine("O aluno está reprovado");
            }   
            */


        }
        static void Exercicio04()
        { /* Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.
            Se a nota for menor que 6.0, deve exibir a nota F.
            Se a nota for de 6.0 até 7.0, deve exibir a nota D.
            Se a nota for entre 7.0 e 8.0, deve exibir a nota C.
            Se a nota for entre 8.0 e 9.0, deve exibir a nota B.
            Se a nota fot entre 9.0 e 10.0, deve exibir um belo de um A.
            Não esqueça de adicionar uma mensagem após a nota, pode ser um simples parabéns para aprovação 
            ou algo mais complexo. */

            double[] notas = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Digite a nota {i + 1} do aluno: ");
                notas[i] = double.Parse(Console.ReadLine());
            }
            double media = notas.Average();

            string result = (media < 6) ? "F" : (media < 7) ? "D" : (media < 8) ? "C" : (media < 9) ? "B" : "A";
            Console.WriteLine("a nota do aluno é : " + result);



        }
        static void Exercicio05()
        {   /*A Blue resolveu dar um aumento de salários a seus funcionários de acordo com os dados abaixo:
            Salário de 0 até 400.00 ganha 15% Salário de 400.01 até 800.00 ganha 12% Salário de 800.01 até 1200.00,
             ganha 10% Salário de 1200.01 até 2000.00 ganha 7% Acima de 2000.00 ganha 4%
            Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual. */

            Console.WriteLine("Digite o salário do funcionário: ");
            double salario = double.Parse(Console.ReadLine());

            /*double aumento = 0.00;
            if (salario < 400)
            { aumento = 0.15; }
            else if (salario < 800)
            { aumento = 0.12; }
            else if (salario < 1200)
            { aumento = 0.10; }
            else if (salario < 2000)
            { aumento = 0.07; }
            else {aumento = 0.04;}  */

            //string result = (media < 6) ? "F" : (media < 7) ? "D" : (media < 8) ? "C" : (media < 9) ? "B" : "A";

            //ternário
            double aumento = (salario < 400) ? 0.15 : (salario < 800) ? 0.12 : (salario < 1200) ? 0.10 : (salario < 2000) ? 0.07 : 0.04;

            //salario = salario + (salario * aumento) ;
            salario += (salario * aumento);

            Console.WriteLine($"O percentual de aumento é:{aumento} \n salário final é: {salario.ToString("F2")} .");

        }
    }
}
