using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
     class Square
    {
        int side;
        public Square(int _Side)
        {
            Side = _Side;
        }
        public Square(Square squr) : this(squr.Side) { }
        public Square() { }
        public int Side
        {
            set
            {
                if (value < 0)
                    side = 1;
                else
                    side = value;
            }
            get { return side; }
        }

        public int GetArea()
        {
            int area = Side * Side;
            return area;
        }
    }
}
