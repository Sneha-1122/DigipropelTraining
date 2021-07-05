/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Hello World");
        Console.WriteLine("Program to find the position of a specific word in a string");
        Console.WriteLine("Please enter your string input: ");
        string str = "The quick brown fox jumps over the lazy dog";
      Console.WriteLine("Original string: " + str);
        Console.WriteLine("Position of the word 'fox' in the said string: " + posCheck(str, "quick"));
        Console.WriteLine("Position of the word 'The' in the said string: " + posCheck(str, "jumps"));
        Console.WriteLine("Position of the word 'lazy' in the said string: " + posCheck(str, "dog"));
    }
    public static int posCheck(string text, string word)
    {
        return Array.IndexOf(text.Split(' '), word) + 1;
    }
}
