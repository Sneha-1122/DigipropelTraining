/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Linq;
class HelloWorld
{
    //enum Level{High,Medium,Low}
    static void Main(string[] args)
    {
        Console.WriteLine("Program to reverse the string words with even length");
        string str = "C# is used to develop web apps , desktop apps , mobile apps , games and much more.";
        Console.WriteLine("Original string: " + str);
        Console.WriteLine("Reversed string: " + reverseMethod(str));
    }
    public static string reverseMethod(string text)
    {
        return string.Join(" ", text.Split(' ').Select(str => str.Length % 2 != 0 ? str : new String(str.Reverse().ToArray())));
    }

}
