
using System;

namespace EncapInher
{


    class Students
    {

        private String studentName;
        private int studentAge;


        public String Name
        {

            get
            {
                return studentName;
            }

            set
            {
                studentName = value;
            }

        }


        public int Age
        {

            get
            {
                return studentAge;
            }

            set
            {
                studentAge = value;
            }

        }
    }

    class MainClass { 
   public  static void Main(string[] args)
    {
        Student student = new Student();
        Student student1 = new Student();
        Students private1 = new Students();
        Students private2 = new Students();



        student.ID = "101";
        student.Name = "Kundan Kumar";
        student.Email = "Kundan@rrk21@.com";
        student.phone_no = 1234567890;
        student.dept = "IT";


        student1.ID = "103";
        student1.Name = "Nayan Kumar";
        student1.Email = "Nayan@rrk21@.com";
        student1.phone_no = 1234554547;
        student1.dept = "IT";



        Console.WriteLine("ID = " + student.ID);
        Console.WriteLine("Name = " + student.Name);
        Console.WriteLine("Email = " + student.Email);
        Console.WriteLine("Contact no = " + student.phone_no);
        Console.WriteLine("Department = " + student.dept);

        Console.WriteLine("ID = " + student1.ID);
        Console.WriteLine("Name = " + student1.Name);
        Console.WriteLine("Email = " + student.Email);
        Console.WriteLine("Contact no = " + student.phone_no);
        Console.WriteLine("Department = " + student.dept);

        private1.Name = "Kundan Kumar";
        private1.Age = 25;

        private2.Name = "Mahesh Kumar";
        private2.Age = 27;


        Console.WriteLine("-------------------------");
        Console.WriteLine("----accesing Private----");


        Console.WriteLine("Name:-  " + private1.Name);
        Console.WriteLine("Name:-  " + private1.Age);

        Console.WriteLine("Name:-  " + private2.Name);
        Console.WriteLine("Name:-  " + private2.Age);


    }
}
}

