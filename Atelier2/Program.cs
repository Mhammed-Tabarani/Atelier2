using System;

namespace Atelier2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client clt = new Client("Mhammed", "Tabarani", "26Amr");
            Mad solde = new Mad(10000);
            Compte Cmpt = new Compte(solde, clt);
            Cmpt.afficher();
            Client clt2 = new Client("TOTO", "SOSO", "26Amr");
            Compte Cmpt2 = new Compte(solde, clt2);
            Cmpt2.afficher();
            Mad Montant = new Mad(5000);
            Cmpt2.verser(Cmpt, Montant);
            Cmpt.afficher();
            Cmpt2.afficher();
        }
    }
}
