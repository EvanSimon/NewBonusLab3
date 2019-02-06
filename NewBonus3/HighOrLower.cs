using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBonus3
{
    class HighOrLower : Player
    {
        public override int Guess()
        {
            
            int[] numbers = Enumerable.Range(0, 100).ToArray();
            int value = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == value) return i;
            }            
            return -1;
        }
    }
}
