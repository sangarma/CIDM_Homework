namespace HomeWork2_2;

class Program
{
    static void Main(string[] args)
    {
       int num1, num2, num3;//initialize the variables
       Console.WriteLine("Please input the first num:");
       num1 = Convert.ToInt16(Console.ReadLine());//take input and convert to integer

       Console.WriteLine("Please input the second num:");
       num2 = Convert.ToInt16(Console.ReadLine());

       Console.WriteLine("Please input the third num:");
       num3 = Convert.ToInt16(Console.ReadLine());

       if(num1<num2){
        if(num1<num3){
            Console.WriteLine($"The smallest value is: {num1}");
        }
        else{//num3 <= num1
            Console.WriteLine($"The smallest value is: {num3}");
        }
       }
       else{//num2 <= num1
        if(num3<num2){
            Console.WriteLine($"The smallest value is: {num3}"); 
        }
        else{//num2 <= num3
            Console.WriteLine($"The smallest value is: {num2}"); 
        }
       }
       
    }
}
