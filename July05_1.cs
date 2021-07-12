using System;
 
public class Program
{
    public static void Main(string[] args) 
    {
        int size = 3;

        // Creating array of type person
        Person[] persons = new Person[size];  

        Console.WriteLine("Please input the names");
        for (int i = 0; i < size; i++)
        {
            persons[i] = new Person() {
                Name = Console.ReadLine()
			};
        }
 
        for (int i = 0; i < size; i++) 
        {
            Console.WriteLine(persons[i]);
        }
    }
}
 
    public class Person
    {

        // Using get method to return the value of the variable
        // Using set method to set the value of the variable
        public string Name { get; set; } 

        public override string ToString() 
        {
            return "Name :" + Name;
        }
    }

/*
INPUT:
Please input the names
Jane
Sara
Carlos

OUTPUT:
Name :Jane
Name :Sara
Name :Carlos
*/