using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    //interface
    public interface IShape
    {
        void draw();
    }
    //concrete class 1
    public class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("I am circle");
            Console.Read();

        }
    }
    //concrete class2
    public class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("I am Rectangle");
            Console.Read();
        }
    }
    //This class is responsible for the object creation of concrete class in this we are hiding the object creation logic
    public class ShapeFactory
    {
        public IShape GetShape(string shape)
        {
            if (shape == null)
            {
                return null;
            }
            if (shape.Equals("Circle"))
            {
                return new Circle();
            }
            else if (shape.Equals("Rectangle"))
            {
                return new Rectangle();
            }
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactoryObj=new ShapeFactory();
            IShape shapeCircle=shapeFactoryObj.GetShape("Circle");
            shapeCircle.draw();
            IShape shapeRectangle=shapeFactoryObj.GetShape("Rectangle");
            shapeRectangle.draw();
        }
    }
}
