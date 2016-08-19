using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre=0;
            Random rnd = new Random();
            int magic = rnd.Next(1, 101);

            while (nombre != magic)
            {
                Console.WriteLine("Entrez un nombre");
                nombre = Int32.Parse(Console.ReadLine());

                if (nombre < magic)
                {
                    Console.WriteLine("plus grand");
                }
                if (nombre > magic)
                {
                    Console.WriteLine("Plus petit");
                }
            }

            Console.WriteLine("Bravo");


        }
    }
}
