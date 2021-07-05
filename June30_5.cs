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
    string str = Console.ReadLine();
    int l = 0, count = 1;

    while (l < str.Length-1){
        if (str[l] == ' '||str[l] == '\n'||str[l] == '\t'){
            count++;
        }
        l++;
    }
    Console.WriteLine("Count of words in the given input: "+count);
        string Capitalized;
        for (l=0; l<str.Length; l++)
        {
            Capitalized = str[l].ToUpper();
        }
        Console.WriteLine("Capitalized string is as follows: " + Capitalized);
    
  }

}