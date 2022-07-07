using System;

namespace ExercíciosAula06 {
    class Program {
        static void Main(string[] args)
        {

            //Exercicio01();
            //Exercicio02();
            Exercicio03();
            //Exercicio04();

        }

        static void Exercicio01()
        {    /*  jogo da velha
            Crie uma classe para o Jogo da Velha:
            A classe deve conter como dados privados uma matriz 3x3 para representar a grade do jogo
            O construtor deve inicializar a matriz vazia
            Forneça um método para exibir a matriz com status do jogo
            Permita dois jogadores humanos
            Forneça um método para jogar o jogo; todo movimento deve ocorrer em uma casa vazia; depois de cada movimento valide se uma vitória ou um empate.
            */

        }
        static void Exercicio02()
        {    /*  gerenciamento salários
            A fim de representar empregados em uma empresa, crie uma classe chamada Empregado que inclui os seguintes atributos; nome, cargo e salário mensal.
            Sua classe deve ter um construtor que inicializa os três atributos e também fornecer métodos que executem as seguintes ações:
            Se o salário mensal não for positivo, configure-o como 0.0.
            Conceder aumento de salários a seus funcionários de acordo com os dados abaixo: Salário de 0 até 400.00 ganha 15% Salário de 400.01 até 800.00 ganha 12% Salário de 800.01 até 1200.00 ganha 10% Salário de 1200.01 até 2000.00 ganha 7% Acima de 2000.00 ganha 4%
            Imprimir o salário de um funcionário.
                        */

            Console.WriteLine("--- Inserir dados do empregado ---");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Cargo: ");
            string cargo = Console.ReadLine();

            Console.Write("salario: ");
            double Salario = double.Parse(Console.ReadLine());

            Empregado empregado1 = new Empregado(nome, cargo, Salario);

            empregado1.ValidaSalario();
            empregado1.AumentoSalario();

            Console.WriteLine("--- cadastro do empregado ---");
            Console.WriteLine($" Nome: {empregado1.nome} \n" +
                              $" cargo: {empregado1.cargo} \n" +
                              empregado1.ImprimeSalario(empregado1.salario));
            Console.ReadLine();
        }
        static void Exercicio03()
        {    /*  Fatura de serviço
        Crie uma classe que representa uma fatura para uma loja de suprimentos de informática.
        A classe deve conter os seguintes atributos: número, descrição dos produtos, quantidade comprada de um produto e o preço. 
        A classe deve ter um construtor e um método get e set para cada variável de instância. Além disso, forneça um método para calcular o valor total da fatura.
        */

            Console.WriteLine("--- Inserir dados do produto ---");

            Console.Write("numRegistro: ");
            string nome = Console.ReadLine();

            Console.Write("descricao: ");
            string descricao = Console.ReadLine();

            Console.Write("quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("preco: ");
            double preco = double.Parse(Console.ReadLine());

            Fatura produto1 = new Fatura(nome, descricao, quantidade, preco);


            Console.WriteLine("--- fatura ---");

            //assim o modo de imprimir convencional, sem o Tostring
            //Console.WriteLine($"{produto1.CalcularValorFatura(preco, quantidade)} reais");

            //assim chamando o metodo ToString do objeto
            Console.WriteLine(produto1);


            Console.ReadLine();
        }
        static void Exercicio04()
        {    /*  Fatura de serviço
                Fazer uma classe que represente um Sorteio que irá sortear um número de 0 a 1000 e após pedir para o usuário adivinhar este número. Se ele errar, informar se o palpite é maior ou menor do que o número sorteado. O usuário pode jogar até que acerte e, depois disso, mostrar quantas tentativas ele fez até acertar.
                Dica utilize a classe Random do C#, para gerar números aleatórios.        */


        }
        static void Exercicio05()
        {    /*  Manipulando strings
                Montar uma classe que manipula strings:
                Faça um método que receba um nome completo e mostre a abreviatura deste nome. Não se devem abreviar as palavras com 2 ou menos letras. A abreviatura deve vir separada por pontos.
                Entrada:
                Giulia Bordignon
                Paulo Jose de Almeida Prado
                Saída:
                G. B.
                P. J. de A. P. 
                Fazer um método que receba uma string do usuário e mostre o conteúdo desta string de forma invertida.
                Fazer um método que receba uma string e conte suas vogais e consoantes.
                */


        }



    }

}
