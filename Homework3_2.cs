namespace HomeWork3_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt16(Console.ReadLine());//Take input from user

        for (int i = 1; i<= num; i++)//First for loop for rows
        {
            for(int j = 1; j <= num; j++)// for columns
            {

                Console.Write("#");
            }

            Console.Write("\n");
        }
    }
}
