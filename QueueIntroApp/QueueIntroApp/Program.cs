using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Enqueue(6);

            int[] myArray = new int[6];
            //myArray = myQueue.ToArray();

            Console.WriteLine("Dequeue item: " + myQueue.Dequeue());
            myArray = myQueue.ToArray();
            
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
