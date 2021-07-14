
using System;
    public class StudentDetails
    {
        private int rollno;
        private string name;
        private string course;
        private int feepaid;

		private static double servicetax = 12.3; 

        public StudentDetails(int rollno, string name, string course)
        {   
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }

        // Amount paid by the Student
        public void Payment(int amount) 
        {
            feepaid += amount;
        }

        // Printing details of Student
        public void Print()
        {
            Console.WriteLine(rollno);
            Console.WriteLine(name);
            Console.WriteLine(course);
            Console.WriteLine(feepaid);
        }

        // Calculating Due amount to be paid
        public int DueAmount
        {

            get
            {
                return TotalFee - feepaid;
            }
        }

        // Calculating course fee with service tax
        public int TotalFee
        {
            get // using condition for feepaid for c# and asp.Net
            {
                double total = course == "c#" ? 2000 : 3000;
				// service tax
                 total = total + total * servicetax / 100;
                return (int) total;
            }
        }
		public static double  ServiceTax
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value;
            }
    }

    public class Student
    {

        public static void Main()
        {

            StudentDetails sd1 = new StudentDetails(648, "Name: Sneha", "Course: c#");
            sd1.Payment(1200);
            sd1.Print();
            Console.WriteLine(sd1.DueAmount);
			
            StudentDetails sd2 =new StudentDetails(1231, "Name: Sadhana", "Course: ASP.Net");
            sd2.Payment(1400);
            sd2.Print();
     		Console.WriteLine(sd2.DueAmount);
        }
    }
	}

/*
OUTPUT:
648
Name: Sneha
Course: c#
1200
2169
1231
Name: Sadhana
Course: ASP.Net
1400
1969*/