using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier2
{
    class Client
    {
        private string Nom, Prenom, Adresse;
        
        public Client(string Nom, string Prenom, string Adresse)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Adresse = Adresse;
        }
        public void afficher()
        {
            Console.WriteLine("Nom = " + this.Nom + "\n Prenom = " + this.Prenom + "\n Adresse = " + this.Adresse);
        }
        public void NouveauCO(Compte Compte)
        {
            this.ComptList.Add(Compte);

        }

    }
}
