namespace HomeWork4_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number (a):");
        int a = Convert.ToInt32(Console.ReadLine());// takes first integer from user

        Console.WriteLine("Enter the second number (b):");
        int b = Convert.ToInt32(Console.ReadLine()); //takes second integer from user
        Console.WriteLine($"a:{a}; b:{b}");
        
        int largestNumber = Islargest(a, b); //calls the function Islargest
        Console.WriteLine("The largest number is: " + largestNumber); //prints out the result
    }



    public static int Islargest(int num1, int num2)
    {
        return num1 > num2 ? num1 : num2;//ternary operator to compare number
    }
}
