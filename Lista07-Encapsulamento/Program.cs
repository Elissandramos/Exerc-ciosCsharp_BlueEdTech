using System;

namespace ExercíciosAula07_ {
    class Program {
        static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();
            Exercicio03();
            //Exercicio04();
            //Exercicio05();
        }
        static void Exercicio01()
        {   /*Cadastro de Alunos
            Considere uma classe Aluno. Esta classe possui como atributos privados o nome, as notas e a frequência.
            Além do construtor, esta classe deve conter os métodos que cadastram os alunos, adiciona suas notas, consulta um aluno
            por código e consulta todos os alunos do cadastro.  */


            Console.WriteLine("Hello");

        }
        static void Exercicio02()
        {   /*Sistema de Login
            Desenvolva um programa de contas com login e senha privados. Além disso criptogafe esta senha para que ela fique muito segura.
            Além do método construtor, implemente os seguintes métodos
            Criação de conta;
            Alterar a senha;
            Entrar no Sistema: Neste método o usuário deve digitar seu usuário e depois sua senha. 
            A classe de contas deve validar se este usuário existe, caso não exista exiba:  Este usuário não existe!
            Caso o usuário exista e a senha esteja errada: Senha incorreta!
            Caso usuário e senha estejam corretos exiba: Bem vindo ao sistema!*/

            Console.WriteLine("Hello");


        }
        static void Exercicio03()
        {   /*Conta Bancária
            Crie uma classe Conta Bancária que possua os seguintes atributos: número da conta, nome do cliente e saldo privados.
            Além dos métodos de get para os atributos crie um método para alterar o nome, realizar depósitos e saques. 
            Também construa um construtor onde saldo é opcional, com valor default zero, já os demais atributos são obrigatórios.*/

            ContaBancaria conta1;

            Console.WriteLine("--- Inserir dados Conta Bancária ---");
            Console.Write("Digite Numero da Conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite nome do Titular: ");
            string nome = Console.ReadLine();

            Console.Write("Deseja realizar depósito inicial(s/n): ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre com a quantia do depósito : ");
                double saldo = double.Parse(Console.ReadLine());

                conta1 = new ContaBancaria(numero, nome, saldo);
            }
            else
            {
                Console.WriteLine("nao realiza deposito");

                conta1 = new ContaBancaria(numero, nome);
            }

            Console.WriteLine("--- informações da conta ---");
            //sendo printado no file da classe com o metodo tostring
            Console.WriteLine(conta1);

            Console.WriteLine("\n");
            Console.WriteLine("Deseja realizar \n" +
                             "[1] alteração de nome \n" +
                             "[2] Depósito \n ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite novo nome:");
                    string nomeatualizado = Console.ReadLine();

                    conta1.AterarNome(nomeatualizado);

                    //ja printa tudo de novo, mas com o nome atualizado                    
                    Console.WriteLine(conta1);
                    break;
                case 2:
                    Console.Write("Entre com a quantia do depósito : ");
                    double deposito = double.Parse(Console.ReadLine());

                    conta1.RealizarDeposito(deposito);

                    //ja printa tudo de novo, mas com o saldo atualizado 
                    Console.WriteLine(conta1);

                    break;
                default:
                    Console.WriteLine("opção indisponível");
                    break;
            }
            //conta1.AterarNome();
            //conta1.RealizarDeposito();

            Console.ReadLine();


        }
        static void Exercicio04()
        {   /*Pet Shop
            Vamos modelar um cadastro de animais de uma pet-shop? Crie uma classe que modele os animais e contenha como atributos 
            nome, espécie, cor, idade, observação e dados do dono. Os atributos relacionados ao dono do animal deve ser privados para
            proteção de dados. Forrneça métodos para cadastro e leitura das informações.*/

            Console.WriteLine("Hello");


        }
        static void Exercicio05()
        {   /*Televisão
            Faça um programa que simule uma tv. A classe de televisão deve ter atributos de marca, código de série privado, 
            uma lista de canais com nome e número, volume e status. Forneça métodos para ligar e desligar o televisor, aumentar ou
            diminuir o volume.
            Certifique-se de que o número do canal existe e informe pro usuário caso não exista;
            Controle o nível do volume, não permitindo que o usuário exceda o limite de volume;
            Valide se a televisão está ligada antes de trocar de canal ou altear o volume.
            Permita que o cliente possa visualiza todos os atributos da televisão.*/

            Console.WriteLine("Hello");


        }


    }
}

