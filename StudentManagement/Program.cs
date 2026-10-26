using System;
using System.Collections.Generic;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Now using List<Student> instead of List<string>!
            List<Student> students = new List<Student>();
            bool running = true;

            Console.WriteLine("=========================================");
            Console.WriteLine("   Welcome to Student Management System  ");
            Console.WriteLine("=========================================");

            while (running)
            {
                Console.WriteLine("\nPlease choose an option:");
                Console.WriteLine("1. View All Students");
                Console.WriteLine("2. Add a New Student");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayStudents(students);
                        break;
                    case "2":
                        AddStudent(students);
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("\nThank you for using Student Management System. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please enter 1, 2, or 3.");
                        break;
                }
            }
        }

        static void DisplayStudents(List<Student> students)
        {
            Console.WriteLine("\n--- Student List ---");
            if (students.Count == 0)
            {
                Console.WriteLine("No students found in the system yet.");
            }
            else
            {
                foreach (var student in students)
                {
                    student.DisplayInfo();
                }
            }
        }

        static void AddStudent(List<Student> students)
        {
            Console.Write("\nEnter Student ID (number): ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID. Please enter a number.");
                return;
            }

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Invalid age. Please enter a number.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(name))
            {
                Student newStudent = new Student(id, name.Trim(), age);
                students.Add(newStudent);
                Console.WriteLine($"Successfully added {name.Trim()}!");
            }
            else
            {
                Console.WriteLine("Student name cannot be empty.");
            }
        }
    }
}