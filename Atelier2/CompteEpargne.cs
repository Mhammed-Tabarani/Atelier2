using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier2
{
    class CompteEpargne : Compte
    {
        double Tauxinteret;

        public CompteEpargne(Mad solde, Client Clt, double Taux) : base(solde, Clt)
        {
            if (Taux > 0 && Taux < 100)
                Tauxinteret = Taux;
            else
                Console.WriteLine("entrer une valeur compris entre 0 et 100");
        }
        public void Calculeinteret()
        {
            this.solde += this.solde * (this.Tauxinteret / 100);

        }
    }
}
