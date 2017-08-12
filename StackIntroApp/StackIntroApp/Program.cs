using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);

            int[] myArray = new int[6];
           

            Console.WriteLine("Pop item: " + myStack.Pop());
            Console.WriteLine("Peek Item: " + myStack.Peek());
            Console.WriteLine("Pop item: " + myStack.Pop());
            
            Console.WriteLine(myStack.Contains(6));
            Console.WriteLine(myStack.Contains(1));
            Console.WriteLine("Peek Item: " + myStack.Peek());

            myArray = myStack.ToArray();
            
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }



            Console.ReadKey();
        }
    }
}
