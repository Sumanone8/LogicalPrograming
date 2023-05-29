using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of terms in the Fibonacci series: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");
        PrintFibonacciSeries(n);
    }

    static void PrintFibonacciSeries(int n)
    {
        int num1 = 0;
        int num2 = 1;

        Console.Write($"{num1} {num2} ");

        for (int i = 2; i < n; i++)
        {
            int nextNum = num1 + num2;
            Console.Write($"{nextNum} ");

            num1 = num2;
            num2 = nextNum;
        }

        Console.WriteLine();
    }
}
