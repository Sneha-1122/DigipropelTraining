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
    //Program to check if the year is a leap year or not.
    Console.WriteLine("Program to check if the year is a leap year or not");
    Console.WriteLine("Please enter the year: ");
    int year = Convert.ToInt32(Console.ReadLine());
    
    if ((year%400) == 0) {
        Console.WriteLine("{0} is a leap year",year);
    }
    else if((year%100) == 0) {
        Console.WriteLine("{0} is not a leap year", year);
    }
     else if((year%4) == 0) {
         Console.WriteLine("{0} is a leap year", year);
     }
     else {
         Console.WriteLine("{0} is not a leap year", year);
         
     }
  }
}