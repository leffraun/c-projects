
using System;
using System.Reflection.Metadata.Ecma335;
using draft;

internal class Program
{

    private static void Main(string[] args)
    {
        bool condition = true;
        Random rand = new Random();
        int tries = 0;
        while (condition)
        {
           
            string allcharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890@#$%/";
            string letters = "";
         
            int n;
            n=rand.Next(8, 13);

            for (int i = 0; i < n; i++)
            {
                char letter = allcharacters[rand.Next(allcharacters.Length)]; //new knowledge for me
                letters += letter;
            }
            if ((letters.Any(char.IsDigit)) && (letters.Any(char.IsUpper) && (letters.Any(char.IsLower)) && (letters.Any(ch =>"@/#$%".Contains(ch)))))
            {
                Console.WriteLine(letters);
                condition = false;
                if(tries == 2)
                {
                    Console.WriteLine($"password formed by the computer in the {tries}nd attempt.");
                }
                Console.WriteLine($"password formed by the computer in the {tries}th attempt.");
            }

            else
            {
                condition = true;
                tries += 1;
            }
        }
       
        

    }
}
    





