using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosAula08 {
    class Animal {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Ambiente { get; set; }
        public double Velocidade { get; set; }
        public int NumPatas { get; set; }

        // construtor personalizado com todos atributos
        public Animal(string nome, string cor, string ambiente, double velocidade, int numPatas)
        {
            this.Nome = nome;
            this.Cor = cor;
            this.Ambiente = ambiente;
            this.Velocidade = velocidade;
            this.NumPatas = numPatas;
        }

        public virtual void PrintDados()
        {
            Console.WriteLine($"Nome : {this.Nome} /n" +
                              $"Cor : {this.Cor} /n" +
                              $"Ambiente : {this.Ambiente} /n" +
                              $"Velocidade : {this.Velocidade} /n" +
                              $"NumPatas : {this.NumPatas} /n");
        }

    }
}
