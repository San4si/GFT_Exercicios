using System;
using Exercicio1.src.Entities;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
            Veiculo passeio =
                new Veiculo("Fiat",
                    "Uno",
                    "END-5125",
                    "Amarelo",
                    158,
                    true,
                    0,
                    80.025);

            //passeio.acelerar();
            // Console.WriteLine(passeio.Velocidade1);
            passeio.abastecer(61);

            Console.WriteLine(passeio.LitrosCombustivel);

           // passeio.frear();

            //Console.WriteLine(passeio.Velocidade1);

            //passeio.pintar("Verde");
            //Console.WriteLine(passeio.Cor1);

            //passeio.Ligar();
            //Console.WriteLine(passeio.IsLigado);
            //passeio.desligar();

            //Console.WriteLine(passeio.IsLigado);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
