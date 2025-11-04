using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter m: ");
            int m = int.Parse(Console.ReadLine());

            if (n > m) { int temp = n; n = m; m = temp; }

            Console.WriteLine("Choose: 1=Even, 2=Odd, 3=Prime, 4=Palindrome, 5=Perfect");
            int choice = int.Parse(Console.ReadLine());

            for (int i = n; i <= m; i++)
            {
                if (choice == 1 && i % 2 == 0) Console.WriteLine(i);
                else if (choice == 2 && i % 2 != 0) Console.WriteLine(i);
                else if (choice == 3 && IsPrime(i)) Console.WriteLine(i);
                else if (choice == 4 && IsPalindrome(i)) Console.WriteLine(i);
                else if (choice == 5 && IsPerfect(i)) Console.WriteLine(i);
            }

            Console.Write("Repeat? (y/n): ");
            if (Console.ReadLine().ToLower() != "y") break;
        }
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }

    static bool IsPalindrome(int n)
    {
        string s = n.ToString();
        char[] arr =
