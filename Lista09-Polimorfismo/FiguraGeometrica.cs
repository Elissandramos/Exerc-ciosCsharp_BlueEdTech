using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosAula09 {

    //  classe mãe
    class FiguraGeometrica {

        // atributos da classe
        public double Lado { get; set; }
        public double Altura { get; set; }

        // construtor (parametros obrigatorios para a classe existir)
        public FiguraGeometrica(double lado, double altura)
        {
            this.Lado = lado;
            this.Altura = altura;
        }

        // metodo que não retorna nada, apenas usa os parametros da classe (por isso o void)
        // virtual, pois como classe mãe vai gerar herança para classe filha
        public virtual double CalculaArea()
        {
            // cada filha vai ter o seu calculo especifico, mas com o mesmo
            // nome desse metodo
            double area = 0;
            return area;
        }

    }
}
