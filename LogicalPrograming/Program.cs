using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int reversedNumber = ReverseNumber(number);

        Console.WriteLine($"The reversed number is: {reversedNumber}");
    }

    static int ReverseNumber(int number)
    {
        int reversedNumber = 0;

        while (number != 0)
        {
            int remainder = number % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            number /= 10;
        }

        return reversedNumber;
    }
}

