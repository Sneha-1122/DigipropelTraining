using System;
class StringSort {
  static void Main() {
    
    // Program to accept two names and sort in alphabetical order
    Console.WriteLine("Program to accept two names and sort in alphabetical order");

    // Creating a list
    var names = new List<string>();
    string name1, name2;
    name1 = Console.ReadLine();
    Console.WriteLine("First name: "+name1);
    name2 = Console.ReadLine();
    Console.WriteLine("Second name: "+name2);

    // Adding names to the list
    names.Add(name1);
    names.Add(name2);

    // Function to sort the given input
    names.Sort();
    
    Console.WriteLine("After sorting: ");
    foreach(char str in names){
        Console.WriteLine(str);
    }
  }
}

/*
INPUT:
Program to accept two names and sort in alphabetical order

First name: Sneha
Second name: Sadhana
After sorting:
Sadhana
Sneha
*/
