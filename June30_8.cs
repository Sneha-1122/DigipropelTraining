using System;
using System.Linq;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "C# is used to develop web apps, desktop apps, mobile apps, games and much more.";
            Console.WriteLine("Original string: " + str1);
            Console.WriteLine("After alternating the case of each letter of the string:\n" + altUpper(str1));
        }
        public static string altUpper(string str)
        {
            string text = str.Replace(" ", "  ");
            string result_str = "";
            result_str += Char.ToUpper(str[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (i % 2 == 0) result_str += Char.ToUpper(text[i]);
                else if (i % 2 != 0 && Char.IsUpper(text[i])) result_str += Char.ToLower(text[i]);
                else result_str += text[i];
            }
            result_str = result_str.Replace("  ", " ");
            return result_str;
        }
    }
}