using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertion_Secondes
{
    class Program
    {
        static void Main(string[] args)
        {
            int heures, minutes, secondes;

            Console.WriteLine("Entrez un nombre de secondes");
            secondes = Convert.ToInt32(Console.ReadLine());

            heures = secondes / 3600;
            int reste = secondes % 3600;
            //int reste = secondes - (heures * 3600);

            minutes = reste / 60;

            secondes = reste % 60;

            Console.WriteLine("heures = " + heures);
            Console.WriteLine("minutes = " + minutes);
            Console.WriteLine("secondes = " + secondes);
        }
    }
}
