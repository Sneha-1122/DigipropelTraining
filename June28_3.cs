/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
	  
	// Program to find the frequency of each element in the given array
	// Creating arrays of type int and size 100
	  
 	int[] arr1 = new int[100];
	int[] freq = new int[100];
    int n, i, j, count;
	  
   Console.Write("Input the number of elements to be stored in the array :");
   n = Convert.ToInt32(Console.ReadLine()); 	   

   Console.Write("Input {0} elements in the array : ",n);
   for(i=0;i<n;i++)
        {
      arr1[i] = Convert.ToInt32(Console.ReadLine()); 		  
	  freq[i] = -1;
    }
	  
    // Checking the occurence of every element in the array, and incrementing the count
    for(i=0; i<n; i++)
    {
        count = 1;
        for(j=i+1; j<n; j++)
        {
            if(arr1[i]==arr1[j])
            {
                count++;
                freq[j] = 0;
            }
        }
       if(freq[i]!=0)
    {
        freq[i] = count;
    }
  }
      for(i=0; i<n; i++)
    {
        if(freq[i]!=0)
        {
            Console.Write("{0} occurs {1} times\n", arr1[i], freq[i]);
        }
    }
}
}

/* 
INPUT:
Input the number of elements to be stored in the array :6
Input 6 elements in the array : 2
3
4
1
2
3

OUTPUT:
2 occurs 2 times
3 occurs 2 times
4 occurs 1 times
1 occurs 1 times
*/
