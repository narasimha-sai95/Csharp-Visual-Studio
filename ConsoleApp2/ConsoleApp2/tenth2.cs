using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class tenth2 : tenth1
    {
      //public tenth2() : base(10)
         public tenth2(int a):base(a)
        {
            Console.WriteLine("Second class constructor");
        }

   static void Main(string[] args)
    {

            tenth2 c = new tenth2(12);


    }
}
}
