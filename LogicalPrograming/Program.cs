using System;
using System.Collections.Generic;

class Program
{
    static int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };

    static void Main(string[] args)
    {
        Console.Write("Enter the change amount in Rs: ");
        int change = Convert.ToInt32(Console.ReadLine());

        List<int> changeNotes = CalculateChange(change);
        int numNotes = changeNotes.Count;

        Console.WriteLine($"Minimum number of notes: {numNotes}");
        Console.WriteLine("Change notes: ");
        foreach (int note in changeNotes)
        {
            Console.Write(note + " ");
        }
    }

    static List<int> CalculateChange(int change)
    {
        List<int> changeNotes = new List<int>();

        int index = 0;
        while (change > 0 && index < notes.Length)
        {
            if (change >= notes[index])
            {
                changeNotes.Add(notes[index]);
                change -= notes[index];
            }
            else
            {
                index++;
            }
        }

        return changeNotes;
    }
}
