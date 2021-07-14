using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirFile
{
    class DirFile {

        // Creating a directory
        static void CreateDirectory(){

            DirectoryInfo dir = new DirectoryInfo("C:/Example");

            try {
                // To check if directory already exists
                if(dir.Exists) {

                    Console.WriteLine("Directory Already Exists");
                    Console.WriteLine("Directory Name:" + dir.Name);
                    Console.WriteLine("Path" + dir.FullName);
                    Console.WriteLine("Created on" + dir.CreationTime);
                    Console.WriteLine("Last accessed on" + dir.LastAccessTime);
                    }

                else {

                    dir.Create();
                    Console.WriteLine("Directory Created Successfully. Information of Directory:");
                    Console.WriteLine("Directory Name:" + dir.Name);
                    Console.WriteLine("Path" + dir.FullName);
                    Console.WriteLine("Created on" + dir.CreationTime);
                    Console.WriteLine("Last accessed on" + dir.LastAccessTime);
                }
            }

            catch (DirectoryNotFoundException d) {

                Console.WriteLine(d.Message.ToString());

            }
        }

        // Creating a File
        static void CreateFile() {

            FileInfo file = new FileInfo("C:\\Example\test.txt");
            // writing content of file using StreamWriter
            using (StreamWriter sw = file.CreateText())
                {
                    sw.WriteLine("Hello File Handling");
                }

            //Diplaying File Info
            Console.WriteLine("File created on : " + file.CreationTime);
            Console.WriteLine("Directory Name : " + file.DirectoryName);
            Console.WriteLine("Full Name of the file : " + file.FullName);
            Console.WriteLine("Last accessed on : " + file.LastAccessTime);
        }

        static void Main(string[] args)
            {
                CreateDirectory();
                CreateFile();
                Console.ReadKey();
            }
    }

}

/*
Directory Already Exists
Directory Name:Example
PathC:\Example
Created on13-07-2021 22:45:11
Last accessed on13-07-2021 22:56:05
File created on : 13-07-2021 22:45:11
Directory Name : C:\Example
Full Name of the file : C:\Example\test.txt
Last accessed on : 14-07-2021 09:32:35
*/



    