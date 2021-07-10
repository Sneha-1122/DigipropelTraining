/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Linq;
class HelloWorld {
  static void Main(string[] args)
          {

            // Program to find the missing number in a given array of numbers between 10 and 20.

            Console.WriteLine("Program to find the missing number in a given array of numbers between 10 and 20.");
            
            // Creating and initialising the array
            int[] nums = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            // Printing the initialised array
            Console.WriteLine("Original array elements:");
            Array.ForEach(nums, Console.WriteLine);

            //Calling the respective method
            Console.WriteLine("Missing number in the said array (10-20): "+ missingEle(nums));

            int[] nums1 = {11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("Original array elements:");
            Array.ForEach(nums1, Console.WriteLine);
            Console.WriteLine("Missing number in the said array (10-20): " + missingEle(nums1));

            int[] nums2 = { 10, 11, 12, 13, 14, 16, 17, 18, 19, 20 };
            Console.WriteLine("Original array elements:");
            Array.ForEach(nums2, Console.WriteLine);
            Console.WriteLine("Missing number in the said array (10-20): " + missingEle(nums2));

            int[] nums3 = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            Console.WriteLine("Original array elements:");
            Array.ForEach(nums3, Console.WriteLine);
            Console.WriteLine("Missing number in the said array (10-20): " + missingEle(nums3));

        }

        // Method to find out the missing element in the array
        public static int missingEle(int[] arr)
        {
            return 165 - arr.Sum();
        }
}

/*
INPUT:
Program to find the missing number in a given array of numbers between 10 and 20.
Original array elements:
10
11
12
13
14
15
16
17
18
19
20
Missing number in the said array (10-20): 0
Original array elements:
11
12
13
14
15
16
17
18
19
20
Missing number in the said array (10-20): 10
Original array elements:
10
11
12
13
14
16
17
18
19
20
Missing number in the said array (10-20): 15
Original array elements:
10
11
12
13
14
15
16
17
18
19
Missing number in the said array (10-20): 20
*/
