using System;

class Program
{
    static void Main()
    {
        // Citirea numerelor de la tastatură
        Console.Write("Introdu primul număr: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introdu al doilea număr: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Afișarea valorilor inițiale
        Console.WriteLine($"\nÎnainte de interschimbare: num1 = {num1}, num2 = {num2}");

        // Interschimbarea valorilor
        int temp = num1;
        num1 = num2;
        num2 = temp;

        // Afișarea valorilor după interschimbare
        Console.WriteLine($"După interschimbare: num1 = {num1}, num2 = {num2}");
    }
}
