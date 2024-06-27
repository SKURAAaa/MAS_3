using System.Collections.Generic;

public class Keeper
{
    public string Name { get; set; }
    public int Experience { get; set; }
    public List<Animal> Animals { get; set; }

    public Keeper()
    {
        Animals = new List<Animal>();
    }
}