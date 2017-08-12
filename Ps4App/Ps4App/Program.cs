using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps4App
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfSquares = Convert.ToInt32(SumOfTheSquares());
            int squaresOfSums = Convert.ToInt32(SquaresOfTheSum());
            int result = squaresOfSums - sumOfSquares;
            Console.WriteLine(result);
            Console.ReadKey();

        }

        static int SumOfTheSquares()
        {
            int sumofthesqares = 0;

            for (int i = 0; i <= 100; i++)
            {
                sumofthesqares += i*i;
            }
            return sumofthesqares;
        }

        static int SquaresOfTheSum()
        {
            int squaresOfTheSum = 0;
            for (int i = 0; i <= 100; i++)
            {
                squaresOfTheSum += i;
            }
            return squaresOfTheSum*squaresOfTheSum;
        }
    }
}
