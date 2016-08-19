using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SommeMoyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre = 1;
            double somme = 0;
            int compteur=-1;

            while (nombre!=0) {
                Console.WriteLine("Entrez un nombre ");
                nombre = Int32.Parse(Console.ReadLine());
                somme = somme + nombre;
                compteur = compteur + 1;
            }
            

            Console.WriteLine("Somme = " + somme);
            Console.WriteLine("compteur = " + compteur);
            Console.WriteLine("Moyenne = " + (somme / compteur));
        }
    }
}
