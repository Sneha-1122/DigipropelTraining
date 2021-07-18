using System;

public class StringCheck 
{
  static void Main(string[] args)
        {
            string str; 
            Console.Write("Input a string : ");
            str = Console.ReadLine();

            // To check if the string starts with a particular word
            Console.WriteLine(str.StartsWith("Hello"));
        }
}

/*
INPUT1:
Input a string : Hello How are you?
OUTPUT1:
True

INPUT2:
Input a string : Hi I'm good. Thankyou
OUTPUT2:
False
*/