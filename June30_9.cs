using System;
using System.Linq;
class StringReverse
{
    static void Main(string[] args)
    {
        // Program to reverse all the words of a given string which have even length
        Console.WriteLine("Program to reverse the string words with even length");
        string str = "C# is used to develop web apps , desktop apps , mobile apps , games and much more.";
        Console.WriteLine("\nOriginal string: " + str);
        Console.WriteLine("\nReversed string: " + reverseMethod(str));
    }

    // Method to reverse a string based on the length of it
    public static string reverseMethod(string text)
    {
        // Splitting the sentence, reversing the respective strings and joining them back together
        return string.Join(" ", text.Split(' ').Select(str => str.Length % 2 != 0 ? str : new String(str.Reverse().ToArray())));
    }

}

/*
OUTPUT:
Program to reverse the string words with even length

Original string: C# is used to develop web apps , desktop apps , mobile apps , games and much more.

Reversed string: #C si desu ot develop web sppa , desktop sppa , elibom sppa , games and hcum more.
*/
