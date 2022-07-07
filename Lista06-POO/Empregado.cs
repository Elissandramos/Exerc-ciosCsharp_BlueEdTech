using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosAula06 {
    class Empregado {
        public string nome;
        public string cargo;
        public double salario;

        //construtor
        public Empregado(string Nome, string Cargo, double Salario)
        {
            this.nome = Nome;
            this.cargo = Cargo;
            this.salario = Salario;
        }

        public void ValidaSalario()
        {
            if (salario < 0)
            {
                this.salario = 0.00;
            }

        }

        public void AumentoSalario()
        {
            if (salario < 400)
            {
                this.salario += this.salario * 0.15;
            }
            else if (this.salario > 400 && this.salario < 800)
            {
                this.salario += this.salario * 0.12;
            }
            else if (this.salario > 800 && this.salario < 1200)
            {
                this.salario += this.salario * 0.10;
            }
            else if (this.salario > 12000 && this.salario < 2000)
            {
                this.salario += this.salario * 0.07;
            }
            else if (this.salario > 2000)
            {
                this.salario += this.salario * 0.04;
            }

        }

        public string ImprimeSalario(double Salario)
        {

            return $"salario: {Salario}";
        }


    }
}
