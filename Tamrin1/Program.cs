using System;

class Program
{
    static void Main()
    {
        Console.Write("Adad aval ra vared kon (n): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Adad dovom ra vared kon (m): ");
        int m = int.Parse(Console.ReadLine());

        for (int i = n; i <= m; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}