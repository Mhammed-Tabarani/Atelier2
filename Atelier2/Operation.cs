using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier2
{
    class Operation
    {
        static int cpt = 0;
        private DateTime date;
        private int Num;
        private Mad Montant;
        private string libelle;


        public Operation( Mad mon, DateTime date, string lib)
        {
            cpt++;
            this.Montant = mon;
            this.Num = cpt;
            this.date = date;
            this.libelle = lib;
        }
        public void afficherOP()
        {
            Console.WriteLine(this.libelle + "||" + this.date + "|| n°" + this.Num + "||" + this.Montant.ToString());
        }
    }
}
