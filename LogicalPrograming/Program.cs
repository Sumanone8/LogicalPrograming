using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPerfectNumber(number))
        {
            Console.WriteLine("The number is a perfect number.");
        }
        else
        {
            Console.WriteLine("The number is not a perfect number.");
        }
    }

    static bool IsPerfectNumber(int number)
    {
        int sum = 0;

        // Find the proper divisors and calculate their sum
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        // Check if the sum of divisors is equal to the number
        return sum == number;
    }
}
