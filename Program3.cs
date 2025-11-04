using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Answer the questions with True or False:");

        Console.Write("Is it raining? ");
        bool q1 = bool.Parse(Console.ReadLine());

        Console.Write("Do you have an umbrella? ");
        bool q2 = bool.Parse(Console.ReadLine());

        string result;

        if (q1 && q2) result = "Go outside.";
        else if (q1 && !q2) result = "Stay home.";
        else result = "Enjoy the day!";

        Console.WriteLine("Result: " + result);
    }
}
