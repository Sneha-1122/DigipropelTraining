using System;
using System.IO;
class WordSearch
{
    public static void Main()
    {
        // Opening respective file in local 
        FileStream inFile = new FileStream(@"C:\Users\dpladmin\Documents\Document1.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(inFile);
        string record;
        string input;
        Console.Write("Enter the word to search in the file :\n");
        input = Console.ReadLine();
        try
        {
            
            record = reader.ReadLine();
            while (record != null)
            {
                // To check for the required string in the file
                if (record.Contains(input))
                {
                    Console.WriteLine(record);
                }
                
                record = reader.ReadLine();
                
            }
        }
        finally
        {
            // Closing the file
            reader.Close();
            inFile.Close();
        }
        
        
        Console.ReadLine();
    }
}