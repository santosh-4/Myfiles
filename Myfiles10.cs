using System.IO;
using System;

class Program
{
    static void Main()
    {
        
        //Declaring VaRiables
        int FirstNum, SecondNum, Result;
        Console.WriteLine("Enter the First Number");
        FirstNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("firstNumber"+FirstNum);
        
        Console.WriteLine("Enter the Second NUmber");
        SecondNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("secondNumber"+SecondNum);
        Result = FirstNum+SecondNum;
      
        Console.WriteLine("result"+Result);

     }
}