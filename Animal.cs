using System;

// Klasa abstrakcyjna/polimorfizm
public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public abstract void MakeSound();
}

// Typ zwierzęcia - Ssaki
public class Mammal : Animal
{
    public Mammal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} makes a mammal sound.");
    }
}

// Typ zwierzęcia - Gady
public class Reptile : Animal
{
    public Reptile(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} hisses.");
    }
}

// Środowisko życia - Interfejs
public interface IHabitat
{
    void DescribeHabitat();
}

// Środowisko życia - Lądowe
public class LandHabitat : IHabitat
{
    public void DescribeHabitat()
    {
        Console.WriteLine("Lives on land.");
    }
}

// Środowisko życia - Wodne
public class WaterHabitat : IHabitat
{
    public void DescribeHabitat()
    {
        Console.WriteLine("Lives in water.");
    }
}

// Klasa wieloaspektowa, która łączy cechy zwierzęcia i jego środowiska życia
public class MultiAspectAnimal : Animal
{
    private readonly Animal _animal;
    private readonly IHabitat _habitat;

    public MultiAspectAnimal(Animal animal, IHabitat habitat)
    {
        _animal = animal;
        _habitat = habitat;
    }

    public override void MakeSound()
    {
        _animal.MakeSound();
    }

    public void DescribeHabitat()
    {
        _habitat.DescribeHabitat();
    }
}