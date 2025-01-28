using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        bool result = AlmostOnlyLetters(input);
        Console.WriteLine($"Result: {result}");
    }

    static bool AlmostOnlyLetters(string str)
    {
        if (string.IsNullOrEmpty(str) || str.Length < 2 || str[^1] != '.')
            return false;

        for (int i = 0; i < str.Length - 1; i++)
        {
            if (!char.IsLetter(str[i]) && str[i] != ' ')
                return false;
        }

        return true;
    }
}
