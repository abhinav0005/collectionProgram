using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class Stack1
    {
        static void Main(string[] args)
        {
            Stack <string> names = new Stack<string>();
            names.Push("Ankit");
            names.Push("Ankur");
            names.Push("Bitu");
            names.Push("Bivu");
            names.Push("Bipul");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("peek element is : " + names.Peek());
            Console.WriteLine("pop element : " + names.Pop());
            Console.WriteLine("after pop peek element is : " + names.Peek());
            Console.Read();
        }
    }
}
