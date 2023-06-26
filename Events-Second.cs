namespace LambdaExpresion;

class Program
{
    static void Main(string[] args)
    {
        Football info = new Football();
        info.DisplayClub("Manchester United", "England");

        info.DisplayPlayerInformation("Ronaldo", "Real Madrid");
    }
}

class Football
{
    private DisplayInformation displayInfoInstance;

    public Football()
    {
        displayInfoInstance = new DisplayInformation();
        displayInfoInstance.DisplayDataAfterEvent += DisplayInfoInstance_DisplayDataAfterEvent;
        displayInfoInstance.DisplayDataBeforeEvent += DisplayInfoInstance_DisplayDataBeforeEvent;
    }

    private void DisplayInfoInstance_DisplayDataBeforeEvent()
    {
        Console.WriteLine("Information Has Been Displayer " + DateTime.Now.ToLongTimeString());
    }

    private void DisplayInfoInstance_DisplayDataAfterEvent()
    {
        Console.WriteLine("Information Has Been Displayer " + DateTime.Now.ToLongTimeString());
    }

    public void DisplayClub(string club, string country)
    {
        displayInfoInstance.DisplayClub(club, country); ;
    }

    public void DisplayPlayerInformation(string name, string club)
    {
        displayInfoInstance.DisplayPlayer(name, club);
    }
}

class DisplayInformation
{
    public delegate void DisplayDataAfterDelegate();
    public delegate void DisplayDataBeforeDelegate();

    public event DisplayDataBeforeDelegate DisplayDataBeforeEvent;

    public event DisplayDataAfterDelegate DisplayDataAfterEvent;

    public void DisplayClub(string clubName, string country)
    {
        DisplayDataBeforeEvent(); Console.WriteLine();
        Console.WriteLine($"{clubName} from {country}");
        DisplayDataAfterEvent(); Console.WriteLine();
    }

    public void DisplayPlayer(string playerName, string clubName)
    {
        DisplayDataBeforeEvent(); Console.WriteLine();
        Console.WriteLine($"{playerName} playes for {clubName}");
        DisplayDataAfterEvent(); Console.WriteLine();
    }
}

