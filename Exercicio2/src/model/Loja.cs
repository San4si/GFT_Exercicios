using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio2.src.model
{
    public class Loja
    {
        Livro livro = new Livro();
        VideoGame videoGame = new VideoGame();
        private string Nome;
        private string Cnpj;
        private List<Livro> Livros;
        private List<VideoGame> VideoGames;

        public Loja()
        {}
        public Loja(string Nome, string Cnpj, List<Livro> Livros, List<VideoGame> VideoGames)
        {
            this.Nome = Nome;
            this.Cnpj = Cnpj;
            this.Livros = Livros;
            this.VideoGames = VideoGames;
        }

        public string Getnome(){
            return Nome;
        }

        public string Getcnpj(){
            return Cnpj;
        }

        public void Getcnpj(string cnpj){
            Cnpj = cnpj;
        }

        public void Setlivros(List<Livro>livros){
            Livros = livros;
        }

        public void Setvideogame(List<VideoGame>videoGames){
            VideoGames = videoGames;
        }

           public void listaLivros(){

        System.Console.WriteLine("-------------------------------------------------------------");

        if(Livros.Count == 0)
        {
            System.Console.WriteLine("A loja não tem livros em seu estoque");
        }
        
        else
        {
        System.Console.WriteLine("A loja " + Nome + " possui estes livros para venda: ");

        
            foreach (Livro livro in Livros)
            {
                System.Console.WriteLine(livro);
            }
        }

        System.Console.WriteLine("-------------------------------------------------------------");
    }
    public void listaVideoGames(){
          
        if(VideoGames.Count == 0)
        {
            System.Console.WriteLine("A loja não tem Video-Games em seu estoque");
        }
        
        else{
       
             System.Console.WriteLine("A loja " + Nome + " possui estes video-games para venda: ");
      
            foreach (VideoGame games in VideoGames)
            {
                System.Console.WriteLine(games);
            }
        }
        System.Console.WriteLine("-------------------------------------------------------------");
    }

        public double CalculaPatrimonio(){
          
          double total = 0;
           foreach (Produto produto in Livros)
           {
               total += (produto.GetPreco()) * produto.GetQuantidade();
           }

           foreach (Produto produto in VideoGames)
           {
               total += (produto.GetPreco()) * produto.GetQuantidade();
           }

            System.Console.Write("O patrimonio da loja: " + Nome + " é de R$ " + total.ToString("F2"));
            return total; 
        }
    }
}