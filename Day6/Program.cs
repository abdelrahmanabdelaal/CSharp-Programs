using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    abstract class Shape { 
        public int Side { get; set; }
        public abstract int GetArea();
    }
    class Square : Shape {
        public Square(int _Side) { Side = _Side; }
        public override int GetArea()
        {
            int area = Side * Side;
            return area;
        }
    }
    class Rectangular : Shape {
        public Rectangular(int _Side, int _Side2) { Side = _Side; Side2 = _Side2; }
        public int Side2 { set; get; }
        public override int GetArea()
        {
            int area = Side * Side2;
            return area;
        }
    }
    class Picture {
        Shape [] shapes { get; set; }
        public int TotalArea(Shape[] shapes)
        {

            int result = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                result += shapes[i].GetArea();
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Shape[] shapes = new Shape[3];
            shapes[0] = new Square(3);
            shapes[1] = new Rectangular(2, 4);
            shapes[2] = new Rectangular(3, 2);
            Picture p = new Picture();
            Console.WriteLine("the total area is:");
            Console.WriteLine(p.TotalArea(shapes));
            Console.ReadLine();
        }
    }
}
