using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int annee;

            Console.WriteLine("Entrez votre année de naissance");

            string saisie = Console.ReadLine();
            annee = Convert.ToInt32(saisie);

            int anneEnCours = DateTime.Now.Year;

            if (anneEnCours - annee >= 18)
            {
                Console.WriteLine("Vous êtes majeur");
            }
            if (anneEnCours - annee < 18)
            {
                Console.WriteLine("Vous êtes mineur");
            }
        }
    }
}
