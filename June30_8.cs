using System;
using System.Linq;
namespace exercises
{
    class AlternateCaps
    {
        static void Main(string[] args)
        {
            // Program to alternate the case of each letter in a given string and the first letter of the said string must be uppercase
            Console.WriteLine("Program to alternate the case of each letter in a given string and the first letter of the said string must be uppercase");
            string str1 = "C# is used to develop web apps, desktop apps, mobile apps, games and much more.";
            Console.WriteLine("\nOriginal string: " + str1);
            Console.WriteLine("\nAfter alternating the case of each letter of the string:\n" + altUpper(str1));
        }

        // Method to 
        public static string altUpper(string str)
        {
            string text = str.Replace(" ", "  ");
            string result_str = "";

            //Toupper() function of the char class converts a character into uppercase
            result_str += Char.ToUpper(str[0]);
            for (int i = 1; i < text.Length; i++)
            {

                // if else condition to change the case of each letter based on the index value
                if (i % 2 == 0) 
                    result_str += Char.ToUpper(text[i]);
                else if (i % 2 != 0 && Char.IsUpper(text[i])) 
                    result_str += Char.ToLower(text[i]);
                else result_str += text[i];
            }
            result_str = result_str.Replace("  ", " ");
            return result_str;
        }
    }
}

/*
OUTPUT:
Program to alternate the case of each letter in a given string and the first letter of the said string must be uppercase

Original string: C# is used to develop web apps, desktop apps, mobile apps, games and much more.

After alternating the case of each letter of the string:
C# Is UsEd To DeVeLoP wEb ApPs, dEsKtOp ApPs, mObIlE aPpS, GaMeS aNd MuCh MoRe.
*/
