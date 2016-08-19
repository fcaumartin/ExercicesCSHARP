using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remise
{
    class Program
    {
        static void Main(string[] args)
        {
            double PU = 0, TOT = 0, REM = 0, PAP = 0, PORT = 0;
            int QTE=0;

            Console.WriteLine("Entrez PU ");
            PU = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrez QTE ");
            QTE = Convert.ToInt32(Console.ReadLine());

            TOT = PU * QTE;

            

            if (TOT>=100 & TOT<=200)
            {
                REM = TOT * 0.05;
            }
            if (TOT>200)
            {
                REM = TOT * 0.1;
            }

            if (TOT > 500)
            {
                PORT = 0;
            }
            else
            {
                PORT = TOT * 0.02;
                if (PORT<6)
                {
                    PORT = 6;
                }
            }

            PAP = TOT - REM + PORT;

            Console.WriteLine("Total = " + TOT);
            Console.WriteLine("Remise = " + REM);
            Console.WriteLine("Port = " + PORT);
            Console.WriteLine("Prix à payer = " + PAP);

        }
    }
}
