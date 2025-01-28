using System;

class Program
{
    static void Main()
    {
        // Citirea primului număr
        Console.Write("Introduce primul număr: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Citirea celui de-al doilea număr
        Console.Write("Introduce al doilea număr: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Citirea operatorului
        Console.Write("Introduce operația (+, -, x, /): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Linie nouă după introducerea caracterului

        double result;

        // Utilizarea switch pentru a trata fiecare operator
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Rezultat: {num1} + {num2} = {result}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"Rezultat: {num1} - {num2} = {result}");
                break;
            case 'x':
            case '*':  // Permitem și * pentru înmulțire
                result = num1 * num2;
                Console.WriteLine($"Rezultat: {num1} x {num2} = {result}");
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Rezultat: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Eroare: Împărțirea la zero nu este permisă!");
                }
                break;
            default:
                Console.WriteLine("Unrecognized character");
                break;
        }
    }
}
