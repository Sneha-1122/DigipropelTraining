/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Hello World");
        int[,] mat1 = new int[10, 10];
        int[,] mat2 = new int[10, 10];
        int row1, row2, col1, col2, i, j, num = 1;
        Console.WriteLine("Number of rows in matrix 1: ");
        row1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number of columns in matrix 1: ");
        col1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number of rows in matrix 2: ");
        row2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number of columns in matrix 2: ");
        col2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Elements in matrix 1: ");
        for (i = 0; i < row1; i++)
        {
            for (j = 0; j < col1; j++)
            {
                Console.WriteLine("Elements - [{0}],[{1}]" + (i, j));
                mat1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("First Matrix: ");
        for (i = 0; i < row1; i++)
        {
            for (j = 0; j < col1; j++)
            {

                Console.WriteLine(mat1[i, j]);

            }
        }
        Console.WriteLine("Enter Elements of second matrix")
      for (i = 0; i < row2; i++)
        {
            for (j = 0; j < col2; j++)
            {
                Console.WriteLine("Elements - [{0}],[{1}]" + (i, j));
                mat2[i, j] = Convert.ToInt32(Console.ReadLine());

            }
        }

        Console.WriteLine("Second Matrix: ");
        for (i = 0; i < row2; i++)
        {
            for (j = 0; j < col2; j++)
            {
                Console.WriteLine(mat2[i, j]);
            }
        }

        if (row1 != row2 && col1 != col2)
        {
            Console.WriteLine("The Matrices are not equal, hence cannot be compared");
        }
        else
        {
            Console.WriteLine("The Matrices can be compared");

            for (i = 0; i < row1; i++)
            {
                for (j = 0; j < col2; j++)
                {
                    if (mat1[i, j] != mat2[i, j])
                    {
                        num = 0;
                        break;
                    }
                }
                if (num == 1)
                    Console.WriteLine("The given matrices are equal");

                else
                    Console.WriteLine("The given matrices are not equal");
            }
        }
        //Console.WriteLine("The sum of all elements is: "+sum);
    }

  
}