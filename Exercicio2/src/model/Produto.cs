using System;
using System.Globalization;

namespace Exercicio2.src.model
{
      public abstract class Produto
    {
        private string Nome;
        private double Preco;
        private int Quantidade;

        public String Getnome(){
        return Nome;
        }
        public void Setnome(String nome){
        Nome = nome;
        }
        public double Getpreco()
        { return Preco;}

        public void Setpreco(double preco){
            Preco = preco;
        }

        public int Getquantidade(){
            return Quantidade;
        }

        public void Setquantidade(int quantidade){
            Quantidade = quantidade;
        }

        public Produto()
        {}

        public Produto(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }
    }
}