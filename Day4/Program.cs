using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Square first = new Square(4);
//Console.WriteLine(first.Side);
//first.GetArea();
//Rectangular one = new Rectangular(4, 3);
//Console.WriteLine();
//one.GetArea();
namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangular rec1 = new Rectangular(2, 3);
            //Rectangular rec2 = new Rectangular(rec);
            Square squ1 = new Square(5);
            Square[] squares = new Square[2];
            squares[0] = new Square(3);
            squares[1] = squ1;
            Picture pic = new Picture();
            pic.squares = squares;
            pic.Rec1 = rec1;

            Console.WriteLine(pic.TotalArea());
           
            Console.ReadLine();
        }
    }
}
