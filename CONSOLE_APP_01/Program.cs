using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_APP_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Message:
            Console.WriteLine("Enter 5 Numbers, and I will display their sum:");

            int intTotal = 0;

            for (int x = 0; x <= 4; x++)
            {
                int y = 0;
                y = Convert.ToInt32(Console.ReadLine());
                intTotal = y + intTotal;
            }

            Console.WriteLine("The TOTAL is: {0}", intTotal);
            Console.ReadKey();
        }
    }
}
