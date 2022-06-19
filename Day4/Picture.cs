using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Picture
    {
        Rectangular rec1;
        public Rectangular Rec1
        {
            set
            {
                rec1 = new Rectangular(value);
            }
            get
            {
                return new Rectangular(rec1);
            }
        }
        public Square[] squares { get; set; }
        public int TotalArea()
        {
            
            int squ_area = 0;
            for (int i = 0; i < squares.Length; i++)
            {
                squ_area += squares[i].GetArea(); 
            }
            int rec_area = rec1.GetArea();
            int total_area = squ_area + rec_area;
            return total_area;
        }

    }
}
