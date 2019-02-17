using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.FizzBuzz();
        }
    } // CLASS PROGRAM END

    class Game
    {
        public static void FizzBuzz()
        {
            for(int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    } // CLASS GAME END

} // NAMESPACE END
    

