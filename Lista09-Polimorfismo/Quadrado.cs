using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosAula09 {

    // quadrado herda da classe FiguraGeometrica
    class Quadrado : FiguraGeometrica {
        // vai herdar da classe mãe,
        // 1. o construtor(que recebe o lado e altura)
        // 2. o metodo calculaArea(que vai ter uma maneira exclusiva para quadrado)

        // base indica heranca do construtor
        public Quadrado(double lado, double altura) : base(lado, altura) { }

        // override pois herda o metodo
        public override double CalculaArea()
        {
            double area = this.Lado * this.Altura;
            return area;

        }
    }
}

