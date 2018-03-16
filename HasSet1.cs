using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class HasSet1
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            names.Add("Raj");
            names.Add("Rohan");
            names.Add("Sohan");
            names.Add("Deepak");
            names.Add("Raj");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
