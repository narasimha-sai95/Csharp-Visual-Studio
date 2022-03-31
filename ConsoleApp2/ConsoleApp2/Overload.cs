using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Overload : Person
    {
        /*
        public void display()
        {
            Console.WriteLine("Person class");
        }
        */
        public void Test()
        {
            Console.WriteLine("1st method");
        }
        public  void Test(int i)
        {
            Console.WriteLine("2nd method ",+i);

        }
        public void Test(string s)
        {
            Console.WriteLine("3rd method "+s);
        }
        public void Test(int i,string s)
        {
            Console.WriteLine("4th method");

        }
        
        static void Main(string[] args)
        {
            Overload o=new Overload();
            o.Test();
            Person p=new Person();
            p.display();
            o.display();//if the display method is there in overload class then this will return the display method of overload class if not base class's method will be returned
        }
    }
}
