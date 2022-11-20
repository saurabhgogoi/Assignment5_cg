using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace GenericAndNonGenericClasses
{
    class Player
    {
        public string Player_name { get; set; }
        public int runs_scored { get; set; }
        public Player(string p, int r)
        {
            this.Player_name = p;
            this.runs_scored = r;
        }

    }

    class Team
    {
        static void Main(string[] args)
        {
            List<Player> India = new List<Player>();
            Player p1 = new Player("Sehwag", 309);
            Player p2 = new Player("Virat", 183);
            Player p3 = new Player("Rahul", 110);
            India.Add(p1);
            India.Add(p2);
            India.Add(p3);
            IEnumerable<Player> GetAllPlayers()
            {
                return India;
            }

            foreach (Player p in GetAllPlayers()) // Iterating returned elements  
            {
                Console.WriteLine(p.Player_name + " " + p.runs_scored);
            }
        }
    }
}
