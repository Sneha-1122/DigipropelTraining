using System;
class ValueCheck {
  
  static void Main() {
    
    // Program to return true if one integer is positive and the other is negative
    Console.WriteLine("Program to return true if one integer is positive and the other is negative");
    Console.WriteLine("\nInput first integer:");  
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input second integer:");  
    int y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Check if one is negative and one is positive:");
    
    // Condition to return true if one integer is negative and one integer is positive
    Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
  }
}

/*
INPUT 1:
Input first integer:
-4
Input second integer:
0

OUTPUT 1:
Check if one is negative and one is positive:
False

INPUT 2:
Input first integer:
3
Input second integer:
-2

OUTPUT 2:
Check if one is negative and one is positive:
True
*/
