using System;
class StringLength {
    
    static void Main() {

    // Program to find the length of a string without using library function
    Console.WriteLine("\nProgram to find the length of a string without using library function\n");

    Console.WriteLine("Enter your string input: ");
    string word = Console.ReadLine();
    int length = 0;

    // Using foreach loop to traverse through every letter in the word
    foreach (char c in word) {

        length+=1;

    }
    
    Console.WriteLine("\nLength of the given string is: "+length);

  }
}

/*
INPUT:
Program to find the length of a string without using library function

Enter your string input: 
Digipropel India Private Limited

OUTPUT:
Length of the given string is: 32
*/

