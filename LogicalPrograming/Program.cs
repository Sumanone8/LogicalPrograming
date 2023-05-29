using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of distinct coupon numbers: ");
        int numCoupons = Convert.ToInt32(Console.ReadLine());

        int totalRandomNumbersNeeded = GenerateDistinctCoupons(numCoupons);

        Console.WriteLine($"Total random numbers needed to have all distinct coupons: {totalRandomNumbersNeeded}");
    }

    static int GenerateDistinctCoupons(int numCoupons)
    {
        Random random = new Random();
        HashSet<int> distinctCoupons = new HashSet<int>();
        int totalRandomNumbersNeeded = 0;

        while (distinctCoupons.Count < numCoupons)
        {
            int randomNumber = random.Next(1, numCoupons + 1);

            if (!distinctCoupons.Contains(randomNumber))
            {
                distinctCoupons.Add(randomNumber);
            }

            totalRandomNumbersNeeded++;
        }

        return totalRandomNumbersNeeded;
    }
}

