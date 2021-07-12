using System;

// Creating public class Person
public class Person {

    public void Greet() {

        Console.WriteLine("Hello!");
    }

    public void SetAge(int n) {
        int age = n;
    }

}

// Creating class Student and inheriting from class Person
public class Student: Person {

    public void Study(){

         Console.WriteLine("I'm studying on the screen");

    }

    public void ShowAge(){

        Console.WriteLine("My age is: 25 years old on the screen");
    }
}

// Creating class Teacher and inheriting from class Person
public class Teacher: Person {

    public void Explain() {
        Console.WriteLine("I'm explaining on the screen");
    }

}

public class StudentProfessorTest {

    public static void Main(){

        // Creating 3 objects for 3 classes and calling respective methods
        Person p1 = new Person();
        p1.Greet();

        Student s1 = new Student();
        s1.Greet();
        s1.SetAge(25);
        s1.ShowAge();

        Teacher t1 = new Teacher();
        t1.SetAge(40);
        t1.Greet();
        t1.Explain();

    }
}

/*
OUTPUT:
Hello!
Hello!
My age is: 25 years old on the screen
Hello!
I'm explaining on the screen
*/