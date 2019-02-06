using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBonus3
{
    class NumberGuessing
    {
        private Player p1;

        public NumberGuessing(Player p1)
        {
            this.p1 = p1;
        }

        public static void RunningThing()
        {
            int computerNumber = GetNumber(0, 100);
            string message = "Give me a number between 0 and 100";
            int count = 1;
            int UserNumber = GetNumber(message, 0, 100);
            int difference = DoSubtraction(UserNumber, computerNumber);
            while (difference != 0)
            {
                count++;
                message = EvaluteNumber(UserNumber);
                UserNumber = GetNumber(message, 0, 100);
                difference = DoSubtraction(UserNumber, computerNumber);
            }
            Console.WriteLine(message);
            ReturnFinalMessage(count);
        }
       
        public static void ReturnFinalMessage(int number)
        {
            if (number == 1)
            {
                Console.WriteLine("Wow! You guessed it in one try");
            }

        }

        public static string EvaluteNumber(int number)
        {
            string message;
            if (number > 0)
            {
                if (number >= 10)
                {
                    message = "Thats to high, Do better!";
                }
                else
                {
                    message = "Too high.";
                }
            }
            else if (number < -10)
            {
                message = "Thats to low, Do better!";
            }
            else if (number < 10 && number > 0)
            {
                message = "Too high";
            }
            else
            {
                message = "To low";
            }

            return message;
        }

        public static int DoSubtraction(int number1, int number2)
        {
            return number1 - number2;
        }

        public static int GetNumber(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }


        public static int GetNumber(string message, int min, int max)
        {
            int UserNumber = min - 1;
            Console.WriteLine(message);

            if (UserNumber < min || UserNumber > max)
            {
                while (!int.TryParse(Console.ReadLine(), out UserNumber)) ;
            }

            return UserNumber;
        }
    }
}
