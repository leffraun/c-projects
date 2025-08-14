
using System;
using System.Reflection.Metadata.Ecma335;
using draft;

internal class Program
{
    private static void Main(string[] args)
    {
       int birthyear = 0;
        Console.WriteLine("enter your birthyear:");
        try
        {
              birthyear = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("please enter a valid year.");
        }
        CalculateAge(birthyear);
        
       

    }
    public static void CalculateAge(int birthyear)
    {
        if (birthyear<1900)
        {
            Console.WriteLine("you can't be that old!");
        }
        else if(birthyear > DateTime.Now.Year)
        {
            Console.WriteLine("you can't be born in the future!");
        }
        else
        {
            int yourage = DateTime.Now.Year - birthyear;
            Console.WriteLine($"you are {yourage} years old.");
        }
       
    }





}
