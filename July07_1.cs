using System;

public class CarProgram {

    // Creating an interface with two methods
    public interface Ivehicle {

        void Drive();
        bool Refuel(int amount);

    }

    public class Car :Ivehicle
        {
            // To set the initial value of fuel
            public int fuel{ get; set;}
            public Car(int Fuel)
            {
                fuel = Fuel ;
            }
            public void Drive() 
            {
                if( fuel > 0 )
                {
                    Console.WriteLine("the car is driving");
                }
                else
                {
                    Console.WriteLine("No fuel, Please Refuel the Car");
                }
                
            }

            // To increase the gasoline of the car and return true.
            public bool Refuel(int amount)
            {
                fuel += amount;
                return true;
            }
        }

   public static void Main ()
    {
        // Object of type car with 0 gasoline
        Car obj1 = new Car(0);
        Console.WriteLine("Enter the speed of car:");
        int Fuel = int.Parse(Console.ReadLine());
        if (obj1.Refuel(Fuel))
        {
            obj1.Drive();
        }
    }
}

/*
INPUT1:
Enter the speed of car:
50
OUTPUT1:
the car is driving

INPUT2:
Enter the speed of car:
0
OUTPUT2:
No fuel, Please Refuel the Car
*/