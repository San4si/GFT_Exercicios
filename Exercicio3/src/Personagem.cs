using System;

namespace Exercicio3.src
{
    public class Personagem
    {
        private string Nome;
        private int Vida { get; set; }
        private int Mana { get; set; }
        private float Xp { get; set; }
        private int Inteligencia { get; set; }
        private int Forca { get; set; }
        private int Level { get; set; }

        public string nome
        {
            get {return Nome;}
            set {Nome = value;}
        }

        public Personagem(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Xp = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
        }

        public virtual void LevelUp()
        {

        }
    }
}