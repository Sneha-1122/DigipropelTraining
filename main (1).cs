/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    string FirstName = "Sneha";
    string LastName = "Nandimandalam";
    Console.WriteLine(FirstName+" "+LastName);
    Console.WriteLine($"Hello {FirstName}");
    Console.WriteLine(FirstName.ToUpper());
    Console.WriteLine(LastName.ToLower());
    Console.WriteLine(LastName.Length);
  }
}
