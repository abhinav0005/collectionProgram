using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class Stack2
    {
        static void Main(string[] args)
        {
            Stack<int> num = new Stack<int>();
            num.Push(12);
            num.Push(22);
            num.Push(32);
            num.Push(42);
            num.Push(42);
            num.Push(562);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("peek element is : " + num.Peek());
            num.Pop();
            Console.WriteLine("after poping peek element is : " + num.Peek());
            Console.Read();
        }
    }
}
