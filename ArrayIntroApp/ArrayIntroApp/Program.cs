using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //fixed type and size
            int[] ourArray = new int[5];

            ourArray[0] = 364;
            ourArray[1] = 25;
            ourArray[2] = 145;
            ourArray[3] = 65;
            ourArray[4] = 57;
            //ourArray[5] = 012;
            ourArray[1] = 66;

            //Array ourArray2 = new int[5];
            Array.Sort(ourArray);
            Array.Reverse(ourArray);
            Array.Clear(ourArray, 0, 2);

            Console.WriteLine(ourArray.Length);
            

            foreach (int i in ourArray)
            {
                Console.WriteLine(i);
            }

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(ourArray[i]);
            //}

            Console.ReadKey();
        }
    }
}
