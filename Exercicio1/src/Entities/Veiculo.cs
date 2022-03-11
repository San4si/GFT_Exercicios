 using System;

    namespace Exercicio1.src.Entities
    {
        public class Veiculo
        {
            private string Marca;
            private string Modelo;
            private string Placa;
            private string Cor;
            private float Km;
            private bool isLigado;
            private const int litrosCombustivel = 60;
            private int Velocidade;
            private double Preco;

            public string Marca1 { get => Marca; set => Marca = value; }
            public string Modelo1 { get => Modelo; set => Modelo = value; }
            public string Placa1 { get => Placa; set => Placa = value; }
            public string Cor1 { get => Cor; set => Cor = value; }
            public float Km1 { get => Km; set => Km = value; }
            public bool IsLigado { get => isLigado; set => isLigado = value; }
            public int LitrosCombustivel { get => litrosCombustivel;}
            public int Velocidade1 { get => Velocidade; set => Velocidade = value; }
            public double Preco1 { get => Preco; set => Preco = value; }

            public Veiculo(string Marca1, string Modelo1, string Placa1, string Cor1, float Km1, bool IsLigado, int Velocidade1, double Preco1)
            {
                this.Marca = Marca1;
                this.Modelo = Modelo1;
                this.Placa = Placa1;
                this.Cor = Cor1;
                this.Km = Km1;
                this.IsLigado = IsLigado;
                this.Velocidade = Velocidade1;
                this.Preco = Preco1;
            }

            public void acelerar()
            {
                    Console.WriteLine("Sua Velocidade é de: " + (Velocidade1 += 20) + "km/h");                 
            }

            public void abastecer(int combustivel){
               if (combustivel <= 60){
                   Console.WriteLine("Você esta Abastecendo...");
               } else { throw new System.ArgumentException("Voce não pode abastecer! Seu tanque esta cheio == 60 litros.");
                  }
            }
            public void frear() 
            { if (Velocidade1 >=1){
                Console.WriteLine("Sua Velocidade é de: " + (Velocidade1 -= 20) + "km/h");
               }else {
                   Console.WriteLine("Seu veiculo esta parado!" + " " + (Velocidade1 = 0) + "Km/h");
               }
               }

            public string pintar(string cor){
                Console.WriteLine("Sua cor foi alterada para: ");
                return this.Cor = cor;
            }
            public void Ligar() {
                if (isLigado == false) {
                    Console.WriteLine("Ligando...");
                }else {
                   Console.WriteLine("Desligado");
                }
            }
          
            public void desligar() {
            if (isLigado == true && Velocidade <= 0) {
                Console.WriteLine("Desligando...");
                isLigado = false;
            }
        }

        }
    }

