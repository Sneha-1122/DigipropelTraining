/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    // Program to multiply three numbers
    Console.WriteLine("Hello World");
   
    // Declaring variables
    int num1, num2, num3,result;
    Console.Write("Enter your first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter your second number: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter your third number: ");
    num3 = Convert.ToInt32(Console.ReadLine());
    result = num1*num2*num3;
    Console.WriteLine("Your result is: "+ result);
  }
}

/* 
INPUT:
Enter your first number: 3
Enter your second number: 6
Enter your third number: 8

OUTPUT:
Your result is: 144
*/
