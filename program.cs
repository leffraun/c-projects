//number guessing game
// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {

         
    
            bool playagain = true;
            string? play;
            while (playagain)
            {
                Random rand = new Random();
                int num = rand.Next(1, 21);
                int numofguesses = 5;
                bool guessed = false;
                int guessnum = 0;
                Console.WriteLine("guess a number from one to twenty..(ps you have 5 guesses)");
                while (numofguesses > 0)
                {
                    try
                    {
                        guessnum = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("invalid input");
                        continue;
                    }
                    if (guessnum == num)
                    {
                        guessed = true;
                        Console.WriteLine("You guessed it! it was " + num);
                        break;
                    }
                    else if (guessnum > num)
                    {
                        Console.WriteLine("the number to be guessed is actually lower.");
                    }
                    else if (guessnum < num)
                    {
                        Console.WriteLine("the number to be guessed is actually higher.");
                    }
                    else
                    {
                        Console.WriteLine("guess again...");

                    }
                    numofguesses--;

                }
                if (!guessed)
                {
                    Console.WriteLine("Sorry you ran out of guesses. it was " + num);

                }
                Console.WriteLine("do u wanna play again?(y/n)");

                play = Console.ReadLine();
                if (play != null)
                {
                    play = play.ToLower();

                }
                else
                {
                    Console.WriteLine("wrong input.leaving the game..");
                    playagain = false;
                }
                if (play == "y")
                {
                    continue;
                }
                else if (play == "n")
                {
                    playagain = false;
                    Console.WriteLine("thank you for playing ..");
                }







            }
        }
    }
}


