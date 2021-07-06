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
    Console.WriteLine("Program to accept two name and sort in alphabetical order");
    var names = new List<string>();
    string name1, name2;
    name1 = Console.ReadLine();
    Console.WriteLine("First name: "+name1);
    name2 = Console.ReadLine();
    Console.WriteLine("Second name: "+name2);
    names.Add(name1);
    names.Add(name2);
    names.Sort();
    
    Console.WriteLine("After sorting: ");
    foreach(char str in names){
        Console.WriteLine(str);
    }
  }
}