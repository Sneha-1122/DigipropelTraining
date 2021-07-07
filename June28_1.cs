/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    
    //Program to add elements of the given array
    
    Console.WriteLine("Input the number of elements to be stored in the array: ");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the elements: ");
    int[] arr = new int[10];
    int sum = 0;
    
    // Storing elements into the array
    
    for(int i=0; i<arraySize; i++) {
        
        arr[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    
    // Adding up elements in the given array
    
    for(int i=0; i<arraySize; i++) {
        
        sum+=arr[i];
        
    }
    
  Console.WriteLine("The sum of all elements is: "+sum);
  
  }
}

/* 
INPUT:
Input the number of elements to be stored in the array:
4
Input the elements:
3
6
2
4

OUTPUT:
The sum of all elements is: 15 
*/
