using System.Collections;
namespace NonGenericArray;
class Program
{
    static void Main(string[] args)
    {
        var firstList = new List<Movies<double, DateTime>>();
        var secondList = new List<Movies<float, int>>();

        #region Dark Knight
        var darkKnight1 = new Movies<float, int>();

        darkKnight1.MovieName = "Batman Begins";
        darkKnight1.Director = "Christopher Nolan";
        darkKnight1.Rate = 8.3f;
        darkKnight1.ReleaseDate = 2005;


        var darkKnight2 = new Movies<float, int>();

        darkKnight2.MovieName = "The Dark Knight";
        darkKnight2.Director = "Christopher Nolan";
        darkKnight2.Rate = 9.0f;
        darkKnight2.ReleaseDate = 2008;


        var darkKnight3 = new Movies<float, int>();

        darkKnight3.MovieName = "The Dark Knight Rises";
        darkKnight3.Director = "Christopher Nolan";
        darkKnight3.Rate = 8.4f;
        darkKnight3.ReleaseDate = 2012;


        secondList.Add(darkKnight1);
        secondList.Add(darkKnight2);
        secondList.Add(darkKnight3);
        #endregion

        #region Lord Of The Rings
        var lotr1 = new Movies<double, DateTime>();
        lotr1.MovieName = "The Lord of the Rings: Fellowship of the Ring";
        lotr1.Director = "Peter Jackson";
        lotr1.Rate = 8.8;
        lotr1.ReleaseDate = new DateTime(2001, 12, 19);

        var lotr2 = new Movies<double, DateTime>();
        lotr2.MovieName = "The Lord of the Rings: The Two Towers";
        lotr2.Director = "Peter Jackson";
        lotr2.Rate = 8.7;
        lotr2.ReleaseDate = new DateTime(2002, 12, 18);

        var lotr3 = new Movies<double, DateTime>();
        lotr3.MovieName = "The Lord of the Rings: The Return of the King";
        lotr3.Director = "Peter Jackson";
        lotr3.Rate = 8.9;
        lotr3.ReleaseDate = new DateTime(2003, 12, 17);

        firstList.Add(lotr1);
        firstList.Add(lotr2);
        firstList.Add(lotr3);
        #endregion

        Console.WriteLine("First List - Lord Of The Rings\n");
        foreach(var movie in firstList)
        {
            Console.WriteLine($"Movie Name: {movie.MovieName}");
            Console.WriteLine($"Director: {movie.Director}");
            Console.WriteLine($"Rate: {movie.Rate}");
            Console.WriteLine($"Release Date: {movie.ReleaseDate.ToShortDateString()}");
            Console.WriteLine();
        }
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("Second List - Dark Knight\n");
        foreach (var movie in secondList)
        {
            Console.WriteLine($"Movie Name: {movie.MovieName}");
            Console.WriteLine($"Director: {movie.Director}");
            Console.WriteLine($"Rate: {movie.Rate}");
            Console.WriteLine($"Release Date: {movie.ReleaseDate}");
            Console.WriteLine();
        }
    }
}

class Movies<T, U>
{
    private string movieName;

    public string MovieName
    {
        get { return movieName; }
        set { movieName = value; }
    }


    private string director;

    public string Director
    {
        get { return director; }
        set { director = value; }
    }


    private U releaseDate;

    public U ReleaseDate
    {
        get { return releaseDate; }
        set { releaseDate = value; }
    }


    private T rate;

    public T Rate
    {
        get { return rate; }
        set { rate = value; }
    }
}
