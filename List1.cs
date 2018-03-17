using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class List1
    {
        static void Main(string[] args)
        {
            var names = new List<string>() { "India","India", "England", "Austreliya", "S Africa" };
            names.Sort();
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            for(int i = 0; i<names.Count;i++ )
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine();
            Console.WriteLine(names.BinarySearch("India"));
            Console.Read();
        }
    }
}
