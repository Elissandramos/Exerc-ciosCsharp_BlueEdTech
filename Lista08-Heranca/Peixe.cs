﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosAula08 {

    //classe filha peixe herda da classe mãe(base) -> Animal
    class Peixe : Animal {

        // classe filha Peixe tem exclusivamente esse atributo (caracteristica)
        private string Caracteristica { get; set; }

        // o construtor da classe Peixe abaixo, usa os
        // os atributos da mãe(base) Animal,e contem tbm seu unico
        // atributo proprio -> caracteristica 
        public Peixe(string nome, string cor, string ambiente, double velocidade, int numPatas, string caracteristica)
            : base(nome, cor, ambiente, velocidade, numPatas)
        {

            this.Caracteristica = caracteristica;
        }
        public override void PrintDados()
        {   //não tem numero de patas e sim "caracteristica"
            Console.WriteLine($"Nome : {this.Nome} \n" +
                        $"Cor : {this.Cor} \n" +
                        $"Ambiente : {this.Ambiente} \n" +
                        $"Velocidade : {this.Velocidade} km/h \n" +
                        $"caracteristica : {this.Caracteristica} \n");
        }
    }
}

