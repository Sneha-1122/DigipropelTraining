using System;
 
public class Program
{
    public static void Main(string[] args) 
    {
        int size = 3;
        string Name;
        // Creating array of type person
        Person[] persons = new Person[size];  

        Console.WriteLine("Please input the names");
        for (int i = 0; i < size; i++)
        {
            persons[i] = new Person(Name = Console.ReadLine());
			
        }
        
 
        for (int i = 0; i < size; i++) 
        {
            Console.WriteLine(persons[i]);
        }
    }
}
 
    public class Person
    {
        public string Name { get; set; }
		  public Person(string name)
        {
            Name = name;
        }
 
        // Executing the ToString() method
        
        public override string ToString()
        {
            
            return "Returning given name :" + Name;
        }
		 ~Person()
        {
            Name = string.Empty;
        }
    }

/*
INPUT:
Please input the names
Juan 
Sara
Carlos

OUTPUT:
Returning given name :Juan 
Returning given name :Sara
Returning given name :Carlos
*/