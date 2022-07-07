using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosAula05 {
    class ClassVoo {
        public string data;
        public string horario;
        //public List<int> cadeiras = new List<int>();

        //supondo que assentos 1 e 2 estão ocupados
        public List<int> cadeiras = new List<int>() { 2, 3 };


        // ocuparVaga: ocupa determinada cadeira do vôo, cujo número é recebido como parâmetro, 
        // e retorna verdadeiro se a cadeira ainda não estiver ocupada(operação foi bem sucedida) e falso caso contrário
        public bool ocuparVaga(int assento)
        {
            bool resultado;

            if (cadeiras.Contains(assento))
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
        }

        //vagasLivres: retorna o número de cadeiras vagas disponíveis (não ocupadas) no vôo;
        public int VagasLivres()
        {
            // na inicializacao da lista ja tem o numero 1 e 2
            // esta dizendo que a lista tem capacidade de armazenar 100 valores
            cadeiras.Capacity = 100;
            return cadeiras.Capacity - cadeiras.Count;

        }

        // cadeiraLivre: Retorna o número da próxima cadeira livre;
        public int CadeiraLivre(int assento)
        {
            //int resultado;
            //verifica qual proximo valor do numero que vem no assento
            int resultado = cadeiras.Find(x => x > assento);

            // 1,2,3,5 > exemplo proximo é o 4
            //verifica se esse proximo numero também esta disponivel
            //if (cadeiras.Contains(proximo))
            //{
            //    resultado = proximo + 1;   1,2,3,5
            //}
            //else
            //{
            //    resultado = 55;
            //}

            return resultado;
        }


        //ocupa: ocupa determinada cadeira do vôo, cujo número é recebido como parâmetro. 
        public string ocupa(int assento)
        {
            string resultado;

            if (cadeiras.Contains(assento))
            {
                resultado = "não esta disponivel";
            }
            else
            {
                cadeiras.Add(assento);
                resultado = "Está disponivel e foi adicionado a lista de passageiros";
            }
            return resultado;

        }

        public string VerHorario()
        {
            string resultado = "data e hora " + data + horario;
            return resultado;
        }




    }
}
