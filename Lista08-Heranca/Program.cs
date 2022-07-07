using System;
using System.Collections.Generic;

namespace ExercíciosAula08 {
    class Program {
        static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();
            Exercicio03();
            //Exercicio04();             
        }
        static void Exercicio01()
        {    /* Jogo de volei
             * Classe Jogadora
                    Um construtor que preencha os atributos do jogador;
                    Crie a classe Jogador, com nome, apelido, número, pontos de habilidade, cartões, suspenso, posição;
                    Criar um método que verifica a condição de jogador, ou seja, um método booleano que retornará true se o jogador está apto a jogar e false se o jogador está suspenso.
                    Aplicar Suspensão: torna um jogador suspenso;
                    Cumprir Suspencao: torna um jogador apto a jogar;
                    Sofrer Lesao: Este método vai gerar aleatoriamente um lesão no jogador. A gravidade da lesão irá se refletir em uma redução de pontos de habilidade do jogador, quanto mais grave maior a redução da qualidade. Crie uma escala de redução de no mínimo 1 ponto até o máximo de 15% da qualidade;
                    Treinar: Aleatoriamente vai aumentar a qualidade do jogador.
               Classe Time
                    Deve conter os atributos nome, fundação, jogadores titulares, jogadores reserva;
                    Criar um método para selecionar os 6 melhores jogadores com maiores pontos de habilidades e colocar os demais na reserva;
                    Criar um método que imprima os nomes e números dos jogadores escalados para jogar;
                    Desafio Adicional: b) Altere o método de seleção de jogadores para considerar não apenas a qualidade dos jogadores, mas também a sua posição, assim os teremos os 6 melhores em sua posição e não os jogadores com as maiores qualidades no elenco.
               Classe Jogo
                    Deve conter os atributos time da casa, time visitante, data do jogo, cidade, placar do time da casa, placar do time visitante;
                    Crie um método que gere um resultado aleatório considerando o total da qualidade dos titulares. Isso quer dizer que quanto maior o somatório da qualidade dos jogadores titulares maior será a probabilidade da equipe ganhar.
                    Por exemplo, o somatório da qualidade dos jogadores titulares da equipe A é 584, enquanto que o somatório da qualidade dos jogadores titulares da equipe B é 723.
                    Crie um método para gerar lesões aleatoriamente em um jogador independente do time. O jogador que sofre a lesão também deve ser escolhido aleatoriamente.
                    Crie um método para permitir treinamento após a conclusão do jogo, possibilitando que os jogadores possam realizar treinamento.
                    Instancie as classes criadas e execute as ações do jogo! Não esqueça de utilizar o conceito de composição aprendido hoje!*/

            Console.WriteLine("Hello");


        }
        static void Exercicio02()
        {   /* Locadora de Jogos
             * Classe Jogo
                    Deve conter os atributos nome; classificação etária; código; ano de lançamento; emprestado, para indicar se o jogo está ou não emprestado no momento; gênero;
                    Deverão ser construídos métodos para imprimir as informações do jogo, locar um jogo e devolvê-lo;
               Classe Cliente
                    Atributos nome, idade, código, endereço e telefone;
                    Deverão ser construídos métodos construtores para preencher os dados do cliente. Um cliente só poderá ser cadastrado se pelo menos os atributos nome, idade, telefone e código forem fornecidos no momento do cadastro, caso o endereço não seja fornecido, deve ser exibida uma mensagem de erro.
               Classe Empréstimo
                    Atributos código do jogo, data de locação, data de devolução, valor da locação. O valor do empréstimo pode variar com a data de lançamento do jogo, por exemplo.
                    Deve ser construído um método construtor para preenchimento dos atributos e uma função para renovação do empréstimo.
               Classe Locadora
                    Atributos nome da locadora, clientes, jogos e empréstimos.
                    Crie um método construtor que recebe como parâmetro o nome da locadora;
                    Crie um cadastro de clientes que recebe como parâmetro os dados do cliente, faz a validação do código verificando se existe algum cliente cadastrado com aquele código, caso exista imprime uma mensagem na tela de erro: "Não foi possível cadastrar o cliente";
                    Crie um cadastro de jogos que recebe como parâmetro os dados do jogo e faz a validação do código.
                    Crie um método que realiza a listagem de todos os jogos da locadora, uma listagem de jogos por gênero, listagem de jogos por classificação, listagem de jogos que não estejam emprestados;
                    Crie um método que realiza uma consulta de cliente por código;
                    Crie um método que recebe como parâmetro o código do cliente e o código do jogo, apos isso o método deve fazer a verificação 
                        se existem cliente e jogo com os respectivos códigos, caso exista ele verifica se o jogo esta ou não emprestado e se o cliente 
                        tem idade para o empréstimo. Se todas as condições para empréstimo forem satisfeitas, o método deverá inserir criar uma instância
                        de empréstimo e exibir uma mensagem de sucesso da seguinte forma:
                            Empréstimo realizado com sucesso
                            Nome do Jogo: (Nome do Jogo)
                            Nome do Cliente: (Nome do Cliente)
                            Valor: (valor) ?
                Construa um método que recebe como parâmetro o código do jogo, caso o jogo esteja cadastrado e emprestado,
                ele atualiza a condição de emprestado para false, retira o jogo da lista de empréstimos do cliente e imprime a mensagem:
                            Jogo: (Nome do Jogo) devolvido com sucesso!
                Caso não exista jogo com este código, deve-se imprimir:
                            Jogo não existente na base de Dados!
                Caso exista jogo com este código, mas o mesmo não esta emprestado, deve-se imprimir:
                            Jogo: (Nome do Jogo) não esta emprestado!
             */


            Console.WriteLine("Hello");


        }
        static void Exercicio03()
        {   /* Mundo animal
             * Classe Animal
                    Crie uma classe animal que possua os atributos nome, número de patas, cor, ambiente e velocidade média;
                    Crie um método construtor que receba por parâmetro os valores iniciais de cada um dos atributos e atribua-os aos seus respectivos atributos;
                    Crie os métodos get e set para cada um dos atributos;
                    Crie um método dados, sem parâmetro e do tipo void, que, quando chamado, imprime na tela um relatório informando os dados do animal.
               Classe Peixe
                    Crie uma classe Peixe que herde da classe Animal e tenha o atributo característica;
                    Crie um método construtor que receba por parâmetro os valores iniciais de cada um dos atributos (incluindo os atributos da classe Animal) e atribua-os aos seus respectivos atributos;
                    Crie ainda os métodos get e set para o atributo característica;
                    Crie um método que quando chamado, imprime na tela um relatório informando os dados do peixe;
               Classe Mamífero
                    Crie uma classe Mamifero que herde da classe Animal e possua um atributo alimento;
                    Crie um método construtor que atribua-os valores aos seus respectivos atributos;
                    Crie ainda os métodos get e set para o atributo alimento;
                    Crie um método que imprime na tela um relatório informando os dados do mamífero; 
               Classe Mundo Animal
                    Crie uma classe mundo animal que possui uma lista de peixes e mamíferos;
                    Crie métodos para exibir os animais criados;
                    Instancie a classe mundo animal, preencha com animais e exiba os dados dos animais criados. */

            // nome, cor, ambiente, velocidade, caracteristica
            Peixe p1 = new Peixe("Dory", "azul", "mar", 3, 0, "especie rara");
            p1.PrintDados();

            // nome, cor, ambiente, velocidade, alimento
            Mamifero m1 = new Mamifero("Macaco", "marrom", "floresta", 1, 2, "banana");
            m1.PrintDados();

            // MundoAnimal 
            Console.WriteLine(" qual lista deseja acessar, Digite \n " +
                              "[1] Peixes \n " +
                              "[2] Mamiferos");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                // instanciar o mundo animal, só peixes
                var peixes = new List<string> { "piranha", "tubarão", "salmão" };

                Console.WriteLine("--- Lista Peixes ---");
                foreach (var p in peixes)
                {
                    Console.WriteLine(p);
                }
            }
            else if (opcao == 2)
            {
                // instanciar o mundo animal, só mamiferos
                var mamiferos = new List<string> { "gato", "cachorro", "elefante" };

                Console.WriteLine("--- Lista Mamiferos ---");
                foreach (var m in mamiferos)
                {
                    Console.WriteLine(m);
                }
            }


        }
        static void Exercicio04()
        {   /* Supermercado
              Agora é com você: Pense em um Supermercado como cenário da nossa aplicação, 
              identifique as classes e implemente um programa que abstrai um caixa. Vou te dar algumas dicas:
               - Você precisará de uma classe cliente, produto, pedido, e supermercado; Cada produto tem um preço e uma quantidade em estoque. 
                 Um pedido de um cliente é composto de itens, onde cada item especifica o produto que o cliente deseja e respectiva quantidade, 
                  seu total e formas de pagamento;
               - Você pode ter produtos de limpeza, alimentação, higienize e essa é uma boa classe para aplicar os conceitos de herança;
                    O resultado esperado é que você aplique os conceitos de herança e composição e consiga ao instanciar um supermercado cadastrar
                        produtos, clientes e realizar um pedido.                
            */


            Console.WriteLine("Hello");


        }



    }
}
