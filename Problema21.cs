using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int RoleId { get; set; }

    public Person(int personId, string firstName, string lastName, int age, int roleId)
    {
        PersonId = personId;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RoleId = roleId;
    }
}

public class Role
{
    public int RoleId { get; set; }
    public string RoleDescription { get; set; }

    public Role(int roleId, string roleDescription)
    {
        RoleId = roleId;
        RoleDescription = roleDescription;
    }
}

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double UnitPrice { get; set; }
    public string Category { get; set; }

    public Product(int productId, string name, double unitPrice, string category)
    {
        ProductId = productId;
        Name = name;
        UnitPrice = unitPrice;
        Category = category;
    }
}

public class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }

    public Customer(int customerId, string customerName, string country, string city, string phone)
    {
        CustomerId = customerId;
        CustomerName = customerName;
        Country = country;
        City = city;
        Phone = phone;
    }
}

public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public int CustomerId { get; set; }

    public Order(int orderId, DateTime orderDate, int customerId)
    {
        OrderId = orderId;
        OrderDate = orderDate;
        CustomerId = customerId;
    }
}

public class OrderDetails
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }

    public OrderDetails(int orderId, int productId, int quantity)
    {
        OrderId = orderId;
        ProductId = productId;
        Quantity = quantity;
    }
}

class Program
{
    static void Main()
    {
        // Crearea listelor de persoane și roluri
        var people = new List<Person>
        {
            new Person(1, "FirstName1", "LastName1", 25, 1),
            new Person(2, "FirstName2", "LastName2", 30, 2),
            new Person(3, "FirstName3", "LastName3", 22, 3),
            new Person(4, "FirstName4", "LastName4", 19, 1),
            new Person(5, "FirstName5", "LastName5", 40, 2)
        };

        var roles = new List<Role>
        {
            new Role(1, "Leader"),
            new Role(2, "Manager"),
            new Role(3, "Employee")
        };

        // Operații pe persoanele din listă
        var peopleAbove18 = people.Where(p => p.Age > 18).ToList();
        var peopleNames = people.Select(p => $"{p.FirstName} {p.LastName}").ToList();
        var peopleWithRole1 = people.Where(p => p.RoleId == 1).ToList();
        var youngestTwo = people.OrderBy(p => p.Age).Take(2).ToList();
        var skipYoungestTwo = people.OrderBy(p => p.Age).Skip(2).ToList();
        var peopleWithRoles = people.Join(roles, p => p.RoleId, r => r.RoleId, (p, r) => new { p.FirstName, p.LastName, Role = r.RoleDescription }).ToList();
        var peopleOrderedByAgeDesc = people.OrderByDescending(p => p.Age).ToList();
        var peopleGroupedByRole = people.GroupBy(p => p.RoleId).ToList();
        var personFirstName1 = people.FirstOrDefault(p => p.FirstName == "FirstName1");
        var totalPeopleWithLeaderRole = people.Count(p => p.RoleId == 1);
        var containsBA = people.Any(p => p.FirstName.Contains("BA"));
        var personWithAge60 = people.FirstOrDefault(p => p.Age == 60);

        // Crearea listelor de produse, clienți, comenzi și detalii comenzi
        var products = new List<Product>
        {
            new Product(1, "Product1", 15.5, "Food"),
            new Product(2, "Product2", 8.0, "Drink"),
            new Product(3, "Product3", 12.3, "Food"),
            new Product(4, "Product4", 25.0, "Care"),
            new Product(5, "Product5", 7.5, "Other")
        };

        var customers = new List<Customer>
        {
            new Customer(1, "Customer1", "Romania", "Bucharest", "0723 456 789"),
            new Customer(2, "Customer2", "Romania", "Cluj", "0721 234 567"),
            new Customer(3, "Customer3", "UK", "London", "0756 345 678")
        };

        var orders = new List<Order>
        {
            new Order(1, new DateTime(2021, 6, 15), 1),
            new Order(2, new DateTime(2021, 12, 25), 2),
            new Order(3, new DateTime(2020, 3, 5), 3)
        };

        var orderDetails = new List<OrderDetails>
        {
            new OrderDetails(1, 1, 2),
            new OrderDetails(1, 3, 1),
            new OrderDetails(2, 2, 5)
        };

        // Operații pe produsele din listă
        var productsAbove10 = products.Where(p => p.UnitPrice >= 10).ToList();
        var productNames = products.Select(p => p.Name).ToList();
        var productNamesAndPrices = products.Where(p => p.UnitPrice >= 10).Select(p => new { p.Name, p.UnitPrice }).ToList();
        var mostExpensiveTwoProducts = products.OrderByDescending(p => p.UnitPrice).Take(2).ToList();
        var allButMostExpensiveTwoProducts = products.OrderByDescending(p => p.UnitPrice).Skip(2).ToList();
        var productsByCategory = products.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice).ToList();
        var productsGroupedByCategory = products.GroupBy(p => p.Category).ToList();
        var customersWithOrdersIn2021 = orders.Where(o => o.OrderDate.Year == 2021).Join(customers, o => o.CustomerId, c => c.CustomerId, (o, c) => c).ToList();
        var firstCustomerWithPhone = customers.FirstOrDefault(c => c.Phone == "0723 456 789");
        var totalCustomersFromLondon = customers.Count(c => c.City == "London");
        var anyCustomerFromRomania = customers.Any(c => c.Country == "Romania");
        var totalOrders2021 = orders.Where(o => o.OrderDate.Year == 2021).Sum(o => orderDetails.Where(od => od.OrderId == o.OrderId).Sum(od => products.First(p => p.ProductId == od.ProductId).UnitPrice * od.Quantity));

        // Afișare rezultate
        Console.WriteLine("People with age > 18:");
        foreach (var person in peopleAbove18) Console.WriteLine(person.FirstName);

        Console.WriteLine("\nAll people names:");
        peopleNames.ForEach(Console.WriteLine);

        Console.WriteLine("\nPeople with RoleId=1:");
        foreach (var person in peopleWithRole1) Console.WriteLine(person.FirstName);

        Console.WriteLine("\nYoungest two people:");
        foreach (var person in youngestTwo) Console.WriteLine(person.FirstName);

        Console.WriteLine("\nPeople ordered by age descending:");
        foreach (var person in peopleOrderedByAgeDesc) Console.WriteLine(person.FirstName);

        Console.WriteLine("\nPeople grouped by role:");
        foreach (var group in peopleGroupedByRole)
        {
            Console.WriteLine($"Role ID: {group.Key}");
            foreach (var person in group)
                Console.WriteLine(person.FirstName);
        }

        Console.WriteLine("\nProduct with price >= 10:");
        foreach (var product in productsAbove10) Console.WriteLine(product.Name);

        Console.WriteLine("\nCustomers that made orders in 2021:");
        foreach (var customer in customersWithOrdersIn2021) Console.WriteLine(customer.CustomerName);

        Console.WriteLine("\nTotal sum of orders from 2021: " + totalOrders2021);
    }
}
