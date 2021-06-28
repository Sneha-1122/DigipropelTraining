/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    Console.WriteLine("Please enter your input: ");
    int result;
    string[] tokens = Console.ReadLine().Split();

    //Parse element 0
    
    int a = int.Parse(tokens[0]);
    
    //Parse element 1
    
    int b = int.Parse(tokens[1]);
    
    if (a==b) {
        result = (a+b)*3;
        Console.WriteLine("Your result is: "+result);
    }
    else {
        result = a+b;
        Console.WriteLine("Sum of two unequal numbers: "+result);
    }
  }
}