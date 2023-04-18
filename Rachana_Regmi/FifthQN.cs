using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Semester { get; set; }
    public string SymbolNo { get; set; }
    public string Address { get; set; }
}

class StudentManagementSystem
{
    static List<Student> students = new List<Student>();

    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add a student");
            Console.WriteLine("2. Search for a student");
            Console.WriteLine("3. List all students");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    SearchStudent();
                    break;
                case "3":
                    ListStudents();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.WriteLine("Enter student name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter student age:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter student semester:");
        string semester = Console.ReadLine();

        Console.WriteLine("Enter student symbol no:");
        string symbolNo = Console.ReadLine();

        Console.WriteLine("Enter student address:");
        string address = Console.ReadLine();

        Student student = new Student();
        student.Name = name;
        student.Age = age;
        student.Semester = semester;
        student.SymbolNo = symbolNo;
        student.Address = address;

        students.Add(student);

        Console.WriteLine("Student added successfully!");
    }

    static void SearchStudent()
    {
        Console.WriteLine("Enter student symbol no to search for:");
        string symbolNo = Console.ReadLine();

        Student student = students.Find(s => s.SymbolNo == symbolNo);

        if (student == null)
        {
            Console.WriteLine("Student not found.");
        }
        else
        {
            Console.WriteLine("Student found:");
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Age: " + student.Age);
            Console.WriteLine(": " + student.Semester);
            Console.WriteLine("Symbol No: " + student.SymbolNo);
            Console.WriteLine("Address: " + student.Address);
        }
    }

    static void ListStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
        }
        else
        {
            Console.WriteLine("List of all students:");

            foreach (Student student in students)
            {
                Console.WriteLine("Name: " + student.Name);
                Console.WriteLine("Age: " + student.Age);
                Console.WriteLine("Semester: " + student.Semester);
                Console.WriteLine("Symbol No: " + student.SymbolNo);
                Console.WriteLine("Address: " + student.Address);
                Console.WriteLine("--------------------");
            }
        }
    }
}