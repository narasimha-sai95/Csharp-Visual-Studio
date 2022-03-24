using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//consuming members of a class from non-child class
namespace ConsoleApp2
{
    class Three
    {
        static void Main()
        {
            Program p=new Program();
            p.Test2();
             
            p.Test4();
            p.Test5();  

        }
    }
}
