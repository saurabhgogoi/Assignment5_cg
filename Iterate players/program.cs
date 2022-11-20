using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace GenericAndNonGenericClasses
{
    class PlayerUsingIterator
    {
        public string Player_name { get; set; }
        public int runs_scored { get; set; }
        public PlayerUsingIterator(string p, int r)
        {
            this.Player_name = p;
            this.runs_scored = r;
        }

    }

    class Teams
    {
        static void Main(string[] args)
        {
            ArrayList India = new ArrayList();
            Player p1 = new Player("Sehwag", 309);
            Player p2 = new Player("Virat", 183);
            Player p3 = new Player("Rahul", 110);
            India.Add(p1);
            India.Add(p2);
            India.Add(p3);
            foreach (Player p in India) // Iterating returned elements  
            {
                Console.WriteLine(p.Player_name + " " + p.runs_scored);
            }
        }
    }
}
