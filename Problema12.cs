using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Input the number of elements to be stored in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        List<int> evenNumbers = new List<int>();
        List<int> oddNumbers = new List<int>();

        Console.WriteLine($"Input {n} elements in the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());

            if (arr[i] % 2 == 0)
                evenNumbers.Add(arr[i]);
            else
                oddNumbers.Add(arr[i]);
        }

        Console.WriteLine("The Even elements are:");
        foreach (int num in evenNumbers)
            Console.Write(num + " ");

        Console.WriteLine("\nThe Odd elements are:");
        foreach (int num in oddNumbers)
            Console.Write(num + " ");
    }
}
