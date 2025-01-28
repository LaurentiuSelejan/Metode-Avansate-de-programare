using System;

public class Point
{
    public double x, y;

    // Constructor de inițializare
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // Constructor de copiere
    public Point(Point other)
    {
        this.x = other.x;
        this.y = other.y;
    }

    // Metodă pentru citirea unui punct
    public static Point ReadPoint()
    {
        Console.Write("Enter x coordinate: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y coordinate: ");
        double y = Convert.ToDouble(Console.ReadLine());

        return new Point(x, y);
    }

    // Metodă pentru afișarea unui punct
    public void WritePoint()
    {
        Console.WriteLine($"Point({x}, {y})");
    }

    // Metodă pentru calcularea distanței între două puncte
    public static double Distance(Point p1, Point p2)
    {
        double dx = p2.x - p1.x;
        double dy = p2.y - p1.y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}

public class Triangle
{
    public Point A, B, C;

    // Constructor de inițializare
    public Triangle(Point A, Point B, Point C)
    {
        this.A = new Point(A); // Copiere obiecte
        this.B = new Point(B);
        this.C = new Point(C);
    }

    // Metodă pentru citirea unui triunghi
    public static Triangle ReadTriangle()
    {
        Console.WriteLine("Enter the coordinates of the triangle vertices:");
        Point A = Point.ReadPoint();
        Point B = Point.ReadPoint();
        Point C = Point.ReadPoint();

        return new Triangle(A, B, C);
    }

    // Metodă pentru afișarea triunghiului
    public void WriteTriangle()
    {
        Console.WriteLine("Triangle vertices:");
        A.WritePoint();
        B.WritePoint();
        C.WritePoint();
    }

    // Metodă pentru calcularea perimetrului triunghiului
    public double Perimeter()
    {
        double AB = Point.Distance(A, B);
        double BC = Point.Distance(B, C);
        double CA = Point.Distance(C, A);
        return AB + BC + CA;
    }

    // Metodă pentru calcularea ariei triunghiului folosind formula semiperimetrului
    public double Area()
    {
        double AB = Point.Distance(A, B);
        double BC = Point.Distance(B, C);
        double CA = Point.Distance(C, A);

        double s = Perimeter() / 2;
        return Math.Sqrt(s * (s - AB) * (s - BC) * (s - CA));
    }
}

class Program
{
    static void Main()
    {
        // Citirea și afișarea unui triunghi
        Triangle triangle = Triangle.ReadTriangle();
        triangle.WriteTriangle();

        // Calcularea perimetrului și ariei triunghiului
        double perimeter = triangle.Perimeter();
        double area = triangle.Area();

        Console.WriteLine($"Perimeter of the triangle: {perimeter}");
        Console.WriteLine($"Area of the triangle: {area}");
    }
}
