using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosAula09 {
    class Triangulo : FiguraGeometrica {

        //construtor
        public Triangulo(double lado, double altura) : base(lado, altura) { }

        //metodo herdado
        public override double CalculaArea()
        {
            double area = (this.Lado * this.Altura) / 2;
            return area;

        }
    }
}
