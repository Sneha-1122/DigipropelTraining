/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
    enum Level{High,Medium,Low}
    static void Main() {
    Console.WriteLine("Hello World");
    Level complexity = Level.Medium;
    switch(complexity) 
    {
      case Level.Low:
      Console.WriteLine("Low level");
      break;
      case Level.Medium:
      Console.WriteLine("Medium level");
      break;
      case Level.High:
      Console.WriteLine("High level");
      break;
  }
  }
}