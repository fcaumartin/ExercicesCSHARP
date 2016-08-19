using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool equivalent = true;

            string[] tab1 = { "toto", "titi", "tutu", "tata" };
            string[] tab2 = { "toto44", "titi44", "tutu", "tata" };

            for (int i = 0; i < 4; i++)
            {
                if (tab1[i] != tab2[i])
                {
                    equivalent = false;
                }
            }

            if (equivalent)
            {

            }
        }
    }
}
