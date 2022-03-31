using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //method overriding
    public class Loadparentclass
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Show method");
        }
        public void Test()
        {
            Console.WriteLine("Parent Test method");
        }
    }
    public class LoadChild:Loadparentclass
    {
        public override void Show()
        {
            Console.WriteLine("Child Show method");
        }
        static void Main(string[] args)
        {
            LoadChild c=new LoadChild();    

            c.Show();
            c.Show();
            
        }
    }
}
