using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un număr pozitiv: ");
        int number = Convert.ToInt32(Console.ReadLine());

        bool containsThree = IfNumberContains3(number);
        Console.WriteLine($"Rezultat: {containsThree}");
    }

    static bool IfNumberContains3(int num)
    {
        while (num > 0)
        {
            int lastDigit = num % 10; // Extragem ultima cifră
            if (lastDigit == 3)
                return true;
            num /= 10; // Eliminăm ultima cifră
        }
        return false;
    }
}
