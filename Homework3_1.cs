namespace HomeWork3_1;
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Input an integer:");
        int num = Convert.ToInt32(Console.ReadLine());//take number from user


        if (num <= 1)
        {
            Console.WriteLine($"{num} is non-prime.");// number less than 2 are not prime
        }
        else if(num == 2)// 2 is a prime number
        {
            Console.WriteLine($"{num} is prime.");
        }
        {
            for (int i = 2; i <= (num-1); i++)// run for loop for the integer-1
        {
            if (num % i == 0)
            {

                Console.WriteLine($"{num} is non-prime.");
                break; //break loop when th number is non prime
            }

            if (i == num-1)
            {
                Console.WriteLine($"{num} is prime.");
            }   
        }
        }

           
    }

}


