using System;

// Klasa bazowa dla dynamicznych zwierząt
public abstract class DynamicAnimal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public abstract void MakeSound();
    public abstract void DescribeAnimal();
}

// Dynamiczne ssaki
public class DynamicMammal : DynamicAnimal
{
    public DynamicMammal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} makes a mammal sound.");
    }

    public override void DescribeAnimal()
    {
        Console.WriteLine($"{Name} is a mammal.");
    }
}

// Dynamiczne gady
public class DynamicReptile : DynamicAnimal
{
    public DynamicReptile(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} hisses.");
    }

    public override void DescribeAnimal()
    {
        Console.WriteLine($"{Name} is a reptile.");
    }
}

// Klasa, która łączy dynamiczne zwierzęta z ich środowiskiem życia
public class DynamicHabitatAnimal
{
    // Dynamiczne dziedziczenie poprzez agregację/kompozycję z ograniczeniem {xor}
    private DynamicAnimal _animal;
    private IHabitat _habitat;

    public DynamicHabitatAnimal(DynamicAnimal animal, IHabitat habitat = null)
    {
        _animal = animal;
        _habitat = habitat;
    }

    public void ChangeAnimal(DynamicAnimal newAnimal)
    {
        _animal = newAnimal;
    }

    public void ChangeHabitat(IHabitat newHabitat)
    {
        _habitat = newHabitat;
    }

    public void MakeSound()
    {
        _animal?.MakeSound();
    }

    public void DescribeAnimal()
    {
        _animal?.DescribeAnimal();
    }

    public void DescribeHabitat()
    {
        _habitat?.DescribeHabitat();
    }
}