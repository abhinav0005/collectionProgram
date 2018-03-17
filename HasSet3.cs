using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class HasSet3
    {
        static void Main(string[] args)
        {
            var num = new HashSet<int>() { 1, 5, 6, 3, 2, 2 };
            foreach(var i in num)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
