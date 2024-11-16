using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Person> persons = new List<Person>()
        {
            new Person(){ Name = "Andrey", Age = 24, City = "Kyiv"},
            new Person(){ Name = "Liza", Age = 18, City = "Odesa" },
            new Person(){ Name = "Oleg", Age = 15, City = "London" },
            new Person(){ Name = "Sergey", Age = 55, City = "Kyiv" },
            new Person(){ Name = "Sergey", Age = 32, City = "Lviv" }
        };

        var peopleOlderThan25 = persons.Where(p => p.Age > 25).ToList();
        Console.WriteLine("People older than 25:");
        foreach (var person in peopleOlderThan25)
        {
            Console.WriteLine($"{person.Name}, Age: {person.Age}, City: {person.City}");
        }

        var peopleNotInLondon = persons.Where(p => p.City != "London").ToList();
        Console.WriteLine("\nPeople not in London:");
        foreach (var person in peopleNotInLondon)
        {
            Console.WriteLine($"{person.Name}, Age: {person.Age}, City: {person.City}");
        }

        var peopleInKyiv = persons.Where(p => p.City == "Kyiv").Select(p => p.Name).ToList();
        Console.WriteLine("\nPeople living in Kyiv:");
        foreach (var name in peopleInKyiv)
        {
            Console.WriteLine(name);
        }

        var sergeyOlderThan35 = persons.Where(p => p.Age > 35 && p.Name == "Sergey").ToList();
        Console.WriteLine("\nSergey older than 35:");
        foreach (var person in sergeyOlderThan35)
        {
            Console.WriteLine($"{person.Name}, Age: {person.Age}, City: {person.City}");
        }

       var peopleInOdesa = persons.Where(p => p.City == "Odesa").ToList();
        Console.WriteLine("\nPeople living in Odesa:");
        foreach (var person in peopleInOdesa)
        {
            Console.WriteLine($"{person.Name}, Age: {person.Age}, City: {person.City}");
        }
    }
}
