using System;
public abstract class Animal 
{
    private string Name;
    
    public void SetName(string name)
    {
        Name=name;
    }
    public string GetName()
    {
        return Name ;
    }
    public abstract void Eat();
}

// Inheriting from class Animal
public class Dog : Animal
{
    public override  void Eat()
        {
            Console.WriteLine("The Dog is Eating ");
        }
}

// Defining and abstract class
public class AbstractClass
{
    public static void Main()
    {
        Dog obj1 = new Dog();
        Console.WriteLine("Please enter the name of the dog ");
        obj1.SetName("Dog's name is : "+Console.ReadLine());
        Console.WriteLine (obj1.GetName());
        obj1.Eat();
    
    }
}

/*
OUTPUT:
Please enter the name of the dog 
Kulfi
Dog's name is : Kulfi
The Dog is Eating
*/

