using System;
class RandomNumber
{
    static void Main()
    {

      // Generating random numbers by creating an object of the random class  
      Random random = new System.Random();
      Console.WriteLine("Random number between 0-1000 :" +(random.Next(0,1000))); 
      Console.WriteLine("Random number between 200-500 : "+(random.Next(200,500)));
      Console.WriteLine("Random number between 10-50 : "+(random.Next(10,50)));
    }
}

/*
OUTPUT:
Random number between 0-1000 :32
Random number between 200-500 : 441
Random number between 10-50 : 37
*/