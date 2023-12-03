using System;
using System.Collections.Generic;

// Interface representing the ability to fly
public interface IFlight
{
    void Fly();
}

// Base class for all birds
public class Bird
{
    private string name;

    public Bird(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
    }

    public virtual void Move()
    {
        Console.WriteLine($"{Name}'s movement behavior: *FLIES BY FLAPS WINGS*");
    }
}

// Duck class inherits from Bird and implements IFlight
public class Duck : Bird, IFlight
{
    private string colorPalette;

    public Duck(string name, string colorPalette) : base(name)
    {
        this.colorPalette = colorPalette;
    }

    public string ColorPalette
    {
        get { return colorPalette; }
    }

    public void Quack()
    {
        Console.WriteLine($"{Name} says quack.");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} is swimming.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name}'s movement behavior: *SLIDES BY ITS BELLY*");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying by flapping its wings.");
    }
}


// Eagle class inherits from Bird and implements IFlight
public class Eagle : Bird, IFlight
{
    private float topSpeed;
    private float visionRange;

    public Eagle(string name, float topSpeed, float visionRange) : base(name)
    {
        this.topSpeed = topSpeed;
        this.visionRange = visionRange;
    }

    public float TopSpeed
    {
        get { return topSpeed; }
    }

    public float VisionRange
    {
        get { return visionRange; }
    }

    public void Perch()
    {
        Console.WriteLine($"{Name} is perching.");
    }

    public void SearchForPrey()
    {
        Console.WriteLine($"{Name} is searching for prey.");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying by flapping its wings.");
    }
}

// FlightlessBird class inherits from Bird
public class FlightlessBird : Bird
{
    public FlightlessBird(string name) : base(name)
    {
    }

    public override void Move()
    {
        Console.WriteLine($"{Name}'s movement behavior: *HIDES HEAD IN THE SAND AS IT CANNOT FLY*");
    }
}

// RubberDuck class inherits from Duck
public class RubberDuck : Duck
{
    public RubberDuck() : base("Yellow Rubber Duck", "Yellow")
    {
    }

    public override void Move()
    {
        Console.WriteLine($"{Name}'s movement behavior: FLOATS IN WATER");
    }
}

class Program
{
    static void Main()
    {
        List<Bird> birds = new List<Bird>
        {
            new Duck("Mallard Duck", "Multicolored"),
            new FlightlessBird("Ostrich"),
            new Eagle("Bald Eagle", 120.0f, 5000.0f),
            new FlightlessBird("Emperor Penguin"),
            new RubberDuck()
        };

        Console.WriteLine("Number of birds in the simulation: " + birds.Count);

        foreach (var bird in birds)
        {
            bird.Move();
        }
    }
}
