using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Introduce un număr: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Verifică dacă numărul se termină cu două zerouri
            if (num % 100 == 0)
                break;

            numbers.Add(num);
        }

        Console.WriteLine("\nNumerele introduse sunt:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
