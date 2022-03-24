using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{
    class Five
    {
        static void Main()
        {
            ConsoleApp2.Program p = new ConsoleApp2.Program();
            p.Test5();//only public is accesible
            //protected internal is only accesible with inheritance
        }
    }
}
