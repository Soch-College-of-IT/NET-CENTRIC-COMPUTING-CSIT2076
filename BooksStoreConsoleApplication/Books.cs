using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApplication
{
    public class Books
    {
        private int isbn;
        private string name;
        private string author;
        private string publisher;
        private int[] publishedYears;

        // Default constructor
        public Books() {}

        // Parameterized constructor
        public Books(int isbn, string name, string author, string publisher, int[] publishedYears)
        {
            this.isbn = isbn;
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.publishedYears = publishedYears;
        }

        // Properties (getters and setters)
        public int ISBN
        {
            set { isbn = value; }
            get { return isbn; }
        }

        // Properties (getters and setters)
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Properties (getters and setters)
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        // Properties (getters and setters)
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        // Properties (getters and setters)
        public int[] PublishedYears
        {
            get { return publishedYears; }
            set { publishedYears = value; }
        }

        // Method to print the values
        public void printBooksDetails()
        {
            Console.WriteLine("ISBN : {0}", isbn);
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Author : {0}\nPublisher: {1}", author, publisher);
            Console.Write("Published Years: ");
            foreach (int publishedYear in publishedYears)
            {
                Console.Write($"{publishedYear}, ");
            }
            //Console.WriteLine("Published Years: {0}", publishedYears);
        }
    }
}
