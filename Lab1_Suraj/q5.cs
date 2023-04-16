using System;
using System.Text.RegularExpressions;

namespace StudentInformationSystem
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public string Section { get; set; }

        public Student(string name, int age, string address, string contactNumber, string email, string course, string section)
        {
            Name = name;
            Age = age;
            Address = address;
            ContactNumber = contactNumber;
            Email = email;
            Course = course;
            Section = section;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("\nStudent Information:");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine("Contact Number: {0}", ContactNumber);
            Console.WriteLine("Email: {0}", Email);
            Console.WriteLine("Course: {0}", Course);
            Console.WriteLine("Section: {0}", Section);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Information System");
            string name = "";
            string address = "";
            string contactNumber = "";
            string email = "";
            string course = "";
            // string section = "";
            int age = 0;
            
            String section = "";
// Scanner scanner = new Scanner(System.in);

            while (true)
            {
                
                Console.WriteLine("\nPress :\n1----> to Enter new data \n2----> to view previous data \n3----> to exit:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
case 1:

Console.WriteLine("Enter Student name:");
do
{
    name = Console.ReadLine();
    if (name.All(Char.IsLetter))
    {
        break;
    }
    Console.WriteLine("Invalid input. Please enter a valid Name:");
} while (true);


    Console.WriteLine("Enter Student age:");
    while (!int.TryParse(Console.ReadLine(), out age) || age < 18 || age > 120)
    {
        Console.WriteLine("Invalid age. Please enter a valid age (18-120):");
    }

   Console.WriteLine("Enter Student address:");
address = Console.ReadLine();

while (!Regex.IsMatch(address, @"^[a-zA-Z0-9\s,'-]*$"))
{
    Console.WriteLine("Invalid address. Please enter a valid address:");
    address = Console.ReadLine();
}

    Console.WriteLine("Enter Student contact number:");
    contactNumber = Console.ReadLine();
    while (!Regex.IsMatch(contactNumber, @"^\d{10}$"))
    {
        Console.WriteLine("Invalid Phone number. Please Enter a 10-digit Phone number:");
        contactNumber = Console.ReadLine();
    }

    Console.WriteLine("Enter Student email:");
    email = Console.ReadLine();
    while (!Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
    {
        Console.WriteLine("Invalid email address. Please enter a valid email address:");
        email = Console.ReadLine();
    }

    Console.WriteLine("Enter Student course (options: Csit, it, engineering):");
    course = Console.ReadLine();
    while (course != "csit" && course != "it" && course != "engineering")
    {
        Console.WriteLine("Invalid course. Please enter a valid course (Csit, it, engineering):");
        course = Console.ReadLine();
    }

    Console.WriteLine("Enter student section (options: A, B, C):");
    section = Console.ReadLine();
    // response.ToUpper() == "Y"
    while (section != "A" && section != "B" && section != "C")
{
    Console.WriteLine("Invalid section. Please enter a valid section (A, B, C):");
    section = Console.ReadLine().ToUpper();
}

    Student student = new Student(name, age, address, contactNumber, email, course, section);
    student.DisplayInfo();
    break;


                    case 2:
                        if (name == "" && address == "" && contactNumber == "" && email == "" && course == "" && section == "")
                        {
                            Console.WriteLine("No previous data found.");
                        }
                        else
                        {
                            Student previousData = new Student(name, age, address, contactNumber, email, course, section);
                            previousData.DisplayInfo();
                        }
                        break;


                    case 3:
                        Console.WriteLine("Exiting program...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }
    }
}
               
