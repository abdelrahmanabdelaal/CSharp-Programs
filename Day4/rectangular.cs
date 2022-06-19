using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
     class Rectangular
    {
        int width;
        int height;
        public  Rectangular(int _Width, int _Heigth)
        {
            Width = _Width;
            Height = _Heigth;

        }
        public Rectangular(Rectangular rect) : this(rect.Width, rect.Height) { }
        public Rectangular() { }

        public int Width
        {
            set {
                if (value < 0)
                    width = 1;
                else
                    width = value;
                 } 
            get { return width; } 
        }
        public int Height
        {
            set {
                if (value < 0)
                    height = 1;
                else height = value;
                }
            get
            {
                return height;
            }

        }

        public int GetArea()
        {
            int area = Height * Width;
            return area;
        } 
    }

}
