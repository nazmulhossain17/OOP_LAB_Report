using System;

public class Novel
{
    public string Name { get; set; }
    public string Writer { get; set; }
    public long Identifier { get; set; } // ISBN
    public decimal Cost { get; set; } // Price

    // Default constructor
    public Novel()
    {
        Name = "Untitled";
        Writer = "Unknown Author";
        Identifier = 0;
        Cost = 0.0m;
    }

    // Constructor with title and author
    public Novel(string title, string author) : this()
    {
        Name = title;
        Writer = author;
    }

    // Constructor with title, author, and ISBN
    public Novel(string title, string author, long isbn) : this(title, author)
    {
        Identifier = isbn;
    }

    // Constructor with title, author, ISBN, and price
    public Novel(string title, string author, long isbn, decimal price) : this(title, author, isbn)
    {
        Cost = price;
    }

    // Method to print book details
    public void DisplayDetails()
    {
        Console.WriteLine("Title: " + Name);
        Console.WriteLine("Author: " + Writer);
        Console.WriteLine("ISBN: " + Identifier);
        Console.WriteLine("Price: $" + Cost);
    }

    // Main method to test the class
    static void Main()
    {
        Novel novel1 = new Novel();
        Novel novel2 = new Novel("The Hobbit", "J.R.R. Tolkien");
        Novel novel3 = new Novel("1984", "George Orwell", 9780451524935);
        Novel novel4 = new Novel("To Kill a Mockingbird", "Harper Lee", 9780061120084, 14.99m);

        novel1.DisplayDetails();
        Console.WriteLine();
        novel2.DisplayDetails();
        Console.WriteLine();
        novel3.DisplayDetails();
        Console.WriteLine();
        novel4.DisplayDetails();
    }
}
