using System;  
public class Asterisk {  

    // Program to display alphabet pattern like B with an asterisk
    public static void Main(){

    // Declaring required variables
    int row,column; 
 
    for(row=0;row<=6;row++)
        {
            for (column=0; column<=6; column++)
            {
            if (column == 1 || ((row == 0 || row == 3 || row == 6) && (column < 5 && column > 1)) || (column == 5 && (row != 0 && row != 3 && row != 6)))
                Console.Write("*");
                else
                Console.Write(" ");
            }
            Console.Write("\n");
        }
    Console.Write("\n");
    }
}

/*
OUTPUT:

 ****
 *   *
 *   *
 ****
 *   *
 *   *
 ****


 */
