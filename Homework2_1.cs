namespace HomeWork2_1;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please input a letter grade:");
        string gradeLetter = Console.ReadLine();// take input from user
        char letterGrade = Convert.ToChar(gradeLetter); //change string to character variable

        int gpa;// define gpa variable

        if (letterGrade == 'A')
        {
            gpa = 4;
        }
        else if (letterGrade == 'B')
        {
            gpa = 3;
        }
        else if (letterGrade == 'C')
        {
            gpa = 2;
        }
        else if (letterGrade == 'D')
        {
            gpa = 1;
        }
        else if (letterGrade == 'F')
        {
            gpa = 0;
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");// print the error
            return; // Exit the program if the letter grade is invalid
        }

        Console.WriteLine($"GPA Point: {gpa}");//print the gpa
    }
}
