using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class SortedList
    {
        static void Main(string[] args)
        {
            SortedList<string, string> names = new SortedList<string, string>();
            names.Add("5", "Abhinav");
            names.Add("3", "kori");
            names.Add("4", "Shivhare");
            names.Add("2", "Sharma");
            names.Add("6", "Adarsh");
            foreach(KeyValuePair<string,string> name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(names.Capacity);
            Console.WriteLine(names.Count);
            Console.WriteLine(names.Keys);
            Console.WriteLine(names.Values);
            Console.Read();
        }
    }
}
