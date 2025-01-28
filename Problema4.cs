using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu coeficientul a (a ≠ 0): ");
        double a = Convert.ToDouble(Console.ReadLine());

        // Verificăm că a ≠ 0
        if (a == 0)
        {
            Console.WriteLine("Eroare: a trebuie să fie diferit de zero!");
            return;
        }

        Console.Write("Introdu coeficientul b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Calculăm soluția x
        double x = -b / a;

        Console.WriteLine($"\nSoluția ecuației {a} * x + {b} = 0 este: x = {x}");
    }
}
