using System;

public class Person
{
    public string Name { get; set; }

    // Constructorul pentru initializarea numelui
    public Person(string name)
    {
        Name = name;
    }

    // Override la metoda ToString pentru a returna numele
    public override string ToString()
    {
        return Name;
    }
}

public class Student : Person
{
    // Constructor care apeleaza constructorul din clasa parinte
    public Student(string name) : base(name) { }

    // Metoda Study care afiseaza ca studentul studiaza
    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }
}

public class Teacher : Person
{
    // Constructor care apeleaza constructorul din clasa parinte
    public Teacher(string name) : base(name) { }

    // Metoda Explain care afiseaza ca profesorul explica
    public void Explain()
    {
        Console.WriteLine($"{Name} is explaining.");
    }
}

class Program
{
    static void Main()
    {
        // Creare obiecte de tip Person, Student si Teacher
        Person[] people = new Person[3];

        // Citirea numelor de la utilizator
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter the name of person {i + 1}: ");
            string name = Console.ReadLine();

            if (i == 0)
                people[i] = new Student(name); // Primul student
            else if (i == 1)
                people[i] = new Student(name); // Al doilea student
            else
                people[i] = new Teacher(name); // Profesorul
        }

        // Afisarea detaliilor si apelarea metodelor pentru fiecare persoana
        foreach (var person in people)
        {
            Console.WriteLine($"Person: {person}");

            // Verificarea tipului de persoană și apelarea metodei corespunzătoare
            if (person is Student student)
            {
                student.Study(); // Studentul studiază
            }
            else if (person is Teacher teacher)
            {
                teacher.Explain(); // Profesorul explică
            }
        }
    }
}
