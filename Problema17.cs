using System;

public class Rational
{
    private int numerator;
    private int denominator;

    // Constructor
    public Rational(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");
        this.numerator = numerator;
        this.denominator = denominator;
        Simplify();
    }

    // Afișare număr rațional
    public void Display()
    {
        Console.WriteLine($"{numerator}/{denominator}");
    }

    // Simplificarea fracției
    private void Simplify()
    {
        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;
    }

    // Găsirea cel mai mare divizor comun
    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Adunare
    public static Rational operator +(Rational r1, Rational r2)
    {
        int numerator = r1.numerator * r2.denominator + r2.numerator * r1.denominator;
        int denominator = r1.denominator * r2.denominator;
        return new Rational(numerator, denominator);
    }

    // Scădere
    public static Rational operator -(Rational r1, Rational r2)
    {
        int numerator = r1.numerator * r2.denominator - r2.numerator * r1.denominator;
        int denominator = r1.denominator * r2.denominator;
        return new Rational(numerator, denominator);
    }

    // Înmulțire
    public static Rational operator *(Rational r1, Rational r2)
    {
        int numerator = r1.numerator * r2.numerator;
        int denominator = r1.denominator * r2.denominator;
        return new Rational(numerator, denominator);
    }

    // Împărțire
    public static Rational operator /(Rational r1, Rational r2)
    {
        if (r2.numerator == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        int numerator = r1.numerator * r2.denominator;
        int denominator = r1.denominator * r2.numerator;
        return new Rational(numerator, denominator);
    }

    // Comparare <
    public static bool operator <(Rational r1, Rational r2)
    {
        return r1.numerator * r2.denominator < r2.numerator * r1.denominator;
    }

    // Comparare >
    public static bool operator >(Rational r1, Rational r2)
    {
        return r1.numerator * r2.denominator > r2.numerator * r1.denominator;
    }

    // Comparare >=
    public static bool operator >=(Rational r1, Rational r2)
    {
        return r1.numerator * r2.denominator >= r2.numerator * r1.denominator;
    }

    // Comparare <=
    public static bool operator <=(Rational r1, Rational r2)
    {
        return r1.numerator * r2.denominator <= r2.numerator * r1.denominator;
    }

    // Comparare ==
    public static bool operator ==(Rational r1, Rational r2)
    {
        return r1.numerator * r2.denominator == r2.numerator * r1.denominator;
    }

    // Comparare !=
    public static bool operator !=(Rational r1, Rational r2)
    {
        return r1.numerator * r2.denominator != r2.numerator * r1.denominator;
    }

    // Conversia la șir de caractere
    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }
}

class Program
{
    static void Main()
    {
        Rational r1 = new Rational(3, 4);
        Rational r2 = new Rational(5, 6);

        Console.WriteLine("Rational 1: " + r1);
        Console.WriteLine("Rational 2: " + r2);

        // Adunare
        Rational sum = r1 + r2;
        Console.WriteLine($"Sum: {sum}");

        // Scădere
        Rational diff = r1 - r2;
        Console.WriteLine($"Difference: {diff}");

        // Înmulțire
        Rational product = r1 * r2;
        Console.WriteLine($"Product: {product}");

        // Împărțire
        Rational quotient = r1 / r2;
        Console.WriteLine($"Quotient: {quotient}");

        // Comparare
        Console.WriteLine($"r1 < r2: {r1 < r2}");
        Console.WriteLine($"r1 > r2: {r1 > r2}");
        Console.WriteLine($"r1 == r2: {r1 == r2}");
        Console.WriteLine($"r1 != r2: {r1 != r2}");
    }
}
