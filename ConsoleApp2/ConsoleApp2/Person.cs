using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        public int id;
        public string name, address, phone;
        public Person()
        {
            this.id = id;
            this.name = name;   
            this.address = address; 
            this.phone = phone;
                

        }
        
        public class Student : Person
        {
            public int clas;
            public char grade;
           public  float marks, fees;

            public Student()
            {
                  this.clas = clas;  
                this.grade = grade;
                this.marks = marks;
                this.fees = fees;
            }
            public override string ToString()
            {
                return "id " + id + " name " + name + " address " + address + " phone " + phone +" class "+
                    clas+" grade "+grade+" marks "+marks+" fee "+fees;
            }
        }
        public class Staff : Person
        {
            public double salary;
            public string designation;

        }
        public class Teaching : Staff
        {

            string qualification, subject;

        }
        public class NonTeaching : Staff
        {
            int MgrId;
            string Dname;

        }

        static void Main(string[] args)
        {
            Student student = new Student();
            student.id = 55;
            student.name = "sai";
            student.address = "hyderabad";
            student.phone = "8639761368";
            student.clas = 3;
            student.grade = 'A';
            student.marks = 40;
            student.fees = 88;

            Console.WriteLine(student);
        }
    }
}
