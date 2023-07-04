
using System.Diagnostics;
namespace _10Head;

class Program
{
    static void Main(string[] args)
    {
        Animals animals = new Animals();
        dynamic value = 0;
        Console.WriteLine("value is " + value);
        Console.WriteLine("value type is " + value.GetType().Name);


        value = "string";
        Console.WriteLine("value is " + value);
        Console.WriteLine("value type is " + value.GetType().Name);

        value = new Animals();
        value.Name = "Cat";
        
        Console.WriteLine("value is " + value.Name);
        Console.WriteLine("value type is " + value.GetType().Name);


    }
}

class Animals
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

