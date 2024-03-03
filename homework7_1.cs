namespace HomeWork7;

class Program
{
    static void Main()
    {
        // Creating 2 new professors and setting the salary
        Professor Prof1 = new Professor("Alice", "Java");
        Prof1.SetSalary(9000);

        Professor Prof2 = new Professor("Bob", "Math");
        Prof2.SetSalary(8000);

        // Creating 2 new students and setting the grades
        Student Student1 = new Student("Lisa", "Java");
        Student1.SetGrade(90);

        Student Student2 = new Student("Tom", "Math");
        Student2.SetGrade(80);

        double SalaryDiff = Math.Abs(Prof1.GetSalary()-Prof2.GetSalary());
        double SumGrade = Student1.GetGrade()+Student2.GetGrade();


        // Displaying the details
        Console.WriteLine($"Professor {Prof1.ProfName} teaches {Prof1.ClassTeach}, and the salary is: {Prof1.GetSalary()}.");
        Console.WriteLine($"Professor {Prof2.ProfName} teaches {Prof2.ClassTeach} and the salary is: {Prof2.GetSalary()}.");
        Console.WriteLine($"Student {Student1.StudentName} enrolls {Student1.ClassEnroll} and the grade is: {Student1.GetGrade()}.");
        Console.WriteLine($"Student {Student2.StudentName} enrolls {Student2.ClassEnroll} and the grade is: {Student2.GetGrade()}.");
        Console.WriteLine($"The salary difference between {Prof1.ProfName} and {Prof2.ProfName} is: {SalaryDiff}.");
        Console.WriteLine($"The total grade of {Student1.StudentName} and {Student2.StudentName} is: {SumGrade}.");
    }
}

public class Professor
{
    public string ProfName;
    public string ClassTeach;
    private double salary;

    public Professor(string profName, string classTeach)
    {
        ProfName = profName;
        ClassTeach = classTeach;
    }

    public void SetSalary(double salaryAmount)
    {
        salary = salaryAmount;
    }

    public double GetSalary()
    {
        return salary;
    }
}

public class Student
{
    public string StudentName;
    public string ClassEnroll;
    private double studentGrade;

    public Student(string studentName, string classEnroll)
    {
        StudentName = studentName;
        ClassEnroll = classEnroll;
    }

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }
}