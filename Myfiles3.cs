using System.IO;
using System;

class Program
{
    static void Main()
    {
     int z;
            Console.Write("enter the age of the person");
        z= Convert.ToInt32(Console.ReadLine());
        if(z<18)
        {
              Console.WriteLine("\n not eligible to vote");
        }
        else if (z>=60)
        {
           Console.WriteLine("\n  is a senior citizen"); 
        }
        else
        {
            Console.WriteLine("\n eligible to vote");
        }
    }
}