namespace HomeWork5_2;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number (a):");
        int a = getInput();// takes first integer from user
        Console.WriteLine("Enter the second number (b):");    
        int b = getInput();//takes second integer from user
        Console.WriteLine("Enter the third number (c):");
        int c = getInput();//takes third integer from user
        Console.WriteLine("Enter the fourth number (d):");
        int d = getInput();//takes fourth integer from user

        Console.WriteLine($"a:{a}; b:{b}; c:{c}; d:{d};");

        
        int max1 = Islargest(a, b); //largest among a and b
        int max2 = Islargest(c,d); //largest among b and c
        int max = Islargest(max1,max2); //largest integer
        Console.WriteLine("The largest number is: " + max); //prints out the result
    }



    public static int getInput()//Method to take input from keyboard
    {
        return Convert.ToInt32(Console.ReadLine());
    }
    
    public static int Islargest(int num1, int num2)//Method to compare largest number
    {
        return num1 > num2 ? num1 : num2;//ternary operator to compare number
    }
}

