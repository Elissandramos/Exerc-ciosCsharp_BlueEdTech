using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosAula05 {
    class ClassAluno {

        public int Matricula;
        public string Nome;
        public double[] Notas = new double[3];

        public double Media()
        {
            return Notas.Average();
        }

        public double NotaFinal()
        {
            // a media final deve ser sete, então a nota final calcula-se assim -> (somaNotas + notafinal)/ 4 =7
            double resultado = 28 - (Notas[0] + Notas[1] + Notas[2]);
            return resultado;
        }

    }
}
