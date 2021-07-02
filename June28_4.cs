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
    Console.WriteLine("Input the number of elements to be stored in the array: ");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the elements: ");
    int[] arr = new int[10];
    int[] arr1 = new int[5];
    int[] arr2 = new int[5];
    int sum = 0,j=0,k=0;
    for(int i=0; i<arraySize; i++) {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    for(int i=0; i<arraySize; i++) {
       if (arr[i] % 2 == 0) {
               arr1[j] = arr[i];
               j++;
            } else {
               arr2[k] = arr[i];
               k++;
    }
    Console.WriteLine("Even numbers...");
    for (i = 0; i < j; i++) {
    Console.WriteLine(arr1[i]);
    }
    Console.WriteLine("Odd numbers...");
    for (i = 0; i < k; i++) {
    Console.WriteLine(arr2[i]);
    }
}
  //Console.WriteLine("The sum of all elements is: "+sum);
  }
}