using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    enum school
    { 
    mohawk = 1,
    humber=2,
    seneca=3
    
    }
    class Program
    {

        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            var adding = true;

            while (adding)
            {
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student Name: ");


                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");

                    newStudent.school = (school)Util.Console.AskInt("School Name : 1-mohawk, 2-Humber 3-Seneca (Enter the correspondacne)");

                    newStudent.Birthday = Util.Console.Ask("Student Birthday: ");


                    newStudent.Address = Util.Console.Ask("Student Address: ");


                    newStudent.Phone = Util.Console.AskInt("Student Phone Number: ");


                    students.Add(newStudent);


                    Console.WriteLine("Add another? y/n");

                    if (Console.ReadLine() != "y")
                        adding = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Format error");
                }


                foreach (var student in students)
                {
                    Console.WriteLine("Name: {0}, Grade: {1}, BOD: {1},Address: {1},Phone: {1}", student.Name, student.Grade, student.Birthday, student.Address, student.Phone);
                }
                Export();

            }

        }
            static void Export()
            {
                foreach (var student in students)
                {
                    switch (student.school)
                    {
                        case school.mohawk:
                            Console.WriteLine("Exporting to Mohawk");
                            break;
                        case school.humber:
                            Console.WriteLine("Exporting to Humber");
                            break;
                        case school.seneca:
                            Console.WriteLine("Exporting to Seneca");
                            break;
                    }
                }
            }

        
    }
    class Member
    {
        public string Name;        
        public string Address;
        public int Phone;
    }

    class Student : Member
    {
        
        public int Grade;
        public school school;
        public string Birthday;
       
    }

    class Teacher : Member
    {
        public int Subject;
    }

}
