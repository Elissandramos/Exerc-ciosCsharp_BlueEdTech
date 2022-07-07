using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosAula04 {
    class Program {
        static void Main(string[] args)
        {
            Exercicio01();
            //Exercicio02R1();
            //Exercicio02R2();
            //Exercicio03();
            //Exercicio04();
            //Exercicio05();
        }
        static void Exercicio01()
        {   /*Crie um programa que solicite a entrada de 10 números pelo usuário, armazenando - os em um vetor, e
            então monte outro vetor com os valores do primeiro multiplicados por 5.  
            Exiba os valores dos dois vetores na tela, um em cada linha.*/

            int[] numbers = new int[10];

            //recebe os dados do usuario
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Digite o numero da posição {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("-----------------------");

            //printa os dados do usuário
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] * 5);
            }
            Console.ReadLine();

        }
        static void Exercicio02R1()
        {   /* Crie um programa que armazene 10 números digitados pelo usuário em dois vetores: um somente para números
            pares, e outro somente para números ímpares. Após, exiba os valores dos dois vetores na tela, um vetor em 
            cada linha. */

            // com arrays
            int[] numbers = new int[4];
            int[] pares = new int[4];
            int[] impares = new int[4];

            // user input
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Digite o numero da posição {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] % 2 == 0)
                {
                    pares[i] = numbers[i];
                }

                if (numbers[i] % 2 != 0)
                {
                    impares[i] = numbers[i];
                }
            }
            Console.WriteLine("------------------------------------");

            // print pares  
            Console.WriteLine("pares :");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{pares[i]} - ");
            }
            // print impares
            Console.WriteLine("\nimpares :");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{impares[i]} - ");
            }


        }
        static void Exercicio02R2()
        {   /* Crie um programa que armazene 10 números digitados pelo usuário em dois vetores: um somente para números
            pares, e outro somente para números ímpares. Após, exiba os valores dos dois vetores na tela, um vetor em 
            cada linha. */

            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite um número: ");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    pares.Add(num);
                }
                else
                {
                    impares.Add(num);
                }

            }
            foreach (int elementos in pares)
            {
                Console.WriteLine(elementos);
            }
        }

        static void Exercicio03()
        {   /* Crie um programa que lê 5 palavras e as ordena em um vetor de strings pelo seu tamanho. Se o tamanho das 
        strings for igual, deve-se manter a ordem inserida pelo usuário. */

            string[] palavras = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Digite a palavra do index {i}:");
                palavras[i] = Console.ReadLine();
            }

            //usando o metodo SORT.
            //var sortedElements = Array.Sort(palavras, (x, y) => x.Length.CompareTo(y.Length));

            //usando o LINQ
            var sortedElements = from x in palavras.Distinct()
                                 orderby x.Length
                                 select x;

            //usando for each para printar
            //foreach (string elementos in sortedElements) {
            //    Console.WriteLine($"{string.Join(", ",elementos)}");
            //}

            // usando o Join para printar
            Console.WriteLine($"Palavras ordenadas:{string.Join(", ", sortedElements)}  .");

        }
        static void Exercicio04()
        {   /* Crie um programa que jogue pedra, papel e tesoura (Jokenpô) com você.
                Permitir que eu decida quantas rodadas iremos fazer;
                Ler a minha escolha (Pedra, papel ou tesoura);
                Decidir de forma aleatória a decisão do computador;
                Mostrar quantas rodadas cada jogador ganhou;
                Determinar quem foi o grande campeão de acordo com a quantidade de vitórias de cada um (computador e jogador);
                Perguntar se o Jogador quer jogar novamente, se sim inicie volte a escolha de quantidade de rodadas, se não finalize
                o programa.  */


            List<string> lista = new List<string>() { "Pedra", "Papel", "Tesoura" };

            int vit_usuario = 0;
            int vit_computer = 0;
            int empate = 0;

            string opcao = "1";
            while (opcao == "1")
            {

                Console.WriteLine("Digite quantas rodadas quer jogar: ");
                int rodadas = int.Parse(Console.ReadLine());

                for (int i = 0; i < rodadas; i++)
                {

                    Console.WriteLine("\n[0] - Pedra\n[1] - Papel\n[2] - Tesoura\nDigite sua escolha: ");
                    int jogada_usuario = int.Parse(Console.ReadLine());

                    Random random = new Random();
                    int computer = random.Next(0, 2);
                    Console.WriteLine(computer);

                    if (jogada_usuario < 0 || jogada_usuario > 2)
                    {
                        Console.WriteLine("Opção inválida.");
                        continue;
                    }
                    else
                    {
                        if (computer == 0) // pedra
                        {
                            if (jogada_usuario == 0)
                            {
                                empate += 1;
                                Console.WriteLine($"\nEmpate!\nVocê escolheu: {lista[jogada_usuario]}\nComputador: {lista[computer]}");
                            }
                            else if (jogada_usuario == 1)
                            {
                                vit_usuario += 1;
                                Console.WriteLine($"\nVocê Ganhou!\nVocê escolheu: {lista[jogada_usuario]}\nComputador: {lista[computer]}");
                            }
                            else if (jogada_usuario == 2)
                            {
                                vit_computer += 1;
                                Console.WriteLine($"\nComputador Ganhou!\nVocê escolheu: {lista[jogada_usuario]}\nComputador: {lista[computer]}");
                            }

                        }
                        else if (computer == 1) // papel
                        {
                            if (jogada_usuario == 1)
                            {
                                empate += 1;
                                Console.WriteLine($"\nEmpate!\nVocê escolheu: {lista[jogada_usuario]}\nComputador: {lista[computer]}");
                            }
                            else if (jogada_usuario == 0)
                            {
                                vit_computer += 1;
                                Console.WriteLine($"\nComputador Ganhou!\nSua escolha: {lista[jogada_usuario]}\nComputador: {lista[computer]}");
                            }
                            else if (jogada_usuario == 2)
                            {
                                vit_usuario += 1;
                                Console.WriteLine($"\nVocê ganhou!\nSua escolha: {lista[jogada_usuario]}\nComputador: {lista[computer]}");
                            }
                        }
                        else if (computer == 2) // tesoura
                        {
                            if (jogada_usuario == 2)
                            {
                                empate += 1;
                                Console.WriteLine($"\nEmpate!\nVocê escolheu: {lista[jogada_usuario]}\nComputador: {lista[computer]}");
                            }
                            else if (jogada_usuario == 1)
                            {
                                vit_computer += 1;
                                Console.WriteLine($"nComputador Ganhou!\nVocê escolheu:{lista[jogada_usuario]}\nComputador: {lista[computer]}");
                            }
                            else if (jogada_usuario == 0)
                            {
                                vit_usuario += 1;
                                Console.WriteLine($"nVocê ganhou!\nVocê escolheu: {lista[jogada_usuario]}\nComputador: {lista[computer]}");
                            }

                        }
                    }

                }

                Console.WriteLine("\nDigite 0-(Sair) ou 1-(Continuar)");
                opcao = Console.ReadLine();
            }

            if (vit_usuario > vit_computer)
            {
                Console.WriteLine($"\nVôce é o grande campeão!");
            }
            else if (vit_computer > vit_usuario)
            {
                Console.WriteLine("\nComputer é o grande campeão!");
            }
            else
            {
                Console.WriteLine("\nEmpatou!");
            }

            Console.WriteLine($"\nSuas vitórias: {vit_usuario} - total");
            Console.WriteLine($"Vitórias do Computer: {vit_computer} - total");
            Console.WriteLine($"Empates: {empate} - total");

            // espera o usuário apertar qualquer tecla...
            Console.WriteLine("\nAperte qualquer tecla para sair...");
            Console.ReadKey();


        }
        static void Exercicio05()
        {   /* Crie um algorítimo que possibilite que dua pessoas joguem o jogo da velha e exiba quem foi o vencedor.
                O tabuleiro é uma matriz de três linhas e três colunas.
                Dois jogadores escolhem uma marcação cada um, geralmente um círculo (O) e um xis (X).
                Os jogadores jogam alternadamente, uma marcação por vez, numa célula que esteja vazia.
                O objetivo é conseguir três círculos ou três xis em linha, quer horizontal, vertical ou diagonal , 
                e ao mesmo tempo, quando possível, impedir o adversário de ganhar na próxima jogada.  */

            string resposta;
            do
            {
                string[,] jogo = new string[3, 3];

                int count = 0;
                for (int l = 0; l < 3; l++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        count++;
                        jogo[l, c] = Convert.ToString(count);
                    }
                }
                Console.WriteLine("---------------------JOGO DA VELHA--------------------");
                Console.WriteLine();
                Console.WriteLine($"    {jogo[0, 0]}         |       {jogo[0, 1]}        |       {jogo[0, 2]}");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"    {jogo[1, 0]}         |       {jogo[1, 1]}        |       {jogo[1, 2]}");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"    {jogo[2, 0]}         |       {jogo[2, 1]}        |       {jogo[2, 2]}");
                int i;
                string jogada, teste;
                while (count > 0)
                {
                    Console.WriteLine("Entre com a posição que você deseja jogar");

                    i = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Entre com X ou O");
                    jogada = Console.ReadLine();

                    teste = (i == 1) ? jogo[0, 0] = jogada : (i == 2) ? jogo[0, 1] = jogada : (i == 3) ? jogo[0, 2] = jogada :
                        (i == 4) ? jogo[1, 0] = jogada : (i == 5) ? jogo[1, 1] = jogada : (i == 6) ? jogo[1, 2] = jogada :
                        (i == 7) ? jogo[2, 0] = jogada : (i == 8) ? jogo[2, 1] = jogada : jogo[2, 2] = jogada;

                    Console.WriteLine();
                    Console.WriteLine($"    {jogo[0, 0]}         |       {jogo[0, 1]}        |       {jogo[0, 2]}");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine($"    {jogo[1, 0]}         |       {jogo[1, 1]}        |       {jogo[1, 2]}");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine($"    {jogo[2, 0]}         |       {jogo[2, 1]}        |       {jogo[2, 2]}");

                    if ((jogo[0, 0] == "X" && jogo[0, 1] == "X" && jogo[0, 2] == "X") ||
                        (jogo[0, 0] == "X" && jogo[1, 0] == "X" && jogo[2, 0] == "X") ||
                        (jogo[0, 1] == "X" && jogo[1, 1] == "X" && jogo[2, 1] == "X") ||
                        (jogo[0, 0] == "X" && jogo[1, 1] == "X" && jogo[2, 2] == "X") ||
                        (jogo[0, 2] == "X" && jogo[1, 1] == "X" && jogo[0, 2] == "X") ||
                        (jogo[2, 0] == "X" && jogo[2, 1] == "X" && jogo[2, 2] == "X") ||
                        (jogo[1, 0] == "X" && jogo[1, 1] == "X" && jogo[1, 2] == "X") ||
                        (jogo[0, 2] == "X" && jogo[2, 1] == "X" && jogo[2, 2] == "X"))
                    {
                        Console.WriteLine("O Jogador X ganhou!");
                        break;

                    }
                    else if ((jogo[0, 0] == "O" && jogo[0, 1] == "O" && jogo[0, 2] == "O") ||
                        (jogo[0, 0] == "O" && jogo[1, 0] == "O" && jogo[2, 0] == "O") ||
                        (jogo[0, 1] == "X" && jogo[1, 1] == "O" && jogo[2, 1] == "O") ||
                        (jogo[0, 0] == "O" && jogo[1, 1] == "O" && jogo[2, 2] == "O") ||
                        (jogo[0, 2] == "O" && jogo[1, 1] == "O" && jogo[0, 2] == "O") ||
                        (jogo[2, 0] == "O" && jogo[2, 1] == "O" && jogo[2, 2] == "O") ||
                        (jogo[1, 0] == "O" && jogo[1, 1] == "O" && jogo[1, 2] == "O") ||
                        (jogo[0, 2] == "O" && jogo[2, 1] == "O" && jogo[2, 2] == "O"))
                    {
                        Console.WriteLine("O Jogador O ganhou!");
                        break;
                    }
                    else if (count == 1)
                    {
                        Console.WriteLine("Deu Velha!");
                    }
                    count++;
                }

                Console.WriteLine("Quer jogar novamente");
                resposta = Console.ReadLine();

            } while (resposta == "sim");



        }
    }
}
