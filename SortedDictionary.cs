using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class SortedDictionary  
    {
        public void sort()
        {
            SortedDictionary<int, string> cities = new SortedDictionary<int, string>();
            {
                cities.Add(1, "Bangalore");
                cities.Add(2, "Mumbai");
                cities.Add(5, "Delhi");
                cities.Add(9, "Chennai");
                cities.Add(6, "Rajsthan");
                cities.Add(4, "Kolkatta");
                cities.Add(7, "Haydrabad");
                cities.Add(3, "Patna");
                cities.Add(10, "Bhopal");
                cities.Add(8, "Ranchi");
                Console.WriteLine("Total number of cities is : " + cities.Count);
                Console.WriteLine();
                foreach (KeyValuePair<int, string> city in cities)
                {
                    Console.WriteLine(city);
                }
                Console.WriteLine("************************");
               
                Console.WriteLine("enter the key to get city name :");
                int key = Convert.ToInt32(Console.ReadLine());
                if(cities.ContainsKey(key))
                {
                    Console.WriteLine("City found : " + cities[key]);
                }
                else
                {
                    Console.WriteLine("invalid key");
                }
                Console.WriteLine("************************");
                Console.WriteLine("enter the city number to be remove : ");
                int remove = Convert.ToInt32(Console.ReadLine());
                if (cities.ContainsKey(remove))
                {
                    Console.WriteLine("City remove : " + cities.Remove(remove));
                }
                else
                {
                    Console.WriteLine("invalid city number");
                }
                Console.WriteLine("*********************");
                Console.WriteLine("After removing cities are :");
                foreach(KeyValuePair<int,string> city in cities)
                {
                    Console.WriteLine(city);
                }
                Console.Read();
            }
        }
        static void Main(string[] args)
        {
            SortedDictionary sd = new SortedDictionary();
            sd.sort();
        }
    }
}
