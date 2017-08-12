using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //dynamic type and size
            ArrayList ourArrayList = new ArrayList();
            ourArrayList.Add("Hello World");
            ourArrayList.Add('a');
            ourArrayList.Add(14.25);
            ourArrayList.Add(true);
            //ourArrayList[3] = 215;

            //ourArrayList.Sort();
            Console.WriteLine(ourArrayList.Contains('a'));
            Console.WriteLine(ourArrayList.Contains(256));

            foreach (var item in ourArrayList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
