using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class Dictionary1
    {
       public void AddNames()
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "Ram");
            names.Add("3", "Shyam");
            names.Add("2", "Mohan");
            names.Add("4", "Sohan");
            names.Add("5", "Deepak");
            names.Add("6", "Ram");
            foreach(KeyValuePair<string,string> name in names)
            {
                Console.Write(name +" ");
            }
            Console.Read();
        }
        static void Main(string[] args)
        {
            Dictionary1 d1 = new Dictionary1();
            d1.AddNames();
        }

    }
}
