using System;
using System.Collections.Generic;

public class Student {
    public string Name { get; set; }
    public int Age { get; set; }
    public string GradeLevel { get; set; }

    public Student(string name, int age, string gradeLevel) {
        Name = name;
        Age = age;
        GradeLevel = gradeLevel;
    }

    public void Display() {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Grade Level: " + GradeLevel);
    }
}

class Program {
    static void Main(string[] args) {
        List<Student> students = new List<Student>();

        while (true) {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Enter grade level: ");
                    string gradeLevel = Console.ReadLine();
                    Student student = new Student(name, age, gradeLevel);
                    students.Add(student);
                    Console.WriteLine("Student added successfully!");
                    break;
                case "2":
                    if (students.Count == 0) {
                        Console.WriteLine("No students added yet!");
                    } else {
                        Console.WriteLine("Student List:");
                        foreach (Student s in students) {
                            s.Display();
                            Console.WriteLine();
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine();
        }
    }
}




/*

Explanation:

The Student class has three attributes, Name, Age, and GradeLevel, which are all represented as properties.
The Student class has a constructor that takes three parameters to initialize the attributes.
The Display method displays the student's information on the console.
The Program class is the main class that contains the Main method.
The Main method creates a list of Student objects to store the students' information.
The while loop displays a menu of options and prompts the user for their choice until the user chooses to exit.
The switch statement handles the user's input and executes the corresponding functionality.
When the user chooses to add a student, the console prompts the user for the student's information and adds the student to the list.
When the user chooses to display all students, the console displays the information of all students stored in the list.
When the user chooses to exit, the console displays a goodbye message and exits the program.



*/