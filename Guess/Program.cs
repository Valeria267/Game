using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Number;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Game: Guess the number. Guess a number between 1 and 100 ");
            GNumber v = new GNumber();
            int number;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());

                if (v.NumberEquals(number))
                {
                    Console.WriteLine("You won");
                    return;
                }
                else
                if (v.Correct(number))
                {
                    if (v.Evaluation(number))
                        Console.WriteLine("More. We have {0} attempt", v.K);

                    else Console.WriteLine("Less. We have {0} attempt", v.K);
                }
                else Console.WriteLine("you entered an incorrect number. enter from 1 to 100");
            }

            while (v.Attempt(number));

            Console.WriteLine("You lose. Number is " + v.Number);
            Console.ReadKey();
        }
    }
}
