using System;

class Program
{
    static void Main()
    {
        // Citirea numărului zecimal de la utilizator
        Console.Write("Introduce un număr zecimal: ");
        int decimalNumber = Convert.ToInt32(Console.ReadLine());

        // Conversia numărului în binar
        string binary = Convert.ToString(decimalNumber, 2);

        // Afișarea rezultatului
        Console.WriteLine($"Binar: {binary}");
    }
}
