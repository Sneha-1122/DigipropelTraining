/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    
    // Program to add, subtract, multiply and divide two numbers
    int num1, num2, num3,result;
    Console.Write("Enter your first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter your second number: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    
    // Performing the operations
    result = num1+num2;
    Console.WriteLine("Adding 2 numbers: "+ result);
    result = num1-num2;
    Console.WriteLine("Subtracting 2 numbers: "+ result);
    result = num1*num2;
    Console.WriteLine("Multiplying 2 numbers: "+ result);
    result = num1/num2;
    Console.WriteLine("Dividing 2 numbers: "+ result);
  }
}

/*
INPUT: 
Enter your first number: 6
Enter your second number: 5

OUTPUT:
Adding 2 numbers: 11
Subtracting 2 numbers: 1
Multiplying 2 numbers: 30
Dividing 2 numbers: 1
*/
