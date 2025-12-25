using System;
using System.Collections.Generic;

abstract class Animal
{
    protected string speciesName;
    protected double weight;
    protected int age;

    protected Animal(string speciesName, double weight, int age)
    {
        this.speciesName = speciesName;
        this.weight = weight;
        this.age = age;
    }

    public abstract double GetDosage();
    public abstract string GetFeedSchedule();
}

// Alt sınıflar AYNI DOSYANIN İÇİNDE

class Horse : Animal
{
    public Horse(string speciesName, double weight, int age)
        : base(speciesName, weight, age) { }

    public override double GetDosage()
    {
        return weight * 0.02;
    }

    public override string GetFeedSchedule()
    {
        return "Günde 3 kez, ot bazlı yem";
    }
}

class Lion : Animal
{
    public Lion(string speciesName, double weight, int age)
        : base(speciesName, weight, age) { }

    public override double GetDosage()
    {
        return weight * 0.05;
    }

    public override string GetFeedSchedule()
    {
        return "Günde 2 kez, et bazlı yem";
    }
}

class Rat : Animal
{
    public Rat(string speciesName, double weight, int age)
        : base(speciesName, weight, age) { }

    public override double GetDosage()
    {
        return weight * 0.01;
    }

    public override string GetFeedSchedule()
    {
        return "Günde 4 kez, tahıl bazlı yem";
    }
}

class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>
        {
            new Horse("At", 400, 5),
            new Lion("Aslan", 190, 7),
            new Rat("Sıçan", 2, 1)
        };

        foreach (Animal animal in animals)
        {
            Console.WriteLine($"Tür: {animal.GetType().Name}");
            Console.WriteLine($"Yem Zamanı: {animal.GetFeedSchedule()}");
            Console.WriteLine($"İlaç Dozu: {animal.GetDosage()}");
            Console.WriteLine("------------------------");
        }
    }
}
