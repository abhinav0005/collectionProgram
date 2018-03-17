using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
namespace CollectionApp
{
    class Concurrent1 
    {
        public void AddPlayer()
        {
            ConcurrentDictionary<int, string> players = new ConcurrentDictionary<int, string>();
            players.TryAdd(10, "Sachin");
            players.TryAdd(7, "Dhoni");
            players.TryAdd(18, "Virat");
            players.TryAdd(17, "Abd");
            foreach(KeyValuePair<int,string> player in players)
            {
                Console.WriteLine(player);
            }
           
            Console.Read();
        }
        static void Main(string[] args)
        {
            Concurrent1 c1 = new Concurrent1();
            c1.AddPlayer();
        }
    }
}
