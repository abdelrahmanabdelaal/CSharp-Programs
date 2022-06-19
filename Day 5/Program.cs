using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Program
    {
        static void Main(string[] args)
        {
            FractionNum first = new FractionNum(4, 5);
            first.Print();
            FractionNum second = new FractionNum(2, 3);
            FractionNum add = first + second;
            add.Print();
            FractionNum plus_1 = ++first ;
            plus_1.Print();
            bool res1 = first == second;
            bool res = first != second;

            FractionNum n =new FractionNum(2,4);
            FractionNum m = new FractionNum(n);
            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.ReadLine();
        }
    }
}
