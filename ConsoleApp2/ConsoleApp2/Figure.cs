using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Figure
    {
        public double width, height, radius;
        public const float Pi = 3.14f;

        public abstract double GetArea();
    }
    public class Rectangle : Figure
    {
        public Rectangle(double width,double height)
        {
            this.width = width;
            this.height = height;   
        }
        public override double GetArea()
        {
            return width * height;
        }
    }
    public class Circle : Figure
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return Pi*radius*radius;
        }
    }
    public class Cone : Figure
    {
        public Cone(double radius,double height)
        {
            this.radius=radius;
            this.height=height;
        }
        public override double GetArea()
        {
            return Pi*radius*(radius+Math.Sqrt(height*height+radius*radius));
        }

       
    }
   class TestFigures
    {
        static void Main()
        {
            Rectangle r = new Rectangle(12.67, 56.78);
            Circle c = new Circle(45.67);
            Cone co = new Cone(34.98, 12.98);

            Console.WriteLine("Area of Rectangle: " +r.GetArea()+"\n");
            Console.WriteLine("Area of Circle: " + c.GetArea()+"\n");
            Console.WriteLine("Area of Cone: " + co.GetArea());





        }
    }
    
}
