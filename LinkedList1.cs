using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class LinkedList1
    {
        static void Main(string[] args)
        {
            var names = new LinkedList<string>();
            {
                names.AddLast("Nand");
                names.AddLast("Hello");
                names.AddLast("ram");
                names.AddLast("India");
                names.AddLast("Bipul");
                names.AddFirst("GOLU");
                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }
                Console.Read();
            }
        }
    }
}
