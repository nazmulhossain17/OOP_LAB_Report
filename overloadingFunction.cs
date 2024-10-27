using System;

public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int ReleaseYear { get; set; }
    public decimal Rating { get; set; } 

    // Default constructor
    public Movie()
    {
        Title = "Untitled";
        Director = "Unknown Director";
        ReleaseYear = 0;
        Rating = 0.0m;
    }

    // Constructor with title and director
    public Movie(string title, string director) : this()
    {
        Title = title;
        Director = director;
    }

    // Constructor with title, director, and release year
    public Movie(string title, string director, int releaseYear) : this(title, director)
    {
        ReleaseYear = releaseYear;
    }

    // Constructor with title, director, release year, and rating
    public Movie(string title, string director, int releaseYear, decimal rating) : this(title, director, releaseYear)
    {
        Rating = rating;
    }

    // Method to display movie details with default format
    public void DisplayDetails()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Director: " + Director);
        Console.WriteLine("Release Year: " + ReleaseYear);
        Console.WriteLine("Rating: " + Rating + "/10");
    }

    // Overloaded method to display movie details with a custom format
    public void DisplayDetails(string format)
    {
        if (format == "short")
        {
            Console.WriteLine($"{Title} directed by {Director}");
        }
        else if (format == "full")
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Director: " + Director);
            Console.WriteLine("Release Year: " + ReleaseYear);
            Console.WriteLine("Rating: " + Rating + "/10");
        }
        else
        {
            Console.WriteLine("Invalid format. Please use 'short' or 'full'.");
        }
    }

    // Main method to test the class
    static void Main()
    {
        Movie movie1 = new Movie();
        Movie movie2 = new Movie("Inception", "Christopher Nolan");
        Movie movie3 = new Movie("The Godfather", "Francis Ford Coppola", 1972);
        Movie movie4 = new Movie("Pulp Fiction", "Quentin Tarantino", 1994, 8.9m);

        Console.WriteLine("Default Display:");
        movie1.DisplayDetails();
        Console.WriteLine();
        movie2.DisplayDetails();
        Console.WriteLine();
        movie3.DisplayDetails();
        Console.WriteLine();
        movie4.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Short Format Display:");
        movie1.DisplayDetails("short");
        Console.WriteLine();
        movie2.DisplayDetails("short");
        Console.WriteLine();
        movie3.DisplayDetails("short");
        Console.WriteLine();
        movie4.DisplayDetails("short");
        Console.WriteLine();

        Console.WriteLine("Full Format Display:");
        movie1.DisplayDetails("full");
        Console.WriteLine();
        movie2.DisplayDetails("full");
        Console.WriteLine();
        movie3.DisplayDetails("full");
        Console.WriteLine();
        movie4.DisplayDetails("full");
    }
}
