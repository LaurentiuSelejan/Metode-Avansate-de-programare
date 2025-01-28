using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un șir de caractere: ");
        string input = Console.ReadLine();

        int alphabetCount = 0, digitCount = 0, specialCharCount = 0;

        // Parcurgem fiecare caracter din șir
        foreach (char ch in input)
        {
            if (char.IsLetter(ch))
                alphabetCount++;
            else if (char.IsDigit(ch))
                digitCount++;
            else
                specialCharCount++;
        }

        // Afișăm rezultatele
        Console.WriteLine($"\nNumărul de litere în șir este: {alphabetCount}");
        Console.WriteLine($"Numărul de cifre în șir este: {digitCount}");
        Console.WriteLine($"Numărul de caractere speciale în șir este: {specialCharCount}");
    }
}
