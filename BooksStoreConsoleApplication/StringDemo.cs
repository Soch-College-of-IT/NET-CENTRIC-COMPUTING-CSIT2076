using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksStoreConsoleApplication
{
    internal class StringDemo
    {
        public void StringDemonstration()
        {
            // Lets declare a string
            string name = "John Doe";
            Console.WriteLine("Name: {0}", name);
            
            // Lets declare a string array
            string[] names = new string[] { "John Doe", "Jane Doe", "Mary Doe" };
            Console.WriteLine("\nNames: ");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
            
            // Lets declare a string builder
            StringBuilder sb = new StringBuilder();
            sb.Append("John Doe");
            sb.Append("Jane Doe");
            sb.Append("Mary Doe");
            Console.WriteLine("\nNames: ");
            Console.WriteLine(sb.ToString());

            string name1 = "John Doe";
            string name2 = "Alice Hansen";

            int result = String.Compare(name1, name2);
            if (result == 0)
            {
                Console.WriteLine($"Both '{name1}' and '{name2}' are same.");
            } else if (result < 0)
            {
                Console.WriteLine($"Alphabetically '{name1}' comes first than '{name2}'");
            } else
            {
                Console.WriteLine("Alphabetically '{0}' comes first than '{1}'", name2, name1);
            }
        }
    }
}
