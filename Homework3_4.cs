namespace HomeWork3_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a positive integer:");
        int N = Convert.ToInt16(Console.ReadLine());//teke integer input from user
        
        for (int i = 1; i<= N; i++)
        {
            int t = N-i;
            while(t > 0)//keep track of whitespace
            {
                Console.Write(" ");
                t -= 1;
            }
            t= 0;
            while(t < i)//keep track of number at the end
            {
                Console.Write($"{i}");
                t++;
            }


            Console.Write("\n");
            }

            
        }
    }

