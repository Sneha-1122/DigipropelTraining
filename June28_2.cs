﻿using System;

namespace June28_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            int[] arr = new int[100];
            int i, j, num, count = 0;
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

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
            Console.WriteLine("\n Total number of duplicate elements found in array:" + count);
            Console.ReadLine();
        }
    }
}
