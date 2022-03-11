using System;
using System.Globalization;
using Exercicio2.src.interfaces;

namespace Exercicio2.src.model
{
    public class Livro : Produto, IImposto
    {
    private String Autor;
    private String Tema;
    private int QtdPag;

    public Livro(){}

    public Livro(String Nome, double Preco, int Qtd, String Autor, String Tema, int QtdPag) : base(Nome, Preco, Qtd){
        this.Autor = Autor;
        this.Tema = Tema;
        this.QtdPag = QtdPag;
    }

    public String GetAutor(){
        return Autor;
    }

    public void SetAutor(String autor){
        Autor = autor;
    }
    public String GetTema(){
        return Tema;
    }

    public void SetTema(String tema){
        Tema = tema;
    }
    public int GetPaginas(){
        return QtdPag;
    }

    public void SetPaginas(int qntPag){
        QtdPag = qntPag;
    }


    public double CalculaImposto(){
        if (Tema == "educativo")
        {
            System.Console.WriteLine("Livro educativo não tem imposto");
            return 0;
            
        }

        else{
              
            double impostoLivro = (base.GetPreco() * 0.10);
            System.Console.WriteLine("R$ " + impostoLivro.ToString("F2") + " de impostos sobre o livro " + base.GetNome());
            return impostoLivro;
            }
    }
    }
}

