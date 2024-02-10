namespace HomeWork4_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int N = Convert.ToInt32(Console.ReadLine());// takes integer from user

        Console.WriteLine("Enter the shape('right' or 'left'): ");
        string shape = Console.ReadLine(); //takes shape from user

        Console.WriteLine( $"N is: {N}; shape is: {shape}"); // print number and the shape

        Pattern(N, shape); //call method



    }

    public static void Pattern(int N, string shape) //method with no return value
        {
            
            if (shape == "left")
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else if (shape == "right")
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int j = N; j >= i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid shape. Please enter 'left' or 'right'.");// Show error if unsupported shape entered
            }
        }

}
