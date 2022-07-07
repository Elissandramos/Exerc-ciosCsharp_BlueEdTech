using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosAula09 {
    class Program {
        static void Main(string[] args)
        {
            Exercicio01();
            //Exercicio02();
            //Exercicio03();
            //Exercicio04();
            //Exercicio05();
        }
        static void Exercicio01()
        {   /*Faça um programa que calcule a área de uma figura geométrica planas. 
             * Aceite quatro tipos de figura geométrica: quadrado, retângulo, triângulo e círculo. 
             * Utilize as fórmulas abaixo para chegar na área das figuras planas.*/

            // classe mãe -> FiguraGeometrica
            // classe filhas -> triangulo, quadrado
            // para ter um metodo da classe mae herdado,
            // tem que ter na classe mae o nome  "virtual" ou nome "abstract" 
            // a filha pra herdar da mãe precisa ter os dois pontos

            // instanciei e inicializei a classe filha ja passando
            // como parametro o valor "lado" e "altura"            
            //Quadrado q1 = new Quadrado(2, 2);
            //Triangulo t1 = new Triangulo(2, 2);

            // pedindo input do usuario, a inicializacao e instanciacao
            // tem que fazer separado


            Console.WriteLine("Digite Figura que deseja Calcular Area:\n" +
                               "[1] quadrado \n" +
                               "[2] triangulo \n ");

            int opcao = int.Parse(Console.ReadLine());

            //inicializacao
            Quadrado q1;
            Triangulo t1;

            Console.WriteLine("Entre com o valor do lado");
            int lado = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor da altura");
            int altura = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    //instanciação
                    q1 = new Quadrado(lado, altura);
                    Console.WriteLine($"A área do quadrado é {q1.CalculaArea()} ");
                    break;
                case 2:
                    //instanciação
                    t1 = new Triangulo(lado, altura);
                    Console.WriteLine($"A área do triangulo é {t1.CalculaArea()} ");
                    break;
            }

            Console.ReadLine();

        }
    }
}
