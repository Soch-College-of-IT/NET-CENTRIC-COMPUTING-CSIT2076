// student information system
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create a list to store students
        List<Student> students = new List<Student>();

        while (true)
        {
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. List all students");
            Console.WriteLine("3. Search student");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent(students);
                    break;
                case 2:
                    ListStudents(students);
                    break;
                case 3:
                    SearchStudent(students);
                    break;
                case 4:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please enter a valid choice.");
                    break;
            }

            Console.WriteLine(); // print an empty line for readability
        }
    }

    static void AddStudent(List<Student> students)
    {
        Console.WriteLine("Enter student information:");

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Address: ");
        string address = Console.ReadLine();

        Console.Write("Phone number: ");
        string phone = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        // create a new student object
        Student student = new Student(name, age, address, phone, email);

        // add the student to the list
        students.Add(student);

        Console.WriteLine("Student added successfully!");
    }

    static void ListStudents(List<Student> students)
    {
        Console.WriteLine("List of all students:");
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }

    static void SearchStudent(List<Student> students)
    {
        Console.Write("Enter student name to search: ");
        string name = Console.ReadLine();

        // search for the student with the given name
        Student student = students.Find(s => s.Name == name);

        if (student == null)
        {
            Console.WriteLine("Student not found!");
        }
        else
        {
            Console.WriteLine(student);
        }
    }
}

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public Student(string name, int age, string address, string phone, string email)
    {
        Name = name;
        Age = age;
        Address = address;
        Phone = phone;
        Email = email;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Address: {Address}, Phone: {Phone}, Email: {Email}";
    }
}
