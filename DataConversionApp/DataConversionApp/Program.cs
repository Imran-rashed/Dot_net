using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConversionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            bool b = true;
            char c = 'a';
            string s = "hello";
            double d = 1425.7;
            long l = 1245454;

            l = i;

            //i = Convert.ToInt32(d);
            //i = (int)d;
            i = c;
            i = Convert.ToInt32(b);
            Console.WriteLine(l);
            Console.ReadKey();

        }
    }
}
