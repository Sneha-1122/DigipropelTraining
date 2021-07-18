using System;
class IntegerCheck {
  
  static void Main() {
    
    // Program to compute the sum of two given integers, if two values are equal then return the triple of their sum
    Console.WriteLine("Program to compute the sum of two given integers, if two values are equal then return the triple of their sum");
    Console.WriteLine("\nPlease enter your input: ");
    int result;
    Console.Write("\nEnter the First number: ");

    // Reading inputs from console
    int a = Convert.ToInt32(Console.ReadLine());
 
     Console.Write("\nEnter the Second number: ");
    int b = Convert.ToInt32(Console.ReadLine());
    
    if (a==b) {
        result = (a+b)*3;
        Console.WriteLine("Triple the sum of two equal integers: "+result);
    }
    else {
        result = a+b;
        Console.WriteLine("Sum of two unequal integers: "+result);
    }
  }
}

/*
INPUT 1:
Please enter your input:

Enter the First number: 5

Enter the Second number: 4

OUTPUT 1:
Sum of two unequal numbers: 9

INTPUT 2:
Please enter your input:

Enter the First number: 5

Enter the Second number: 5

OUTPUT 2:
Triple the sum of two equal integers: 30
*/
