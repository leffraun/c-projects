
using System;
using System.Reflection.Metadata.Ecma335;
using draft;

internal class Program
{

    private static void Main(string[] args)
    {
        bool validinput = false;
        int birthmonth = 0;
        int birthdate = 0;
        int birthyear = 0;  
        try
        {
            Console.WriteLine("enter your birthdate:(dd/mm/yyyy)");
            string[] parts = Console.ReadLine().Split('/');
            birthdate = int.Parse(parts[0]);
             birthmonth = int.Parse(parts[1]);
             birthyear = int.Parse(parts[2]);
            validinput = true;
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter the date in the format dd/mm/yyyy.");
        }
        catch
        {
            Console.WriteLine("An unexpected error occurred. Please try again.");
        }
        if (validinput)
        {
            CheckError(birthyear, birthmonth, birthdate);
        }
        Console.WriteLine("Do you wanna check how many days you have until your next bday?(y/n)");
        string reply = Console.ReadLine();
        if (reply == "y")
        {
            BdayMessage( birthyear,  birthmonth,  birthdate);
        }
        else
        {
            Console.WriteLine("exiting the program");
            return;
        }


    }
    public static int yourage = 0;
    public static void CheckError(int birthyear, int birthmonth, int birthdate)
    {
        if (birthyear < 1900 || birthyear > 2025)
        {
            Console.WriteLine("invalid year");
        }
        else
        {
            int max = DateTime.DaysInMonth(birthyear, birthmonth);
            if (birthdate >= 1 && birthdate <= max)
            {
                yourage = DateTime.Now.Year - birthyear;
                DateTime birthday = new DateTime(birthyear, birthmonth, birthdate);
                Console.WriteLine($"Your birthday is: {birthday.ToString("dd MMMM yyyy")}");
                Console.WriteLine($"Your age is: {yourage} years");

                if (DateTime.Now.Month < birthmonth || (DateTime.Now.Month == birthmonth && DateTime.Now.Day < birthdate))
                {
                    yourage--;

                }
            }
           
        }

    }
    public static void BdayMessage(int birthyear,int birthmonth,int birthdate)
    {
        DateTime Today = DateTime.Today;
        DateTime nextbirthday = new DateTime(Today.Year, birthmonth, birthdate);
        if (nextbirthday < Today)
        {
          nextbirthday = new DateTime(Today.Year + 1, birthmonth, birthdate);
        }
        int daysuntilbirthday = (nextbirthday - Today).Days;
        if (daysuntilbirthday == 0)
        {
            Console.WriteLine("Happy birthday!!");
        }
        else
        {
            Console.WriteLine($"you have {daysuntilbirthday} days left for your next birthday.");
        }
    }
}
       
    





