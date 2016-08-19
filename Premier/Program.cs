using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre;
            bool drapeau = false;

            Console.WriteLine("Entrez un nombre");
            nombre = Int32.Parse(Console.ReadLine());

            for (int i = 2; i < nombre; i++)
            {
                if (nombre % i == 0)
                {
                    drapeau = true;
                }
                
            }

            if (drapeau == false)
            {
                Console.WriteLine("Premier");
            }
            else {
                Console.WriteLine("Pas premier");

            }
        }
    }
}
