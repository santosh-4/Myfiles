using System.IO;
using System;

class Program
{
    static void Main()
    {
      int[,] arr= new int[2,2];
     Console.WriteLine("Enter the elements");
      for(int row=0;row < arr.GetLength(0);row++)
      { 

        for (int col=0;col < arr.GetLength(1);col++)
         {
          arr[row,col]=Convert.ToInt32(Console.ReadLine());
         }
      }
        for (int row=0;row < arr.GetLength(0);row++)
         {
           for (int col=0;col < arr.GetLength(1);col++)
           {
            Console.Write(arr[col,row]+ "\t");
            }
          Console.Write("\n");
         }
    }
}