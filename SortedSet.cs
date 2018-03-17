using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class SortedSet
    {
        static void Main(string[] args)
        {
            var names = new SortedSet<string>();
            names.Add("Zen");
            names.Add("Yen");
            names.Add("pen");
            names.Add("Abhinav");
            names.Add("Raj");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
