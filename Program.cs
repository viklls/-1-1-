using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        for (int i = 1; i <= 100; i++)
        {
            numbers.Add(i);
        }

        int count = 0;
        int rowLength = 10;
        foreach (var num in numbers)
        {
            Console.Write(num.ToString().PadLeft(4));
            count++;
            if (count % rowLength == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine("\n\nСпіральний вивід:\n");

        int rowCount = numbers.Count / rowLength;
        for (int i = 0; i < rowCount; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < rowLength; j++)
                {
                    Console.Write(numbers[i * rowLength + j].ToString().PadLeft(4));
                }
            }
            else
            {
                for (int j = rowLength - 1; j >= 0; j--)
                {
                    Console.Write(numbers[i * rowLength + j].ToString().PadLeft(4));
                }
            }
            Console.WriteLine();
        }
    }
}