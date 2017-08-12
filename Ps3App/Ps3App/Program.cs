using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps3App
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(SumOfAllMultiplies());
           Console.WriteLine(number);
            Console.ReadKey();
        }

        static int SumOfAllMultiplies()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i%3==0 || i%5==0)
                {
                    sum +=i;
                }
            }
            return sum;
        }

    }
}
