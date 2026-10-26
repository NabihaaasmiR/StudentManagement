namespace StudentManagement
{
    public class Student
    {
        // Properties of a student
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor to easily create a new student
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        // A helper method to display student info nicely
        public void DisplayInfo()
        {
            System.Console.WriteLine($"ID: {Id} | Name: {Name} | Age: {Age}");
        }
    }
}