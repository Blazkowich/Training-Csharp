namespace LambdaExpresion;

public delegate void myDelegate(string name);
class Program
{
    public event myDelegate myEvent;

    public Program()
    {
        myEvent += new myDelegate(SayHiEnglish);

        myEvent += new myDelegate(SayHiGeorgian);

        myEvent += new myDelegate(SayHiGerman);
    }

    static void Main(string[] args)
    {
        Program prog = new Program();
        prog.myEvent("Jack");
    }

    public void SayHiEnglish(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    public void SayHiGeorgian(string name)
    {
        Console.WriteLine("Gamarjoba " + name);
    }

    public void SayHiGerman(string name)
    {
        Console.WriteLine("Hallo " + name);
    }
}

