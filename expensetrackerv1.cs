
using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using draft;

internal class Program
{
    public class Expense
    {
        //name,description,amount,date
        public string? name {  get; set; }   
        public string? description { get; set; }
        public int amount { get; set; }
        public DateTime date { get; set; }
        public override string ToString()
        {
            return $"Date {date}, Description:{description}, amount {amount}, name: {name}";
           
        }
    }
    
    private static void Main(string[] args)
    {

        List<Expense> expenses = new List<Expense>();
        //creating one expense
      
        bool condition = true;
        do
        {
            Expense e = new Expense();
            Console.WriteLine("enter name:");
            e.name = Console.ReadLine();
            Console.WriteLine("enter description:");
            e.description = Console.ReadLine();
            Console.WriteLine("enter amount:");
            e.amount = Convert.ToInt32(Console.ReadLine());
            e.date = DateTime.Now;
            Console.WriteLine(e);
            expenses.Add(e);
            Console.WriteLine("would you like to continue adding more?\n Press 1 for yes \n Press 2 for no , press 3 for printing the list");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    condition = true;
                    break;
                case 2:
                    condition = false;
                    break;
                case 3:
                    foreach (Expense expense in expenses)
                    {
                        Console.WriteLine(expense);
                    }
                    condition = false;
                    break;
            }
        }
        while (condition);
        
       
    }
    
        
}
    





