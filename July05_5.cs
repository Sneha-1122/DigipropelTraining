using System;

public class WordCount
{
	public static void Main()
	{
		String line;
		int count = 0;
		
        // To open the respective file 
		System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\dpladmin\Documents\Document1.txt");
		
        //To check if the file is empty, if not then proceeds with the counting
		while ((line = file.ReadLine()) != null)
		{
			// Splitting the lines into words and storing in a string array
			String[] words = line.Split(' ');
			count = count + words.Length;
		}

		Console.WriteLine("Number of words present in given file: " + count);
		file.Close();
	}
}

/*
OUTPUT
Number of words present in given file: 27
*/