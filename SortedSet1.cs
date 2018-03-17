using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class SortedSet1
    {
        static void Main(string[] args)
        {
            var num = new SortedSet<int>() { 12, 3, 23, 14, 55, 1, 89, 76, };
            foreach(var i in num)
            {
                Console.Write(i +" ");
            }
            Console.Read();
        }
    }
}
