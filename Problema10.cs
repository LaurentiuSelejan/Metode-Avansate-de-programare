using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceți baza: ");
        int baseNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceți exponentul: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        long result = ToThePowerOf(baseNum, exponent);
        Console.WriteLine($"Rezultat: {result}");
    }

    static long ToThePowerOf(int baseNum, int exponent)
    {
        if (exponent == 0)
            return 1; // Orice număr la puterea 0 este 1

        long result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNum; // Înmulțim repetat baza
        }

        return result;
    }
}
