using System;

namespace training;
class Program
{
    static void Main(string[] args)
    {
        Dogs dogs = new Dogs();
        dogs.Attack();
        dogs.Stay();
        dogs.Sit();
        dogs.SayHi();
        dogs.Run();
    }
}

public interface IAnimals
{
    void Run();
}

public interface IDogCommands : IAnimals
{
    void Stay();
    void Sit();
    void Attack();

    string DogName
    {
        set;
        get;
    }
}

interface Trainer
{

}

class Animals
{
    string AnimalName;

    public void SayHi()
    {
        Console.WriteLine("hi from the animals");
    }
}

class Dogs : Animals, IDogCommands, Trainer
{
    private string DogBreed;

    public void Stay()
    {
        Console.WriteLine("Dog is Staying");
    }

    public void Sit()
    {
        Console.WriteLine("Dog is Siting");
    }

    public void Attack()
    {
        Console.WriteLine("Dog is Attacking");
    }

    public void Run()
    {
        Console.WriteLine("Animal is running");
    }

    public string DogName { get; set; }
}


