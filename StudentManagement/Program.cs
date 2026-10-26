using System;
using System.Collections.Generic;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // A simple list to store student names in memory for now
            List<string> students = new List<string>();
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

        static void DisplayStudents(List<string> students)
        {
            Console.WriteLine("\n--- Student List ---");
            if (students.Count == 0)
            {
                Console.WriteLine("No students found in the system yet.");
            }
            else
            {
                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {students[i]}");
                }
            }
        }

        static void AddStudent(List<string> students)
        {
            Console.Write("\nEnter the name of the student: ");
            string name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name))
            {
                students.Add(name.Trim());
                Console.WriteLine($"Successfully added {name.Trim()}!");
            }
            else
            {
                Console.WriteLine("Student name cannot be empty.");
            }
        }
    }
}