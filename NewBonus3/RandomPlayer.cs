using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBonus3
{
    class RandomPlayer : Player
    {      
       Random rand = new Random();
       public override int Guess()
        {
            int guessNum = rand.Next();
            return guessNum;
        }
    }
}
