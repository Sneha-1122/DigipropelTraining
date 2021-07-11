/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    
    // Program to read n number of values in an array and display it in reverse order.
    Console.WriteLine("Program to read n number of values in an array and display it in reverse order.");
    Console.WriteLine("\nInput the number of elements to be stored in the array: ");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the elements: ");
    int[] arr = new int[10];

    // Storing elements into the array
    for(int i=0; i<arraySize; i++) {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    // Printing the stored elements
    Console.WriteLine(" Original array: ");
    for(int i=0; i<arraySize; i++) {

        Console.WriteLine(" {0} ",arr[i]);

    }

    // Reversing the order of the elements
    Console.WriteLine("Reversed array: ");
    for(int i = arraySize-1; i>=0; i--){

        Console.WriteLine(" {0} ",arr[i]);
      
    }
  }
}

/*
INPUT:
Input the number of elements to be stored in the array:
5
Input the elements: 
3
5
7
3
2 

OUTPUT:
Original array: 
 3
 5
 7
 3
 2
Reversed array:
 2
 3
 7
 5
 3
 */
