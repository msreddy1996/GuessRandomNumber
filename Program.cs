using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessRandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {


            Random r = new Random();
            int winNum = r.Next(0, 100);
            bool win = false;

            do
            {
                Console.WriteLine("Guess Number between 1 and 100");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if(i>winNum)
                {
                    Console.WriteLine("Too high , Guess Lower");
                }
                else if (i< winNum)
                {
                    Console.WriteLine("Too Low , Guess Higher");
                }
                else if(i==winNum)
                {
                    Console.WriteLine("Congrats you matched the number");
                    win = true;
                }

                Console.WriteLine();
            } while (win == false);
            Console.WriteLine("Thank you for playing the game");
            Console.Write("Press any key to exit");
            Console.ReadKey(true);
        }
    }
}
