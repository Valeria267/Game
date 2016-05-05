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
            string s;
            do
            {
                s = v.NumberEquals(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("" + s);
            }
            while (s!= null);
            Console.WriteLine("No attempts. You lose. Number is "+v.Number);
            Console.ReadKey();
        }
    }
}
