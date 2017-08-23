using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_The_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write("Would you like to play? [Y/N]");
            string input = Console.ReadLine();

            while (input == "y")
            {
                int myNum = rnd.Next(1, 101);

                int theirNum = 0;

                bool notWin = true;

                while (notWin)
                {
                    bool isValidNum = false;

                    while (!isValidNum)
                    {
                        Console.Write("Enter your guess: ");
                        input = Console.ReadLine();

                        isValidNum = Int32.TryParse(input, out theirNum);

                        if (!isValidNum)
                        {
                            Console.WriteLine("That is not a Number!");
                        }
                    }

                    if (myNum < theirNum)
                    {
                        Console.WriteLine("Too High!");
                    }
                    else if (myNum > theirNum)
                    {
                        Console.WriteLine("Too Low!");
                    }
                    else if (myNum == theirNum)
                    {
                        Console.WriteLine("You win!");
                        notWin = false;
                    }

                    Console.ReadKey(true);
                }

                Console.Write("Would you like to keep playing? [Y/N]");
                input = Console.ReadLine();
            }
        }
    }
}
