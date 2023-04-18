using System;
using System.Collections.Generic;

namespace BookInventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>();

            while (true)
            {
                Console.WriteLine("Book Inventory System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Display Books");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the title of the book: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter the author of the book: ");
                        string author = Console.ReadLine();

                        Console.Write("Enter the ISBN of the book: ");
                        string isbn = Console.ReadLine();

                        Console.Write("Enter the price of the book: ");
                        double price = double.Parse(Console.ReadLine());

                        var book = new Book(title, author, isbn, price);
                        books.Add(book);

                        Console.WriteLine("Book added successfully.");
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("Books in Inventory:");

                        foreach (var b in books)
                        {
                            Console.WriteLine(b);
                        }

                        Console.WriteLine();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }

    class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string ISBN { get; }
        public double Price { get; }

        public Book(string title, string author, string isbn, double price)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} (ISBN: {ISBN}, Price: ${Price})";
        }
    }
}
