using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre;

            Console.WriteLine("Entrez un nombre ");
            nombre = Convert.ToInt32(Console.ReadLine());

            if (nombre%2==0)
            {
                Console.WriteLine("Pair");
            }
            else
            {
                Console.WriteLine("Impair");

            }
        }
    }
}
