
using System.Diagnostics;
namespace _10Head;

class Program
{
    static void Main(string[] args)
    {

        Animals animals = new Animals("Dog");

        Console.WriteLine(animals.AnimalName);

        animals = new Animals("Cat");
        Console.WriteLine(animals.AnimalName);


    }
}

class Animals
{
    readonly private string animalName;

    public string AnimalName
    {
        get => animalName;
    }

    public Animals(string name)
    {
        animalName = name;
    }
}

