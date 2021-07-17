using System;
using System.Linq;
class StringCapitalize
{
    static void Main()
    {
        // Program to convert the first character of each word of a given string to uppercase.
        Console.WriteLine("Program to convert the first character of each word of a given string to uppercase");
        string str = "python exercises";
        Console.WriteLine("\nOriginal string: " + str);
        Console.WriteLine("After converting the first character of each word of the said string:\n" + Caps(str));
        str = "The quick brown Fox jumps over the little lazy Dog";
        Console.WriteLine("\nOriginal string: " + str);
        Console.WriteLine("After converting the first character of each word of the said string:\n" + Caps(str));
    }

    // Method to split the whole string, Capitalize the first character of every word and then join the words back to a sentence
    public static string Caps(string str)
    {
        return string.Join(" ", str.Split(' ').Select(str => char.ToUpper(str[0]) + str.Substring(1)));
    }

}

/*
OUTPUT:
Program to convert the first character of each word of a given string to uppercase

Original string: python exercises
After converting the first character of each word of the said string:
Python Exercises

Original string: The quick brown Fox jumps over the little lazy Dog
After converting the first character of each word of the said string:
The Quick Brown Fox Jumps Over The Little Lazy Dog
*/
