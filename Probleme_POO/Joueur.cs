using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_POO
{
    class Joueur
    {
        string nom;
        int score;
        string[] motsTrouver = new string[15];

        public Joueur(string nom)
        {
            this.nom = nom;
        }

        public Joueur(string nom, int score)
        {
            this.nom = nom;
            this.score = score;
        }

        public bool Cointain(string mot)
        {
            bool result = false;
            for (int i = 0; i < motsTrouver.Length; i++)
            {
                if (mot == motsTrouver[i]) { result = true; }
            }
            return result;
        }

        public void Add_Mot(string mot)
        {
            for (int i = 0; i < motsTrouver.Length; i++)
            {
                if (motsTrouver[i] == null) { motsTrouver[i] = mot; }
            }
        }
        public override string ToString()
        {
            string result ="";
            result += "Le jouer " + nom+ " a un score de " + score;
            return result;
        }
    }
}
