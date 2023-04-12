using System;
using System.Collections.Generic;

namespace StudentInformationSystem
{
    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            bool exit = false;
            Console.WriteLine("------Student Information System------");
            while (!exit)
            {    
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. View all students");
                Console.WriteLine("3. Search for a student");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ViewAllStudents();
                        break;
                    case 3:
                        SearchStudent();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.WriteLine();
            }
        }
        static void AddStudent()
        {
            Console.Write("Enter student name: ");
            string Name = Console.ReadLine();

            Console.Write("Enter student age: ");
            int Age = int.Parse(Console.ReadLine());

            Console.Write("Enter student gender (M/F): ");
            char Gender = char.Parse(Console.ReadLine().ToUpper());
            
            Console.Write("Enter student address: ");
            string Address = Console.ReadLine();

            Console.Write("Enter student faculty: ");
            string Faculty = Console.ReadLine();

            Console.Write("Enter student symbol number: ");
            int SymbolNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter student batch in year: ");
            int Batch = int.Parse(Console.ReadLine());

            students.Add(new Student(Name, Age, Gender, Address, Faculty, SymbolNumber, Batch));
            Console.WriteLine("Student added successfully");
        }




        static void ViewAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found");
                return;
            }

            Console.WriteLine("Student List:");
            Console.WriteLine("-------------");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        static void SearchStudent()
        {
            Console.Write("Enter student name to search: ");
            string searchName = Console.ReadLine();

            List<Student> matchingStudents = new List<Student>();
            foreach (Student student in students)
            {
                if (student.Name.ToLower() == searchName.ToLower())
                {
                    matchingStudents.Add(student);
                }
            }

            if (matchingStudents.Count == 0)
            {
                Console.WriteLine("No student found with name: " + searchName);
            }
            else
            {
                Console.WriteLine("Matching students:");
                Console.WriteLine("-----------------");
                foreach (Student student in matchingStudents)
                {
                    Console.WriteLine(student);
                }
            }
        }


        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public char Gender { get; set; }
            public string Address { get; set; }
            public string Faculty { get; set; }
            public int SymbolNumber { get; set; }
            public int Batch { get; set; }


            public Student(string name, int age, char gender, string address, string faculty, int symbolNumber, int batch)
            {

                Name = name;
                Age = age;
                Gender = gender;
                Address = address;
                Faculty = faculty;
                SymbolNumber = symbolNumber;
                Batch = batch;
            }

            /* public override string ToString()
             {
                 return "Name: " + Name + ", Age: " + Age + ", Gender: " + Gender + ", Address: " + Address + ", Faculty: " + Faculty + "SymbolNumber: " + SymbolNumber + ", Batch: " + Batch;
             }*/
            public override string ToString()
            {
                // Set the column widths for each property
                const int nameWidth = 20;
                const int ageWidth = 5;
                const int genderWidth = 8;
                const int addressWidth = 25;
                const int facultyWidth = 15;
                const int symbolNumberWidth = 15;
                const int batchWidth = 10;

                // Use string.Format to format the output as a table
                return string.Format("{0,-" + nameWidth + "} {1,-" + ageWidth + "} {2,-" + genderWidth + "} {3,-" + addressWidth + "} {4,-" + facultyWidth + "} {5,-" + symbolNumberWidth + "} {6,-" + batchWidth + "}\n",
                    "Name", "Age", "Gender", "Address", "Faculty", "Symbol Number", "Batch") +
                    string.Format("{0,-" + nameWidth + "} {1,-" + ageWidth + "} {2,-" + genderWidth + "} {3,-" + addressWidth + "} {4,-" + facultyWidth + "} {5,-" + symbolNumberWidth + "} {6,-" + batchWidth + "}\n",
                    Name, Age, Gender, Address, Faculty, SymbolNumber, Batch);
            }

        }
    }
}
