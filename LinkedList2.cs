using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class LinkedList2
    {
        static void Main(string[] args)
        {
            var names = new LinkedList<string>();
            names.AddLast("Bitu");
            names.AddLast("Bipul");
            names.AddLast("Bivu");
            names.AddLast("Bikash");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            LinkedListNode<string> node = names.Find("Bipul");
            names.AddBefore(node, "Vivesh");
            names.AddAfter(node, "Rishav");
            Console.WriteLine("=====================");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
