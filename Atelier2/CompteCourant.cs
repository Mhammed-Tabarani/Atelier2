using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier2
{
    class CompteCourant : Compte
    {
        Mad Decouvert;
        public CompteCourant(Mad solde, Client Clt, Mad D) : base(solde, Clt)
        {
            Decouvert = D;
        }
        public override void afficher()
        {
            base.afficher();
            Console.WriteLine("Le decouvert=" + Decouvert);
        }
        public override bool debiter(Mad S)
        {
            if (solde - S > Decouvert)
            {
                DateTime date = DateTime.Now;
                this.operations.Add(new Operation( S, date, "débiter"));
                return base.debiter(S);
            }
            else
                Console.WriteLine("DEcouvert!!!");
                    return false;
        }
    }
}
