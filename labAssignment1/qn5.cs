
// Question 5 Console 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
        class Program
        {
            static void Main(string[] args)
            {
                List<Student> students = new List<Student>();
                List<Teacher> teachers = new List<Teacher>();

                Console.WriteLine("Welcome to School Management System!");

                bool isRunning = true;

                while (isRunning)
                {
                    Console.WriteLine("Please select an option:");
                    Console.WriteLine("1. Add student");
                    Console.WriteLine("2. Add teacher");
                    Console.WriteLine("3. View all students");
                    Console.WriteLine("4. View all teachers");
                    Console.WriteLine("5. Exit");

                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter student name:");
                            string studentName = Console.ReadLine();
                            Console.WriteLine("Enter student ID:");
                            int studentID = int.Parse(Console.ReadLine());
                            Student student = new Student(studentName, studentID);
                            students.Add(student);
                            Console.WriteLine("Student added successfully!");
                            break;
                        case 2:
                            Console.WriteLine("Enter teacher name:");
                            string teacherName = Console.ReadLine();
                            Console.WriteLine("Enter teacher ID:");
                            int teacherID = int.Parse(Console.ReadLine());
                            Teacher teacher = new Teacher(teacherName, teacherID);
                            teachers.Add(teacher);
                            Console.WriteLine("Teacher added successfully!");
                            break;
                        case 3:
                            Console.WriteLine("All students:");
                            foreach (Student s in students)
                            {
                                Console.WriteLine(s.Name + " - " + s.ID);
                            }
                            break;
                        case 4:
                            Console.WriteLine("All teachers:");
                            foreach (Teacher t in teachers)
                            {
                                Console.WriteLine(t.Name + " - " + t.ID);
                            }
                            break;
                        case 5:
                            Console.WriteLine("Exiting School Management System...");
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option, please try again.");
                            break;
                    }
                }
            }
        }

        class Student
        {
            public string Name { get; set; }
            public int ID { get; set; }

            public Student(string name, int id)
            {
                Name = name;
                ID = id;
            }
        }

        class Teacher
        {
            public string Name { get; set; }
            public int ID { get; set; }

            public Teacher(string name, int id)
            {
                Name = name;
                ID = id;
            }
        }
    

}
