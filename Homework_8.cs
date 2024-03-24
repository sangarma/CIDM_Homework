using System;
class Program
{
    //*** Do NOT change the code in Main ***
    public static void Main (string[] args) {
        // Test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);


        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        // Test Q2.1
        PrintAllOddNumber(array_2d);


        // Test Q2.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");


        // Test Q2.3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
                Console.Write(num +" ");
        }
    }
    // **Compete the following methods, then run the program to check outputs**
    // Q1: calculate the sum of elements in a given int_array (4 points)

    public static void ArraySum(int[] int_array){
        //put your answer below
        int sum = 0; //initialize sum variable
        foreach (int num in int_array)
        {
            sum += num; //add each elements to the sum
        }
        Console.WriteLine($"The Sum of int_array is: {sum}");


    }


    //Q2.1: given a 2d array, print all the odd elements (2 points)
    public static void PrintAllOddNumber(int[ , ] arr){
        //put your answer below
        foreach (int num in arr)
        {
            if (num % 2 != 0) //check if the number is odd
            {
                Console.Write(num + " ");
            }
        }
    }
       
    
    //Q2.2: given a 2d array, return the sum of all elements (2 points)
    public static int ElementSum(int[ , ] arr){
        //put your answer below

        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum;
    }


    // Q2.3: given a 2d array, double its element values and return it (2 points)
    public static int[ , ] DoubleArray(int[ , ] arr){
         //put your answer below
    	int[,] doubledArray = new int[arr.GetLength(0), arr.GetLength(1)];//create new array with same length and dimension
        for (int i = 0; i < arr.GetLength(0); i++) //track row number
        {
            for (int j = 0; j < arr.GetLength(1); j++)// track column number
            {
                doubledArray[i, j] = arr[i, j] * 2;// double each elements
            }
        }
        return doubledArray;
       
    }  
}
