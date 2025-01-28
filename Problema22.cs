using System;

public class TempIsZeroException : Exception
{
    public TempIsZeroException(string message) : base(message) { }
}

public class Temperature
{
    public int CurrentTemperature { get; set; }

    public Temperature(int temperature)
    {
        CurrentTemperature = temperature;
    }

    public void DisplayTemperature()
    {
        if (CurrentTemperature == 0)
        {
            throw new TempIsZeroException("Temperature is zero! Cannot display it.");
        }
        else
        {
            Console.WriteLine($"The current temperature is: {CurrentTemperature}°C");
        }
    }
}

class Program
{
    static void Main()
    {
        // Part 1: Handle temperature input and display
        try
        {
            Console.WriteLine("Enter a temperature: ");
            int temp = int.Parse(Console.ReadLine());

            Temperature temperature = new Temperature(temp);
            temperature.DisplayTemperature();
        }
        catch (TempIsZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a valid integer for temperature.");
        }

        // Part 2: Handle array index input and exceptions
        int[] numbers = { 10, 20, 30, 40, 50 };

        while (true)
        {
            try
            {
                Console.WriteLine("\nEnter the index of the number you want to view (0-4): ");
                int index = int.Parse(Console.ReadLine());

                // Accessing the array
                Console.WriteLine($"You selected: {numbers[index]}");

                // Ask user if they want another integer or end the program
                Console.WriteLine("Do you want to see another number? (y/n): ");
                string choice = Console.ReadLine().ToLower();
                if (choice != "y")
                {
                    break;
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index! Please enter a number between 0 and 4.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }
        }
    }
}
