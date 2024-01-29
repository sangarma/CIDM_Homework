namespace HomeWork2_3;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Please input a year: ");
        int year = Convert.ToInt16(Console.ReadLine());//take input and change to integer

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))//condition for leap year
        {
            Console.WriteLine($"{year} is a Leap Year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a Leap Year.");
        }
    }
}
