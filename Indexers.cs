namespace _10Head;

class Program
{
    static void Main(string[] args)
    {
        Animals animals = new Animals();

        animals[0] = "Dog";
        animals[1] = "Cat";
        animals[2] = "Horse";

        Console.WriteLine(animals[2]);
    }
}

class Animals
{
    private string[] name = new string[100];

    public string this[int index]
    {
        get { return name[index]; }
        set { name[index] = value; }
    }
}

