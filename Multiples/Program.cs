using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, N;
            int resultat;

            Console.WriteLine("Entrez un nombre");
            X = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un nombre");
            N = Int32.Parse(Console.ReadLine());

           
            for (int i=1; i<=N; i++)
            {
                resultat = i * X;
                //Console.WriteLine("{0} x {1} = {2}", i, X, i * X);
                Console.WriteLine(i + " x " + X + " = " + resultat);

            }

        }
    }
}
