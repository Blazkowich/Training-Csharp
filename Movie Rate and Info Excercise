using System;
using MovieNamespace;

namespace training;
class Program
{
    static void Main(string[] args)
    {
        MovieNamespace.Movie InceptionInstance = new MovieNamespace.Movie();
        MovieNamespace.Movie WildTalesInstance = new MovieNamespace.Movie();

        InceptionInstance.MovieName = "Inception";
        InceptionInstance.Rate = 8.8;
        InceptionInstance.ReleaseDate = new DateTime(2010, 7, 16);

        InceptionInstance.Languages = new Language[3];
        InceptionInstance.Languages[0] = Language.English;
        InceptionInstance.Languages[1] = Language.Russian;
        InceptionInstance.Languages[2] = Language.Georgian;

        InceptionInstance.Country = new Country[2];
        InceptionInstance.Country[0] = Country.Germany;
        InceptionInstance.Country[1] = Country.Turkey;

        InceptionInstance.Genres = new Genres[3];
        InceptionInstance.Genres[0] = Genres.Mdzafri;
        InceptionInstance.Genres[1] = Genres.Sexebi;
        InceptionInstance.Genres[2] = Genres.Horrori;


        WildTalesInstance.MovieName = "Wild Tales";
        WildTalesInstance.Rate = 8.1;
        WildTalesInstance.ReleaseDate = new DateTime(2014, 8, 21);

        WildTalesInstance.Languages = new Language[1];
        WildTalesInstance.Languages[0] = Language.Russian;

        WildTalesInstance.Country = new Country[2];
        WildTalesInstance.Country[0] = Country.Turkey;
        WildTalesInstance.Country[1] = Country.Germany;

        WildTalesInstance.Genres = new Genres[3];
        WildTalesInstance.Genres[0] = Genres.Horrori;
        WildTalesInstance.Genres[1] = Genres.Sexebi;
        WildTalesInstance.Genres[2] = Genres.Mdzafri;

        InceptionInstance.DisplayMovieInformation();
        WildTalesInstance.DisplayMovieInformation();

    }

}





-----------





using System;
namespace MovieNamespace
{
		struct Movie
		{
			private string movieName;
			private double rate;
			private DateTime relDate;
			private Genres[] genres;
			private Language[] languages;
			private Country[] countries;

			public string MovieName
			{
				get { return movieName; }
				set { movieName = value; }
			}

			public double Rate
			{
				get { return rate; }
				set { rate = value; }
			}

			public DateTime ReleaseDate
			{
				get { return relDate; }
				set { relDate = value; }
			}

			public Language[] Languages
			{
				get { return languages; }
				set { languages = value; }
			}

			public Country[] Country
			{
				get { return countries; }
				set { countries = value; }
			}

			public Genres[] Genres
			{
				get { return genres; }
				set { genres = value; }
			}

			public void DisplayMovieInformation()
			{
				Console.WriteLine($"Movies : {MovieName}" +
					$"\nRate : {Rate} out of 10" +
					$"\nReleased on : {relDate.ToShortDateString()}" +
					$"\nLanguages : ");

				for (int i = 0; i < Languages.Length; i++)
				{
					Console.Write(Languages[i]);
					if (i < Languages.Length - 1)
						Console.Write(", ");
					else
						Console.WriteLine();
				}

				Console.Write("Countries : ");
				for (int i = 0; i < Country.Length; i++)
				{
					Console.Write(Country[i]);
					if (i < Country.Length - 1)
						Console.Write(", ");
				}

				Console.Write("\nGenres : ");
				for (int i = 0; i < Genres.Length; i++)
				{
					Console.Write(Genres[i]);
					if (i < Genres.Length - 1)
						Console.Write(", ");
					else
						Console.WriteLine();
				}
				Console.WriteLine("------------");
			}
		}
	}

	enum Language
	{
		English,
		Georgian,
		Russian
	}

	enum Genres
	{
		Sexebi,
		Slolebi,
		Mdzafri,
		Horrori
	}

	enum Country
	{
		Usa,
		Germany,
		Georgia,
		Russia,
		Turkey
	}

