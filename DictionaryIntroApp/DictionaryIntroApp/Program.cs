using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<keyType, ValueType > name = new Dictionary<keyType, ValueType>();
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(1,"10");
            myDictionary.Add(2,"20");
            myDictionary.Add(3,"30");
            Console.WriteLine(myDictionary.ContainsKey(4));
            Console.WriteLine(myDictionary.ContainsValue("30"));

            foreach (KeyValuePair<int, string> kvp in myDictionary)
            {
                Console.WriteLine(kvp.Key +":"+ kvp.Value);
            }


            Console.ReadKey();
        }
    }
}
