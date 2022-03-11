using System;
using System.Globalization;
using Exercicio2.src.interfaces;

namespace Exercicio2.src.model
{
    public class VideoGame : Produto, IImposto
    {
        private string Marca;

        private string Modelo;

        private bool IsUsado;

        public String marca
        {
            get => Marca = marca;
            set => Marca = value;
        }
        public String modelo
        {
            get => Modelo;
            set => Modelo = value;
        }
        public bool isUsado
        {
            get => IsUsado;
            set => isUsado = value;
        }
      
        public VideoGame()
        {
        }
        public VideoGame(string Nome, double Preco, int Quantidade, string Marca, string Modelo, bool IsUsado) : base(Nome, Preco, Quantidade)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.IsUsado = IsUsado;
        }

        public double CalculaImposto()
        {
            if (IsUsado == true)
            {
                double impostoGame = (base.Get_Preco() * 0.25);
                System.Console.WriteLine("Imposto " +
                    base.Get_Nome() +" " + Modelo + " usado " + "R$" +
                    impostoGame.ToString("F2"));
                return impostoGame;
            }
            else
            {
                double ImpostoLivro = (base.Getpreco() * 0.45);
                System.Console.WriteLine("Imposto " + base.GetNome() + " " + Modelo + " " + "R$" +
                    ImpostoLivro.ToString("F2"));
                return ImpostoLivro;
            }
        }

        public override string ToString()
        {
            return "Video-game: " +
            base.GetNome() +
            " Modelo: " +
            Modelo +
            " preco: " +
            base.GetPreco().ToString("F2") +
            " quantidade: " +
            base.GetQuantidade() +
            " em estoque";
        }
    }
}
