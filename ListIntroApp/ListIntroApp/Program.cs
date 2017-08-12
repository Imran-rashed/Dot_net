using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //fixed type dynamic size
            List<int> ourList = new List<int>();

            ourList.Add(154);
            ourList.Add(25);
            ourList.Add(3654);
            ourList.Add(36);
            ourList.Add(25);
            ourList.Add(367865);
            ourList.Add(012);

            foreach (int i in ourList)
            {
                Console.WriteLine(i);
            }

            //ourList.Sort();
            ourList.Remove(25);
            ourList.RemoveRange(1, 3);

            Console.WriteLine("Count:" + ourList.Count);
            //ourList.Clear();
            Console.WriteLine("List Data");


            for (int i = 0; i < ourList.Count; i++)
            {
                Console.WriteLine(ourList[i]);
            }

            Console.ReadKey();
        }
    }
}
