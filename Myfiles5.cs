using System.IO;
using System;

class Program
{
    static void Main()
    {
      int[] arr = new int[5];
      int sum=0;
      Console.WriteLine("enter the array numbers");
      for(int i=0;i<arr.Length;i++)
      {
          arr[i] = Convert.ToInt32
          (Console.ReadLine());
          sum=arr[i]+sum;
      }
      Console.WriteLine(sum);
      
      
    }
}