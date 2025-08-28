
using System;
using System.Reflection.Metadata.Ecma335;
using draft;

internal class Program
{

    private static void Main(string[] args)
    {
        bool condition = true;
        Random rand = new Random();
        while (condition)
        {
           
            string allcharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890@#$%/";
            string letters = "";
            int tries = 0;
            
            for (int i = 0; i < 5; i++)
            {
                char letter = allcharacters[rand.Next(allcharacters.Length)]; //new knowledge for me
                letters += letter;
            }
            if ((letters.Any(char.IsDigit)) && (letters.Any(char.IsUpper) && (letters.Any(char.IsLower)) && (letters.Any(ch =>"@/#$%".Contains(ch)))))
            {
                Console.WriteLine(letters);
                condition = false;
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
    





