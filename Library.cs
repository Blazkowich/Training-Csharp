using System;
using System.Collections.Generic;

public class Library
{
    private Dictionary<string, string> dictionary;
    private Dictionary<string, string> secondDictionary;
    private int counter;
    private string inputName;
    private string numEnter;
    private string inputPass;
    private string adminName;
    private string adminBaseName;
    private string customerBaseName;
    private string fixedPass;
    private string adminPass;
    private string customerPassword;
    private List<string> logins;
    private bool boolean;

    public Library()
    {
        dictionary = new Dictionary<string, string>();
        secondDictionary = new Dictionary<string, string>();
        counter = 1;
        numEnter = "";
        inputName = "";
        inputPass = "";
        adminName = "";
        adminBaseName = "roger";
        customerBaseName = "customer";
        fixedPass = "";
        adminPass = "123";
        customerPassword = "customer";
        logins = new List<string> { "roger", "customer" };
        boolean = true;
    }

    public void LogIn()
    {
        boolean = true;
        while (boolean)
        {
            if (inputName == "exit")
            {
                boolean = false;
                Console.WriteLine("Bye.");
                Environment.Exit(0);
            }
            else if (!logins.Contains(inputName))
            {
                Console.WriteLine("Login Is Not Correct");
                ReadLoginCredentials();
            }
            else if (inputName == adminBaseName)
            {
                boolean = false;
                Console.WriteLine("Welcome Roger!");
            }
            else if (inputName == customerBaseName)
            {
                boolean = false;
                Console.WriteLine("Welcome Customer");
            }
            else
            {
                Console.WriteLine("Login Is Not Correct");
                ReadLoginCredentials();
            }
        }
    }

    public void ReadLoginCredentials()
    {
        Console.Write("Please Enter Login: ");
        inputName = Console.ReadLine();
    }

    public void ReadPassword()
    {
        Console.Write("Please Enter Password: ");
        inputPass = Console.ReadLine();
    }

    public void Loop()
        
    {
        while (numEnter != "0")
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Read All");
            Console.WriteLine("4. Read Book By ID");
            Console.Write("Please Choose: ");
            string numEnter = Console.ReadLine();

            switch (numEnter)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    DeleteBook();
                    break;
                case "3":
                    ReadAllBooks();
                    break;
                case "4":
                    ReadBookByID();
                    break;
                case "0":
                    Console.WriteLine("Exit In Login Menu.");
                    LogIn();
                    ReadPassword();
                    LoopPassword();
                    break;
                default:
                    Console.WriteLine("Wrong Character. Try Another");
                    break;
            }
        }
    }

    public void AddBook()
    {
        Console.Write("Enter ID: ");
        string bookID = Console.ReadLine();
        Console.Write("Enter Book Name: ");
        string bookName = Console.ReadLine();

        if (dictionary.ContainsKey(bookID.ToLower()) || dictionary.ContainsValue(bookName.ToLower()))
        {
            Console.WriteLine("There Already exists ID or Book in Dictionary. Input Another ID or Book Name.");
        }
        else if (string.IsNullOrEmpty(bookID) || string.IsNullOrEmpty(bookName))
        {
            Console.WriteLine("Text is Empty. Write Correct");
        }
        else
        {
            dictionary.Add(bookID.ToLower(), bookName.ToLower());
            Console.WriteLine("Dictionary: ");
            ReadAllBooks();
        }
    }

    public void DeleteBook()
    {
        Console.Write("Enter ID of the book to delete: ");
        string bookID = Console.ReadLine();

        if (dictionary.ContainsKey(bookID.ToLower()))
        {
            dictionary.Remove(bookID.ToLower());
            Console.WriteLine("Book deleted successfully.");
            Console.WriteLine("Dictionary: ");
            ReadAllBooks();
        }
        else
        {
            Console.WriteLine("Book with the given ID does not exist.");
        }
    }

    public void ReadAllBooks()
    {
        if (dictionary.Count == 0)
        {
            Console.WriteLine("No books in the library.");
        }
        else
        {
            foreach (KeyValuePair<string, string> book in dictionary)
            {
                Console.WriteLine("ID: " + book.Key + ", Name: " + book.Value);
            }
        }
    }

    public void ReadBookByID()
    {
        Console.Write("Enter ID of the book to read: ");
        string bookID = Console.ReadLine();

        if (dictionary.TryGetValue(bookID.ToLower(), out string bookName))
        {
            Console.WriteLine("Book found:");
            Console.WriteLine("ID: " + bookID + ", Name: " + bookName);
        }
        else
        {
            Console.WriteLine("Book with the given ID does not exist.");
        }
    }

    public void LoopPassword()
    {
        if (inputPass == "exit")
        {
            Console.WriteLine("Bye.");
            Environment.Exit(0);
        }
        else if (inputPass == adminPass && inputName == adminBaseName)
        {
            Loop();
        }
        else if (inputPass == customerPassword && inputName == customerBaseName)
        {
            Console.WriteLine("Customer Mode");
            Loop();
        }
        else
        {
            Console.WriteLine("Wrong Password. Try Again.");
            ReadPassword();
            LoopPassword();
        }
    }

    public static void Main()
    {
        Library library = new Library();
        library.LogIn();
        library.ReadPassword();
        library.LoopPassword();
    }
}



