using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somme1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un nombre ");
            int nombre = Convert.ToInt32(Console.ReadLine());

            int i = nombre-1;
            while ( i > 0)
            {
                Console.WriteLine(i);
                i = i - 1;
            }



        }
    }
}
