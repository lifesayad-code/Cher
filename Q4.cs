using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter x1 y1: ");
        var p1 = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
        Console.Write("Enter x2 y2: ");
        var p2 = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
        Console.Write("Enter x3 y3: ");
        var p3 = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

        double cross = (p3[1] - p1[1]) * (p2[0] - p1[0]) - (p3[0] - p1[0]) * (p2[1] - p1[1]);

        if (Math.Abs(cross) < 0.000001)
            Console.WriteLine("P3 is on the line.");
        else
            Console.WriteLine("P3 is not on the line.");
    }
}
