using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class Dictionary2
    {
        public void Disc()
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            names.Add(1, "Bivu");
            names.Add(3, "Bipul");
            names.Add(2, "Bitu");
            names.Add(4, "Rishav");
            names.Add(5, "Abhinav");
            //names.Clear();
            for (var i = 0; i < names.Count; i++)
            /*{
                Console.WriteLine(names[i]);
            }*/
  
            foreach (KeyValuePair<int,string> name in names)
            {
                Console.WriteLine(name.Key+","+name.Value);
            }
            Console.WriteLine();
            Console.WriteLine("enter key to search value :");
            int key = Convert.ToInt32(Console.ReadLine());
            if(names.ContainsKey(key))
            {
                string value = names[key];
                Console.WriteLine("value at "+key+" is : "+value);
            }
            Console.WriteLine(names.ContainsKey(6));
            Console.WriteLine(names.ContainsValue("Abhinav"));
            Console.WriteLine(GetType());
            Console.WriteLine(names.Remove(4));
            Console.WriteLine(names.ToString());
            foreach (KeyValuePair<int, string> name in names)
            {
                Console.WriteLine(name.Key + "," + name.Value);
            }
            Console.Read();
        }
        static void Main(string[] args)
        {
            Dictionary2 d2 = new Dictionary2();
                d2.Disc();
        }
    }
}
