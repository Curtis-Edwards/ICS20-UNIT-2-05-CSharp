using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int rate;
        int hours;
        double pay;
        double govtaken;
        
        Console.WriteLine("Please enter your hourly wage and your hours worked");
        Console.WriteLine("");

        Console.Write("hourly wage: ");
        rate = Convert.ToInt32(Console.ReadLine());
        Console.Write("hours worked: ");
        hours = Convert.ToInt32(Console.ReadLine());
        pay = (rate * hours) * (1.00 - 0.18);
        govtaken = (rate * hours) * 0.18;

        Console.WriteLine("Your salary is: " + pay.ToString("0.00") + "$");
        Console.WriteLine("The goverment will tkae: " + govtaken.ToString("0.00") + "$");
        
        Console.WriteLine("\nDone.");
    }
}