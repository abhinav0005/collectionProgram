using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class SortedSet3
    {
        static void Main(string[] args)
        {
            var cities = new SortedSet<string>() { "Patna", "Bhopal", "Mumbai", "Agara", "Bangaluru" };
            foreach(var city in cities)
            {
                Console.WriteLine(city);
            }
            Console.Read();
        }
    }
}
