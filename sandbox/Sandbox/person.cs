// Person.cs
using System;

public class Person
{
    // Propriétés de la classe Person
    public string Name { get; set; }
    public int Age { get; set; }
    public string Occupation { get; set; }

    // Constructeur pour initialiser les données
    public Person(string name, int age, string occupation)
    {
        Name = name;
        Age = age;
        Occupation = occupation;
    }

    // Méthode pour afficher les informations de la personne
    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name}, I am {Age} years old and I work as a {Occupation}.");
    }
}
