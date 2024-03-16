
using System;
class Program
{
    static void Main(string[] args)
    {
        // Creating two customers
        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);

        // Printing customer information
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        // Updating customer IDs
        customer1.ChangeID(220);
        customer2.ChangeID(221);

        // Printing updated information
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        // Comparing ages of two customers
        customer1.CompareAge(customer2);
    }
}

public class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;

    // Constructor to initiate values
    public Customer(int cus_id, string cus_name, int cus_age)
    {//assign id, name and age to the customer
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    // Method to change customer ID
    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    // Method to print customer information
    public void PrintCusInfo()
    {// method used to print customer information(id, name, age)
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");
    }

    // Method to compare age with another customer
    public void CompareAge(Customer objCustomer)
    {// method used to compare the current object’s age with the objCustomer’s age
        if (this.cus_age >= objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older");
        }
        else if (this.cus_age < objCustomer.cus_age)
        {
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }

    }
}


