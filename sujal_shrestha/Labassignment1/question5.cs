using System;
using System.Collections.Generic;

namespace StudentInformationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.WriteLine("Enter 1 to add a student");
                Console.WriteLine("Enter 2 to view all students");
                Console.WriteLine("Enter 3 to search for a student");
                Console.WriteLine("Enter 4 to update a student's information");
                Console.WriteLine("Enter 5 to delete a student");
                Console.WriteLine("Enter 6 to exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(students);
                        break;
                    case "2":
                        ViewAllStudents(students);
                        break;
                    case "3":
                        SearchForStudent(students);
                        break;
                    case "4":
                        UpdateStudentInformation(students);
                        break;
                    case "5":
                        DeleteStudent(students);
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddStudent(List<Student> students)
        {
            Console.WriteLine("Enter the student's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the student's age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the student's email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter the student's address:");
            string address = Console.ReadLine();

            Student student = new Student(name, age, email, address);
            students.Add(student);

            Console.WriteLine("Student added successfully.");
        }

        static void ViewAllStudents(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("There are no students.");
            }
            else
            {
                foreach (Student student in students)
                {
                    Console.WriteLine("Name: " + student.Name);
                    Console.WriteLine("Age: " + student.Age);
                    Console.WriteLine("Email: " + student.Email);
                    Console.WriteLine("Address: " + student.Address);
                    Console.WriteLine();
                }
            }
        }

        static void SearchForStudent(List<Student> students)
        {
            Console.WriteLine("Enter the name of the student:");
            string name = Console.ReadLine();

            Student student = students.Find(s => s.Name == name);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
            }
            else
            {
                Console.WriteLine("Name: " + student.Name);
                Console.WriteLine("Age: " + student.Age);
                Console.WriteLine("Email: " + student.Email);
                Console.WriteLine("Address: " + student.Address);
            }
        }

        static void UpdateStudentInformation(List<Student> students)
        {
            Console.WriteLine("Enter the name of the student:");
            string name = Console.ReadLine();

            Student student = students.Find(s => s.Name == name);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
            }
            else
            {
