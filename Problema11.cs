using System;

class Program
{
    static void Main()
    {
        Console.Write("Input the number of elements to be stored in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        int sum = 0;

        Console.WriteLine($"Input {n} elements in the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine($"Sum of all elements stored in the array is: {sum}");
    }
}
