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
    int max = arr[0];
    int min = arr[0];
    for(int i=0; i<arraySize; i++) {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    //Console.WriteLine(arr[i]);
    for(int i=0; i<arraySize; i++) 
	{
        if(arr[i]>max){
            max = arr[i];
        }
        if(arr[i]<min){
            min = arr[i];
        }
    }
    Console.WriteLine("Maximum element: "+max);
    Console.WriteLine("Minimum element: "+min);


    
  //Console.WriteLine("The sum of all elements is: "+sum);
  }
}