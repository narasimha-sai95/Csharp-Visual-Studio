using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

     class Two :Program
    {
    static void Main()
        {
            Two t =new Two();
            //t.Test1(); this will get error due to private variables will not accesible out side of class
            t.Test2();
            t.Test3();
            t.Test4();  
            t.Test5();

        }
    }
}
