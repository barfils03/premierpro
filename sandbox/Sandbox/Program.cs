// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Création d'objets de type Person
        Person person1 = new Person("Alice", 30, "Engineer");
        Person person2 = new Person("Bob", 25, "Designer");

        // Appel de la méthode Introduce pour chaque personne
        person1.Introduce();
        person2.Introduce();
    }
}
