using System;

class Program
{
    static void Main()
    {
        // Citirea datelor de la utilizator
        Console.Write("Introduce distanța (metri): ");
        double distanceMeters = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce ore: ");
        int hours = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce minute: ");
        int minutes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce secunde: ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        // Calculul timpului total în secunde
        double totalTimeSeconds = (hours * 3600) + (minutes * 60) + seconds;

        // Calculul vitezei
        double speedMetersPerSec = distanceMeters / totalTimeSeconds;
        double speedKmPerHour = (distanceMeters / 1000) / (totalTimeSeconds / 3600);
        double speedMilesPerHour = speedKmPerHour * 0.621371; // 1 km/h = 0.621371 mile/h

        // Afișarea rezultatelor
        Console.WriteLine($"\nViteza ta în metri/secundă este: {speedMetersPerSec:F6}");
        Console.WriteLine($"Viteza ta în km/h este: {speedKmPerHour:F6}");
        Console.WriteLine($"Viteza ta în mile/h este: {speedMilesPerHour:F6}");
    }
}
