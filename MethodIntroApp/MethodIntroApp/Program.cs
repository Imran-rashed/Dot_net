using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(SayHello());
            string message = SayHello();
            Console.WriteLine(message);

            double firstNumber = Convert.ToDouble(Console.ReadLine());
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double result = AddNumbers(firstNumber, secondNumber);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        static string SayHello()
        {
            //Console.WriteLine("hello world");
            return "Hello World";
        }

        static double AddNumbers(double firstNo, double secondNo)
        {
            return firstNo + secondNo;
        }
    }
}
