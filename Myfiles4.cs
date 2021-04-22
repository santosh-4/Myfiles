using System.IO;
using System;

class Program
{
    static void Main()
    {
      Console.WriteLine("enter a choice");
      
      int choice=Convert.ToInt32(Console.ReadLine());
      switch (choice)
      {
          case 1:
          Console.WriteLine("ADD");
          break;
          case 2:
          Console.WriteLine("SUB");
          break;
          case 3:
          Console.WriteLine("Mul");
          break;
           default:
          Console.WriteLine("Nothing");
          break;
      }
      
      
      
      
    }
}