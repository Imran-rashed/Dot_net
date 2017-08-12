using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps1App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lower limit:");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter upper limit:");
            int upperLimit = Convert.ToInt32(Console.ReadLine());
            PrintAllIntegers(lowerLimit,upperLimit);
            Console.ReadKey();

        }

        static void PrintAllIntegers(int lowerNo, int upperNo)
        {
            for (int i = lowerNo; i <=upperNo; i++)
            {
                Console.WriteLine(i);
            }
            
        }

    }
}
