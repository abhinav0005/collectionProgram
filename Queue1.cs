using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class Queue1
    {
        static void Main(string[] args)
        {
            Queue<string> name = new Queue<string>();
            name.Enqueue("Deepak");
            name.Enqueue("Sanjeev");
            name.Enqueue("Sandeep");
            name.Enqueue("Abhin");
            foreach(String n in name)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Peek element is : " + name.Peek());
            Console.WriteLine("Dequeue element is : " + name.Dequeue());
            Console.WriteLine("After dequeue peek element is : " + name.Peek());
            Console.Read();
        }
    }
}
