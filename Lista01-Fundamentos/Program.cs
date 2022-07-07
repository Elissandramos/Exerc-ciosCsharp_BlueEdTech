using System;

namespace ExercíciosSemana01 {
    class Program {
        static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();
            Exercicio03();
            //Exercicio04();
        }
        static void Exercicio01()
        {  // 01. Elabore um programa que escreve seu nome completo, seu endereço, o CEP e telefone em linhas separadas.
            Console.WriteLine("Digite seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu endereço:");
            string endereco = Console.ReadLine();

            Console.WriteLine("Digite seu CEP:");
            int cep = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu Telefone:");
            int telefone = int.Parse(Console.ReadLine());

            Console.WriteLine("----Cadrastro----");
            Console.WriteLine($"nome:{nome}\nendereco:{endereco}\ncep:\ntelefone:{telefone}");
        }

        static void Exercicio02()
        { // 02. Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome, sua formação e uma contribuição feita por ela dentro da tecnologia em linhas separadas.

            Console.WriteLine("Digite o nome de uma mulher famosa na historia da tecnologia:");
            string nome = Console.ReadLine();

            Console.WriteLine("formação dela:");
            string formacao = Console.ReadLine();

            Console.WriteLine("Contribuição realizada:");
            string contribuicao = Console.ReadLine();

            Console.WriteLine("-------------");
            Console.WriteLine($"nome: {nome} \nformacao:{formacao} \ncontribuicao:{contribuicao}");
        }

        static void Exercicio03()
        { // 03. Elabore um programa que mostre na tela uma letra de música que você gosta, o compositor e o gênero musical em linhas separadas.
            string letraMusica;
            string generoMusica;
            string compositorMusica;

            Console.Write("Digite letra de Musica:");
            letraMusica = (Console.ReadLine());

            Console.WriteLine("Digite genero da Musica:");
            generoMusica = Console.ReadLine();

            Console.WriteLine("Digite compositor da Musica");
            compositorMusica = Console.ReadLine();

            Console.WriteLine("-------------");
            Console.WriteLine($" letraMusica:{letraMusica} \ngeneroMusica:{generoMusica} \ncompositorMusica:{compositorMusica}");
        }

        static void Exercicio04()
        { // 04. Elabore um programa que exibe uma mensagem que incentive outras mulheres a entrar na tecnologia.

            string mensagem = "Girl's power, we are united";
            Console.WriteLine("mensagem:" + mensagem);

        }
    }
}
