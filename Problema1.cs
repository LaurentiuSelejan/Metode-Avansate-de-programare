using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu primul număr: ");
        double numar1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introdu al doilea număr: ");
        double numar2 = Convert.ToDouble(Console.ReadLine());

        double suma = numar1 + numar2;
        Console.WriteLine($"Suma numerelor {numar1} și {numar2} este: {suma}");
    }
}
