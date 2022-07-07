using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosAula06 {
    class Fatura {
        private string _nome;
        private string _descricao;
        private int _quantidade;
        private double _preco;

        // construtor
        public Fatura(string nome, string descricao, int quantidade, double preco)
        {
            // this é usado para diferenciar os atributos locais - das variaveis locais
            // os que tem this são os que estao dentro da classe
            this._nome = nome;
            this._descricao = descricao;
            this._quantidade = quantidade;
            this._preco = preco;
        }

        public string GetNome()
        {
            return _nome;
        }
        public void SetNome()
        {
        }


        public string GetDescricao()
        {
            return _descricao;
        }
        public void SetDescricao()
        {
        }


        public int GetQuantidade()
        {
            return _quantidade;
        }
        public void SetQuantidade()
        {
        }


        public double GetPreco()
        {
            return _preco;
        }
        public void SetPreco()
        {
        }

        public override string ToString()
        {
            return $"{CalcularValorFatura(this._preco, this._quantidade)} reais";
        }



        public double CalcularValorFatura(double preco, int quantidade)
        {
            double resultado = preco * quantidade;

            return resultado;
        }
    }
}
