using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        string mixedString = MixTwoStrings(str1, str2);
        Console.WriteLine($"Result: {mixedString}");
    }

    static string MixTwoStrings(string str1, string str2)
    {
        int len1 = str1.Length;
        int len2 = str2.Length;
        int maxLength = Math.Max(len1, len2);
        char[] result = new char[len1 + len2];

        int index = 0;
        for (int i = 0; i < maxLength; i++)
        {
            if (i < len1)
                result[index++] = str1[i];
            if (i < len2)
                result[index++] = str2[i];
        }

        return new string(result, 0, index);
    }
}
