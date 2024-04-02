using System;
using System.Collections.Generic;


public class Student
{
    // Private fields

    public int studentID { get; set; }
    public string studentName { get; set; }

    // Public static studentList
    public static List<Student> studentList = new List<Student>();


    // Constructor with parameters
    public Student(int id, string name)
    {
        this.studentID = id;
        this.studentName = name;
        // Add this student object to the studentList
        studentList.Add(this);
    }

    // Method to print student ID and name
    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Create students with the specified information
        Student student1 = new Student(111, "Alice");
        Student student2 = new Student(222, "Bob");
        Student student3 = new Student(333, "Cathy");
        Student student4 = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();

        // add the gradebook dictionery
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if (gradebook.ContainsKey("Tom") == false)
        {
            gradebook.Add("Tom",3.3);
        }

        double totalGPA = 0;
        foreach (var stu in gradebook)
        {
            totalGPA += stu.Value;
        }
        //calculate average GPA
        double averageGPA = totalGPA / gradebook.Count;
        Console.WriteLine($"The average GPA is: {averageGPA:F2}");

        foreach (Student stu in Student.studentList)
        {
            
            if (gradebook[stu.studentName] >= averageGPA)// print information if studetGPA > averageGPA
            {
                stu.PrintInfo();
            }
            
        }

    }
}
