using System;
using System.Collections.Generic;

namespace BookInventorySystem
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }

        public Book(string title, string author, int quantity)
        {
            Title = title;
            Author = author;
            Quantity = quantity;
        }

        public void DisplayBookDetails()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Quantity: " + Quantity);
        }
    }

    class BookInventory
    {
        private List<Book> books = new List<Book>();

        public void AddBook(string title, string author, int quantity)
        {
            Book book = new Book(title, author, quantity);
            books.Add(book);
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("Book Inventory:");
            foreach (var book in books)
            {
                book.DisplayBookDetails();
                Console.WriteLine("-------------");
            }
        }

        public void SearchBook(string title)
        {
            bool bookFound = false;
            foreach (var book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    book.DisplayBookDetails();
                    bookFound = true;
                    break;
                }
            }
            if (!bookFound)
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void UpdateBookQuantity(string title, int quantity)
        {
            bool bookFound = false;
            foreach (var book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    book.Quantity = quantity;
                    bookFound = true;
                    Console.WriteLine("Book quantity updated successfully.");
                    break;
                }
            }
            if (!bookFound)
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void RemoveBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    books.RemoveAt(i);
                    Console.WriteLine("Book removed from inventory.");
                    break;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BookInventory bookInventory = new BookInventory();

            // Add some initial books to the inventory
            bookInventory.AddBook("Book 1", "Author 1", 5);
            bookInventory.AddBook("Book 2", "Author 2", 3);
            bookInventory.AddBook("Book 3", "Author 3", 2);

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Display all books");
                Console.WriteLine("2. Search book");
                Console.WriteLine("3. Update book quantity");
                Console.WriteLine("4. Remove book");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        bookInventory.DisplayAllBooks();
                        break;
                    case "2":
                        Console.WriteLine("Enter book title to search: ");
                        string titleToSearch = Console.ReadLine();
                        bookInventory.SearchBook(titleToSearch);
                        break;
                    case "3":
                        Console.WriteLine("Enter book title to update quantity: ");
                        string titleToUpdate = Console.ReadLine();
                        Console.WriteLine("Enter new quantity: ");
                        int newQuantity = Convert.ToInt32(Console.ReadLine());
                        bookInventory.UpdateBookQuantity(titleToUpdate, newQuantity);
                        break;
                    case "4":
                        Console.WriteLine("Enter book title to remove from inventory: ");
                        string titleToRemove = Console.ReadLine();
                        bookInventory.RemoveBook(titleToRemove);
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                     Console.WriteLine("Invalid choice. Please try again.");
                        break;
            }
        }
    }
  }
}