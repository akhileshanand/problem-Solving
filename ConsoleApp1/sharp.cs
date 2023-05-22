using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shape
    {
        public int pos_x;
        public int pos_y;

        public Shape()
        {
            Console.WriteLine("This is base class default constructor");
            Console.ReadLine();
        }

        public Shape(int x, int y)
        {

            pos_x = x;
            pos_y = y;
            Console.WriteLine("This is base class constructor");
        }

        public virtual void DrawObject()
        {
            Console.WriteLine("Drawing the Shapes");
        }

        public void GetPosition()
        {
            Console.WriteLine(string.Format("The position of the shape is x- {0}, y-{1}", pos_x, pos_y));
        }
    }

    public class Circle : Shape
    {
        public Circle(int x, int y)
        : base(x, y)
        {
            Console.WriteLine("This is derived class Circle constructor");
        }

        public override void DrawObject()
        {
            Console.WriteLine("Drawing Circle");
        }

        public new void GetPosition()
        {
            Console.WriteLine(string.Format("The position of the Circle is x- {0}, y-{1}", pos_x, pos_y));
        }

        public void CalculateRadius()
        {
            Console.WriteLine("Calling the radius of Circle method");
        }
    }
    public class Diamond : Shape
    {
        static Diamond()
        {
            Console.WriteLine("This is derived class Diamond static constructor");
        }
    }

    

}
