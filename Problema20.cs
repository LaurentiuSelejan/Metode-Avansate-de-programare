using System;
using System.Collections.Generic;

public class Employee
{
    public int EmployeeId { get; set; }
    public string EmployeeFirstName { get; set; }
    public string EmployeeLastName { get; set; }
    public int EmployeeAge { get; set; }

    public Employee(int id, string firstName, string lastName, int age)
    {
        EmployeeId = id;
        EmployeeFirstName = firstName;
        EmployeeLastName = lastName;
        EmployeeAge = age;
    }

    public override string ToString()
    {
        return $"ID: {EmployeeId}, Name: {EmployeeFirstName} {EmployeeLastName}, Age: {EmployeeAge}";
    }
}

class Program
{
    // Metodă generică pentru Swap
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        // Exemplu de Swap cu variabile de tip int
        int a = 2, b = 3;
        Console.WriteLine($"Before swap: a={a}; b={b}");
        Swap(ref a, ref b);
        Console.WriteLine($"After swap: a={a}; b={b}");

        // Exemplu de Swap cu variabile de tip string
        string strA = "abc", strB = "def";
        Console.WriteLine($"Before swap: a={strA}; b={strB}");
        Swap(ref strA, ref strB);
        Console.WriteLine($"After swap: a={strA}; b={strB}");

        // Crearea unei liste de angajați
        List<Employee> employees = new List<Employee>
        {
            new Employee(1, "John", "Doe", 30),
            new Employee(2, "Jane", "Smith", 25),
            new Employee(3, "Michael", "Johnson", 35)
        };

        // Adăugarea unui angajat nou în listă
        employees.Add(new Employee(4, "Emily", "Davis", 28));

        // Afișarea angajaților
        Console.WriteLine("\nEmployees list:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }

        // Ștergerea unui angajat (de exemplu, angajatul cu ID 2)
        employees.RemoveAll(e => e.EmployeeId == 2);

        // Afișarea angajaților după eliminare
        Console.WriteLine("\nEmployees list after removal:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}
