using System;
class StringCount {

    // Program to count the number of words in the given input
    static void Main() {
    Console.WriteLine("Program to count the number of words in the given input");
    Console.WriteLine("\nEnter your string input: ");
    string str = Console.ReadLine();
    int i = 0;
    int words = 1;

    while (i <= str.Length - 1)
    {
        // To check whether the current character is white space or new line or a tab
        if(str[i]==' ' || str[i]=='\n' || str[i]=='\t')
        {
            words++;
        }

        i++;
    }

    Console.Write("Total number of words in the string is : {0}\n", words);
	}
}

/*
INPUT:
Program to count the number of words in the given input

Enter your string input:
Digipropel India Private Limited

OUTPUT:
Total number of words in the string is : 4
*/
