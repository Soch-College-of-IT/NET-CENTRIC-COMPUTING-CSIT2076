using System;
using System.Collections.Generic;

namespace StudentInventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. View All Students");
                Console.WriteLine("4. View Students by Program");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Please enter the following student details:");
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Student ID: ");
                        string studentId = Console.ReadLine();
                        Console.Write("Program: ");
                        string program = Console.ReadLine();

                        students.Add(new Student(name, studentId, program));
                        Console.WriteLine("Student added successfully.");
                        break;

                    case "2":
                        Console.Write("Please enter the student ID of the student to remove: ");
                        string idToRemove = Console.ReadLine();
                        Student studentToRemove = students.Find(s => s.StudentId == idToRemove);

                        if (studentToRemove != null)
                        {
                            students.Remove(studentToRemove);
                            Console.WriteLine("Student removed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("List of Students:");
                        Console.WriteLine("==================");

                        foreach (Student student in students)
                        {
                            Console.WriteLine(student);
                        }
                        break;

                    case "4":
                        Console.Write("Please enter the program to view students: ");
                        string programToView = Console.ReadLine();
                        List<Student> studentsByProgram = students.FindAll(s => s.Program == programToView);

                        if (studentsByProgram.Count > 0)
                        {
                            Console.WriteLine($"List of Students in {programToView}:");
                            Console.WriteLine("===================================");

                            foreach (Student student in studentsByProgram)
                            {
                                Console.WriteLine(student);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No students found in that program.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string StudentId { get; set; }
        public string Program { get; set; }

        public Student(string name, string studentId, string program)
        {
            Name = name;
            StudentId = studentId;
            Program = program;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nStudent ID: {StudentId}\nProgram: {Program}\n";
        }
    }
}
