using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = DecimalDigitInformation(input);
        Console.WriteLine(result);
    }

    static string DecimalDigitInformation(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (Char.IsDigit(str[i]))
            {
                return $"Digit {str[i]} at position {i}";
            }
        }
        return "No digit found!";
    }
}
