namespace HomeWork3_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Assign an int value to N:");
        int N = Convert.ToInt16(Console.ReadLine());//take input from user

        for (int i = 1; i<= N; i++)//count the rows
        {
            int t = 1;
            while(t <= i)//make column and row equal
            {
                Console.Write("*");
                t += 1;
            }
            Console.Write("\n");//for newline
            }
    }
}
