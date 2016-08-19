using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptage
{
    class Program
    {
        static void Main(string[] args)
        {
            int age=0;
            int compteur1=0, compteur2=0, compteur3=0;

            Console.WriteLine("Début");
            while (age < 100)
            {
                Console.WriteLine("Entrez un age");
                age = Int32.Parse(Console.ReadLine());
                //if (age < 20) compteur1++;
                //if (age >=20 && age <=40) compteur2++;
                //if (age >40) compteur3++;

                if (age < 20)
                {
                    compteur1++;
                }
                else if (age <= 40)
                {
                    compteur2++;
                }
                else
                {
                    compteur3++;
                }

            }

            Console.WriteLine(compteur1);
            Console.WriteLine(compteur2);
            Console.WriteLine(compteur3);

        }
    }
}
