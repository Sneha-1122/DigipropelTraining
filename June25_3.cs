using System;
using System.IO;
public class Average
{
  public static void Main()
  {
    // Program to calculate the average of 4 numbers
    Console.WriteLine("Program to calculate the average of 4 numbers");
     int a,b,c,d, result;
      
     Console.Write("\n Enter the First number: ");
     a = Convert.ToInt32(Console.ReadLine());
 
     Console.Write("\n Enter the Second number: ");
     b = Convert.ToInt32(Console.ReadLine());
 
     Console.Write("\n Enter the third number: ");
     c = Convert.ToInt32(Console.ReadLine());
 
     Console.Write("\n Enter the fourth number: ");
     d = Convert.ToInt32(Console.ReadLine());
    
    // Calculating average
     result = (a + b + c + d) / 4;
     Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",a, b, c, d, result);
   }
}

/*
INPUT:
Enter the First number: 4

Enter the Second number: 7

Enter the third number: 2

Enter the fourth number: 9

OUTPUT:
The average of 4, 7, 2, 9 is: 5 
*/
