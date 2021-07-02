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
    Console.WriteLine("Input the number of elements to be stored in the array1: ");
    int arraySize1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the number of elements to be stored in the array2: ");
    int arraySize2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the elements of array 1: ");
    int[] arr1 = new int[10];
    int[] arr2 = new int[10];

// Creating elements of array 1
    for(int i=0; i<arraySize1; i++) {
        arr1[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Elements of array 1: "+arr1[i]);
    }
    //Console.WriteLine("Elements of array 1: "+arr1[i]);
    
    for(int i=0; i<arraySize2;i++){
        arr2[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Elements of array 2: "+arr2[i]);
    }
    // Converting integers to Strings
    string[] array1 = Array.ConvertAll(arr1, ele => ele.ToString());
    string[] array2 = Array.ConvertAll(arr2, ele => ele.ToString());
    Console.WriteLine(string.Join("",arr1));
    Console.WriteLine(string.Join("",arr2));
    
    //Converting back Strings to Integers
    int num1 = Convert.ToInt32(string.Join("",arr1));
    int num2 = Convert.ToInt32(string.Join("",arr2));
    int sum=num1+num2;
    Console.WriteLine("Sum of the respective array strings is: "+sum);
    
 /*  for(int j=0; j<arraySize; j++) {
        arr2[j] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Elements of array 2: "+arr2[j]);
    } */
    
    



/*    for(int i = arraySize-1; i>=0; i--){
        Console.WriteLine("Element {0} ",arr[i]);
    }*/
  //Console.WriteLine("The sum of all elements is: "+sum);
  }
}