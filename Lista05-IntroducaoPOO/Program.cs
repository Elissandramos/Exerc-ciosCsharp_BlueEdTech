using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosAula05 {
    class Program {
        static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();
            Exercicio03();


        }
        static void Exercicio01()
        {
            /*
            Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina. 
            Cada objeto dessa classe deve guardar os seguintes dados do aluno: matrícula, nome, 2 notas de prova e 1 nota de trabalho.
            Escreva os seguintes métodos para esta classe:
            Calcular média: calcula e exibe a média final do aluno com base em suas notas;
            Calculo nota final: calcula quanto o aluno precisa tirar na prova final para ser aprovado. */

            ClassAluno Aluno1;          // declarar
            Aluno1 = new ClassAluno();  // instanciar     
                                        //pode ser assim também instanciae declarar ao mesmo tempo -> ClassAluno Aluno1 = new ClassAluno();

            Console.WriteLine("--- Inserir dados dos alunos ---");

            Console.Write("Matricula: ");
            Aluno1.Matricula = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            Aluno1.Nome = Console.ReadLine();

            Console.Write("Nota provaA: ");
            Aluno1.Notas[0] = double.Parse(Console.ReadLine());

            Console.Write("Nota provaB: ");
            Aluno1.Notas[1] = double.Parse(Console.ReadLine());

            Console.Write("Nota Trabalho: ");
            Aluno1.Notas[2] = double.Parse(Console.ReadLine());

            Console.WriteLine("--- Resultado dos alunos ---");
            Console.WriteLine($" Matricula: {Aluno1.Matricula} \n" +
                              $" Nome: {Aluno1.Nome} \n" +
                              $" Media: {Aluno1.Media()} \n" +
                              $" Para ser aprovado o aluno deve tirar: {Aluno1.NotaFinal()}");
            Console.ReadLine();

        }

        static void Exercicio02()
        {
            /*
            Escreva uma classe em que cada objeto representa um vôo que acontece em determinada data e em determinado horário. 
                Cada vôo possui no máximo 100 passageiros, e a classe permite controlar a ocupação das vagas.
            A classe deve ter os seguintes métodos:
            -Ocupar Vaga: ocupa determinada cadeira do vôo, cujo número é recebido como parâmetro, 
                e retorna verdadeiro se a cadeira ainda não estiver ocupada (operação foi bem sucedida) e falso caso contrário
            - Vagas Livres: retorna o número de cadeiras vagas disponíveis (não ocupadas) no vôo;
            - Cadeira Livre: Retorna o número da próxima cadeira livre;
            - Ocupa: ocupa determinada cadeira do vôo, cujo número é recebido como parâmetro. 
                Caso a cadeira esteja ocupada exibe uma mensagem, caso esteja vazia, reserva e exibe uma mensagem de confirmação;
            - Ver horário: Imprime a data e o horário do vôo.           */

            ClassVoo Voo1 = new ClassVoo();

            /*
           Console.Write("Digite Data (dia/mês/ano) :");
           Voo1.data = Console.ReadLine();

           Console.Write("Digite Horário(hora-minutos): ");
           Voo1.horario = Console.ReadLine(); */

            Console.Write("Digite o numero assento que deseja reservar: ");
            int assento = int.Parse(Console.ReadLine());

            Console.WriteLine($" vaga esta ocupada ou nao : {Voo1.ocuparVaga(assento)}");
            Console.WriteLine($" verifica se esta disponivel: {Voo1.ocupa(assento)}");
            Console.WriteLine($"Quantidade de vagas ainda disponiveis: {Voo1.VagasLivres()}");



            Console.WriteLine($" próxima vaga disponivel é: {Voo1.CadeiraLivre(assento)}");




            //Console.WriteLine($"Horario do voo: {Voo1.VerHorario()}");
            Console.ReadLine();



        }

        static void Exercicio03()
        {
            //3. Crie uma classe Calculadora, que possui como métodos a multiplicação, divisão, subtração e soma de dois valores e exibe para o usuário.
            Calculadora p1 = new Calculadora();

            Console.WriteLine("Escolha a operação que deseja realizar: \n " +
                              "[1] - Somar \n" +
                              "[2] - Subtrair \n" +
                              "[3] - Multiplicar \n" +
                              "[4] - Dividir \n" +
                              "[5] - Zerar calculadora \n"
                            );
            string opcao = Console.ReadLine();

            Console.WriteLine("Digite primeiro numero:");
            double num1digitado = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo numero:");
            double num2digitado = double.Parse(Console.ReadLine());

            switch (opcao)
            {
                case "1":
                    p1.CalculaSoma(num1digitado, num2digitado);
                    // printa uma metodo dessa forma
                    Console.WriteLine("resultado:" + p1.CalculaSoma(num1digitado, num2digitado));
                    break;

                case "2":
                    p1.CalculaSubtrair(num1digitado, num2digitado);
                    Console.WriteLine("resultado:" + p1.CalculaSubtrair(num1digitado, num2digitado));

                    break;

                case "3":
                    p1.CalculaMultiplicar(num1digitado, num2digitado);
                    Console.WriteLine("resultado:" + p1.CalculaMultiplicar(num1digitado, num2digitado));

                    break;
                case "4":
                    p1.CalculaDividir(num1digitado, num2digitado);
                    Console.WriteLine("resultado:" + p1.CalculaDividir(num1digitado, num2digitado));

                    break;
                case "5":
                    p1.CalculaZerar();
                    Console.WriteLine("resultado:" + p1.CalculaZerar());

                    break;


            }
            Console.ReadLine();





        }




    }
}
