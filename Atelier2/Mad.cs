using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier2
{
    class Mad
    {
        private double valeur;

        public Mad(double V)
        {
            this.valeur = V;
        }
        public void afficher()
        {
            Console.WriteLine(this.valeur);
        }
        public bool ispositif()
        {
            if (this.valeur > 0)
                return (true);
            return false;
        }
        public static Mad operator +(Mad V1, Mad V2)
        {
            Mad Somme = new Mad(V1.valeur + V2.valeur);
            return (Somme);
        }
        public static Mad operator -(Mad V1, Mad V2)
        {
            Mad Sous = new Mad(V1.valeur - V2.valeur);
            return (Sous);
        }
        public static bool operator <=(Mad V1, Mad V2)
        {
            if (V1.valeur <= V2.valeur)
                return (true);
            return false;
        }
        public static bool operator >=(Mad V1, Mad V2)
        {
            if (V1.valeur >= V2.valeur)
                return (true);
            return false;
        }
        public static bool operator <(Mad V1, Mad V2)
        {
            if (V1.valeur < V2.valeur)
                return (true);
            return false;
        }
        public static bool operator >(Mad V1, Mad V2)
        {
            if (V1.valeur > V2.valeur)
                return (true);
            return false;
        }
        public static Mad operator * (Mad V1 , double V2)
        {
            Mad V = new Mad(V1.valeur * V2);
            return (V);
        }
    }
}

