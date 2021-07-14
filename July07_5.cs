using System;

namespace Student
{

    // Common class to store name duration and fee of all courses
    abstract class Course
    {
        protected string name;
        protected int duration;
        protected int coursefee;

        public Course(string name, int duration, int coursefee)
        {
            this.name = name;            
            this.duration = duration;
            this.coursefee = coursefee;
        }

        public virtual void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(duration);
            Console.WriteLine(coursefee);
        }

        public abstract int  GetTotalFee(); 
    }

    // Class to store timings of Part time course
    class ParttimeCourse : Course
    {
        private string timings;

        public ParttimeCourse(string name, int duration, int coursefee, string timings) : base(name,duration,coursefee)
        {
            this.timings = timings;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(timings);
        }

        public override int GetTotalFee()
        {
            return (int)  (coursefee * 0.90);  
        }

    }

    // Class to store company name and no. of Students of Onsite Course
    class OnsiteCourse : Course 
    {
        private string company;
        private int noOfStudents;

        public OnsiteCourse(string name, int duration, int coursefee, string company, int noOfStudents)
            : base(name, duration, coursefee) 
        {
            this.company = company;
            this.noOfStudents = noOfStudents;
        }

        public override void Print() 
        {
            base.Print();
            Console.WriteLine(company);
            Console.WriteLine(noOfStudents);
        }

        public override int GetTotalFee()
        {
            return (int)(coursefee * 1.1);  
        }

    }

    // Final class to create objects and display data of different classes
    public class TestCourse
    {

        public static void Main() 
        {
            Course oc = new OnsiteCourse("ASP.NET", 60, 10000, "Udemy", 10);
            oc.Print();
            Console.WriteLine(oc.GetTotalFee());

            Course pc = new ParttimeCourse("C#", 30, 8000, "5-7pm");
            pc.Print();
            Console.WriteLine(pc.GetTotalFee());
        }


    }
}

/*
ASP.NET
60
10000
Udemy
10
11000
C#
30
8000
5-7pm
7200
*/