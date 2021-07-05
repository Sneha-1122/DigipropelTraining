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
    static void Main()
    {
        string str = "python exercises";
        Console.WriteLine("Original string: " + str);
        Console.WriteLine("After converting the first character of each word of the said string:\n" + Caps(str));
        str = "The quick brown Fox jumps over the little lazy Dog";
        Console.WriteLine("\nOriginal string: " + str);
        Console.WriteLine("After converting the first character of each word of the said string:\n" + Caps(str));
    }
    public static string Caps(string str)
    {
        return string.Join(" ", str.Split(' ').Select(str => char.ToUpper(str[0]) + str.Substring(1)));
    }

}