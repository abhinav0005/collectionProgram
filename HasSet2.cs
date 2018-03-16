using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class HasSet2
    {
        static void Main(string[] args)
        {
            var city = new HashSet<string>() { "Bangaluru", "New Delhi", "Patna", "Mumbai","1" };
            foreach(var name in city)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
