/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
    //enum Level{High,Medium,Low}
    static void Main() {
    Console.WriteLine("Hello World");
    Console.WriteLine("Enter your string input: ");
    string word = Console.ReadLine();
    int length = 0;
    foreach (char c in word){
        length+=1;
    }
    
    Console.WriteLine("Length of the given string is: "+length);

    
  }
}