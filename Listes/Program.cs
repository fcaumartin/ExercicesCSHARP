using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listes
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre = 1;
            List<int> tab = new List<int>();


            while (nombre != 0) { 
                Console.WriteLine("Entrez un nombre");
                nombre = Int32.Parse(Console.ReadLine());
                tab.Add(nombre);
            }

            for (int i = 0; i < tab.Count; i++)
            {
                Console.Write(tab[i] + " ");
            }

            //Console.WriteLine(tab[10]);
            Console.ReadLine();
        }
    }
}
