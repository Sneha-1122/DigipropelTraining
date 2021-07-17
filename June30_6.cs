/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class StringPosition
{
    static void Main()
    {
        // Program to find the position of a specific word in a string
        Console.WriteLine("\nProgram to find the position of a specific word in a string");
        Console.WriteLine("\nPlease enter your string input: ");
        string str = "The quick brown fox jumps over the lazy dog";
        Console.WriteLine("Original string: " + str);
        Console.WriteLine("Position of the word 'fox' in the said string: " + posCheck(str, "quick"));
        Console.WriteLine("Position of the word 'The' in the said string: " + posCheck(str, "jumps"));
        Console.WriteLine("Position of the word 'lazy' in the said string: " + posCheck(str, "dog"));
    }

    // Method to pass the sentence input and find the position of the required string
    public static int posCheck(string text, string word)
    {
        return Array.IndexOf(text.Split(' '), word) + 1;
    }
}

/* 
INPUT:
Program to find the position of a specific word in a string

Please enter your string input:
Original string: The quick brown fox jumps over the lazy dog

OUTPUT:
Position of the word 'fox' in the said string: 2
Position of the word 'The' in the said string: 5
Position of the word 'lazy' in the said string: 9
*/
