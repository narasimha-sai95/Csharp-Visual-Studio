using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Ninethv
    {
        int x = 100;
        const int z=22;
        static int y = 200;
        readonly int b;
        public Ninethv()
        {
            b = 23;
        }
        static void Main(string[] args)
        {
            
            Ninethv ninethv = new Ninethv();
            
            Console.WriteLine(ninethv.b);
            int a = ninethv.x;
            Console.WriteLine(z);
        }
    }
}
