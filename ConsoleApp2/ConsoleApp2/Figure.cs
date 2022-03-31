using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Figure
    {
        public double width, height, radius;
        public const float Pi = 3.14f;


    }
    public class Rectangle : Figure
    {
        public Rectangle(double width,double height)
        {
            this.width = width;
            this.height = height;   
        }
    }
    public class Circle : Figure
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }
    }
    public class Cone : Figure
    {
        public Cone(double radius,double height)
        {
            this.radius=radius;
            this.height=height;
        }
    }
    
}
