using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier2
{
    class Compte
    {
        static int Cpt = 0;
        private readonly int numC;
        private readonly Client titulaire;
        protected Mad solde;
        Mad plafond = new Mad(5000);
        protected List<Operation> operations = new List<Operation>();

        public Compte(Mad solde, Client Clt)
        {
            Cpt++;
            this.numC = Cpt;
            this.solde = solde;
            this.titulaire = Clt;
            //this.plafond = new Mad(1000);
        }
        virtual public void afficher()
        {
            Console.WriteLine("Num_compte = " + this.numC);
            Console.WriteLine("les informations de titulaire:");
            titulaire.afficher();
            Console.Write("Solde = ");
            this.solde.afficher();
            Console.Write("\n Plafond = ");
            this.plafond.afficher();

        }

        public void crediter(Mad S)
        {
            if (S.ispositif())
            {
                this.solde += S;
                Console.WriteLine("Operation reussie");
                DateTime date = DateTime.Now;
                this.operations.Add(new Operation(S, date, "crediter"));
            }
            else
                Console.WriteLine("Operation échouée donner une valeur positif");

        }
        virtual public bool debiter(Mad S)
        {
            if (S.ispositif() && S <= this.plafond && this.solde >= S)
            {
                this.solde -= S;
                Console.WriteLine("Operation reussie");
                DateTime date = DateTime.Now;
                this.operations.Add(new Operation(S, date, "débiter"));
                return true;
            }
            else if (S > this.plafond)
            {
                Console.WriteLine("operation non autorisé , somme superieur au plafond");
                return false;
            }
            else if (this.solde < S)
            {
                Console.WriteLine("solde insuffisant");
                return false;
            }
            else
                Console.WriteLine("Operation échouée donner une valeur positif");
            return false;
        }
        public void verser(Compte C, Mad Montant)
        {
            if (this.debiter(Montant))
                C.crediter(Montant);
        }
    }
}
