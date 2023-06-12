using System.Collections;
namespace NonGenericArray;
class Program
{
    static void Main(string[] args)
    {
        Buildings<int> empireState = new Buildings<int>();
        empireState.Name = "Empire State";
        empireState.City = "New York";
        empireState.Height = 443;
        empireState.Weight = 365000;

        Console.WriteLine("Name - " + empireState.Name);
        Console.WriteLine("City - " + empireState.City);
        Console.WriteLine("Height - " + empireState.Height);
        Console.WriteLine("Weight - " + empireState.Weight);
    }
}

class Buildings<T>
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private string city;

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    private T height;

    public T Height
    {
        get { return height; }
        set { height = value; }
    }

    private T weight;

    public T Weight
    {
        get { return weight; }
        set { weight = value; }
    }
    
}
