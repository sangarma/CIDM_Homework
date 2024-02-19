namespace HomeWork5_3;

class Program
{
    static void Main(string[] args)
    {
    
        createAccount();
        
    }


    static bool checkAge(int birth_year)
    {
        // calculate the age based on the birth_year (age = current_year - birth_year)
        int current_year = 2024;
        int age = current_year - birth_year;
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    static void createAccount(){
        Console.WriteLine("Enter Your Username");// ask user to input username
        string? uname = Convert.ToString(Console.ReadLine());//? removes null literal warning

        Console.WriteLine("Enter Your Password");// ask user to input password
        string? password1 = Console.ReadLine();

        Console.WriteLine("Enter Your Password Again");// ask user to input password again
        string? password2 = Console.ReadLine();

        Console.WriteLine("Enter Your Birthyear");// ask user to input birthyear
        int birth_year = Convert.ToInt16(Console.ReadLine());

        if (checkAge(birth_year) == true)//if checkAge(birthyear) returns true
        {
            if (password1 == password2)//check if two passwords are same
            {
                
                Console.WriteLine("Account is created successfully");//if passwords are same, print “Account is created successfully
            }
            else
            {
                Console.WriteLine("Wrong password");// error if passwords donot match
            }
            
        
        }
        else 
        {
            Console.WriteLine("Could not create an account");// else print "Wrong password"
        }

    }
}
