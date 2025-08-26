
using System;
using System.Reflection.Metadata.Ecma335;
using draft;

internal class Program
{

    private static void Main(string[] args)
    {
        Random rand = new Random();
        string allcharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890@#$%/";
        
        for (int i = 0; i < 5; i++)
        {
            char letter = allcharacters[rand.Next(allcharacters.Length)]; //new knowledge for me
            Console.Write(letter);
        }
    }
}
    





