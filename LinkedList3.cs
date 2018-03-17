using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class LinkedList3
    {
        static void Main(string[] args)
        {
            var num = new LinkedList<int>();
            {
                num.AddLast(05);
                num.AddLast(06);
                num.AddLast(07);
                num.AddLast(09);
                num.AddLast(11);
                num.AddLast(12);
                foreach (var i in num)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("===============");
                LinkedListNode<int> node = num.Find(09);
                num.AddBefore(node, 08);
                num.AddAfter(node, 10);
                foreach(var i in num)
                {
                    Console.WriteLine(i);
                }
                Console.Read();
            }
        }
    }
}
