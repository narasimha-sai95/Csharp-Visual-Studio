using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Methodhiding
    {
        //method hiding
        public  void Show()
        {
            Console.WriteLine("Parent Show method");
        }
    }
    public class Childclass : Methodhiding
    {
        public new void Show()
        {
            Console.WriteLine("Child Show method");
        }
        public void ParentShow()
        {
            base.Show();
        }
        static void Main()
        {
            Childclass c=new Childclass();
            c.Show();
            c.ParentShow();
        }
       
    }

}
