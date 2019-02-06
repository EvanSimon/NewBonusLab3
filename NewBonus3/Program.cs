using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBonus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new BruteForce();
            NumberGuessing hg = new NumberGuessing(p1);
            NumberGuessing.RunningThing();
        }      
    }
}
