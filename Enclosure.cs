using System.Collections.Generic;

public class Enclosure
{
    public string Name { get; set; }
    public List<Animal> Animals { get; set; }

    public Enclosure(string name)
    {
        Name = name;
        Animals = new List<Animal>();
    }

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }
}