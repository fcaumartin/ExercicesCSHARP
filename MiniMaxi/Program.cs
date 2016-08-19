using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre=1;
            int maxi, mini;

            Console.WriteLine("Entrez un nombre");
            nombre = Int32.Parse(Console.ReadLine());
            maxi = nombre;
            mini = nombre;

            while (nombre != 0)
            {
                Console.WriteLine("Entrez un nombre");
                nombre = Int32.Parse(Console.ReadLine());
                if (nombre > maxi)
                {
                    maxi = nombre;
                }
                if (nombre != 0)
                {
                    if (nombre < mini)
                    {
                        mini = nombre;
                    }
                }
            }
            Console.WriteLine("Maxi = " + maxi);
            Console.WriteLine("Mini = " + mini);
            Console.ReadLine();
        }
    }
}
