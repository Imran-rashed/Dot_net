using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();
            int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("even");


            //}
            //else if (number == 10)
            //{
            //    Console.WriteLine("number is 10");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}
            //for (int i = 0; i < number; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //while (number<10)
            //{
            //    Console.WriteLine(number);
            //    number++;
            //}

            //do
            //{
            //    Console.WriteLine(number);
            //    number++;
            //} while (number<10);

            //switch (number%2)
            //{
            //    case 0:
            //        Console.WriteLine("even");
            //        break;
            //    default:
            //        Console.WriteLine("odd");
            //        break;
            //}

            if (number<0 || number>100)
            {
                Console.WriteLine("Number is invalid");
            }
            else if (number>=80)
            {
                Console.WriteLine("A+");
            }
            else if (number>=60)
            {
                Console.WriteLine("A");
            }
            else if (number >= 40)
            {
                Console.WriteLine("A-");
            }
            else
            {
                Console.WriteLine("F");
            }
            Console.ReadKey();
        }
    }
}
