using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("Ram");
            names.Add("Shyam");
            names.Add("hey");
            names.Add("Hi");

            names.Remove("Hi");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
