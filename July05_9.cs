using System;
using System.IO;
 
class ReadWriteFile
{

    // Naming the file
    const string fileName = "Example.dat";
 
    static void Main()
    {
        // Calling methods to write and read a file
        WriteContent(); 
        ReadContent();
    }
 
    // Method to create a file and write the content
    public static void WriteContent()
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
        {
           
            writer.Write("current date and time : " + DateTime.Now.ToString());
           
        }
    }
 
    // Method to read the written file
    public static void ReadContent()
    {
       
        if (File.Exists(fileName))
        {
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                Console.WriteLine(reader.ReadString());
                
            }
 
           
        }
    }
}

/* 
OUTPUT:
current date and time : 11-07-2021 23:21:16
*/