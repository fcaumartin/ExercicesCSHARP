using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatriceSuite
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            double nombre1, nombre2, resultat;

            Console.WriteLine("Entrez un nombre");
            saisie = Console.ReadLine();
            nombre1 = Convert.ToDouble(saisie);

            Console.WriteLine("Entrez un nombre");
            saisie = Console.ReadLine();
            nombre2 = Convert.ToDouble(saisie);

            resultat = nombre1 / nombre2;

            Console.Write("Le resultat de " + nombre1);
            Console.Write(" / " + nombre2 + " = ");
            Console.WriteLine(resultat);
        }
    }
}
