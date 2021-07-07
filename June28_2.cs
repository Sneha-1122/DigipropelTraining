using System;

namespace June28_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Program to find the number of duplicate elements
            
            int[] arr = new int[100];
            int i, j, num, count = 0;
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements in the array: ");
            
            // Storing the elements in the array through console
            
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            // Counting the number of duplicates in the given array

            for (i = 0; i < num; i++)
            {
                for (j = i + 1; j < num; j++)
                {
                    // If duplicate element found then increment count by 1
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            
            // Printing the number of duplicate elements 
            
            Console.WriteLine("\n Total number of duplicate elements found in array: " + count);
        }
    }
}

/*
INPUT: 
Enter size of the array:
6
Enter elements in the array:
2
4
5
2
3
4

OUTPUT:
Total number of duplicate elements found in array: 2
