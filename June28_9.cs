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
    int j, temp;
    for(int i=0; i<arraySize; i++) {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    for(int i=0; i<arraySize; i++)
    {
        for(j=i+1; j<arraySize; j++)
        {
            if(arr[j] < arr[i])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    Console.WriteLine("Elements of array in ascending order: ");
    for(int i=0;i<arraySize;i++) {
        Console.WriteLine(arr[i]);
    }
    
/*    for(int i = arraySize-1; i>=0; i--){
        Console.WriteLine("Element {0} ",arr[i]);
    }*/
  //Console.WriteLine("The sum of all elements is: "+sum);
  }
}