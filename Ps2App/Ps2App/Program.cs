using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps2App
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAllEven();
            Console.ReadKey();
        }

        static void PrintAllEven()
        {

            for (int i = 1; i < 100; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
