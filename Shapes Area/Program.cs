using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shapes_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                String input = Console.ReadLine();
                getArea(input);
                Console.WriteLine("enter 1 to end the program or any key to do continue : ");
                string y = Console.ReadLine();
                if (y.Equals("1"))
                    break;
            }
            

            //Console.ReadKey();
        }
        public static void getArea(String input)
        {
            string[] values = input.Split();
            if (values.Length == 2 && values[0]=="c")
            {
                var circle = new Circle() { Radius = float.Parse(values[1]) };
                Console.WriteLine("Circle Area = "+circle.Area());
            }
            else if (values.Length == 3 && values[0] == "s")
            {
                var square = new Square() { Hight = float.Parse(values[1]), width = float.Parse(values[2]) };
                Console.WriteLine("Squar Area = " + square.Area());
            }
            else if (values.Length == 3 && values[0] == "r")
            {
                var rectangle = new Rectangle() { Hight = float.Parse(values[1]), width = float.Parse(values[2]) };
                Console.WriteLine("Rectangle Area = " + rectangle.Area());
            }
        }
       
    }

    abstract class Shape
    {
        public abstract double Area();
    }

    class Square : Shape
    {
        public float Hight { get; set; }
        public float width { get; set; }

        public override double Area()
        {
            return Hight * width;
        }
    }

    class Rectangle : Shape
    {
        public float Hight { get; set; }
        public float width { get; set; }

        public override double Area()
        {
            return Hight * width;
        }
    }

    class Circle : Shape
    {
        public float Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

}
