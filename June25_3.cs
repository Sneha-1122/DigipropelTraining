/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {

    int num1, num2, num3, num4, result;
    
    Console.WriteLine("Please enter your input: ");
    string[] tokens = Console.ReadLine().Split();

    //Parse element 0
    
    int a = int.Parse(tokens[0]);
    
    //Parse element 1
    
    int b = int.Parse(tokens[1]);
    
    int c = int.Parse(tokens[2]);
    
    int d = int.Parse(tokens[3]);
    
    result = (a+b+c+d)/4;
    
    Console.WriteLine("The average of the given input is: "+result);
  }
}