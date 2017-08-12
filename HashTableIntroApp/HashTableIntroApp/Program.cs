using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHashtable = new Hashtable();

            myHashtable.Add(1, "hello");
            myHashtable.Add('a', 45.2);
            myHashtable.Add(true, "world");

            Console.WriteLine(myHashtable.ContainsKey('b'));
            Console.WriteLine(myHashtable.ContainsValue(45.2));
            myHashtable.Remove(1);
            

            foreach (DictionaryEntry dictionaryEntry in myHashtable)
            {
                Console.WriteLine(dictionaryEntry.Key + " - " + dictionaryEntry.Value);
            }

            Console.ReadKey();
        }
    }
}
