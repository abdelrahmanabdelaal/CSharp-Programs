using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class FractionNum
    {
        public int Nume { get; set; }
        public int Deno { get; set; }
        public FractionNum(int _nume, int _deno)
        {
            Nume = _nume;
            Deno = _deno;
        }
        public FractionNum():this(1, 1)
        {

        }
        public FractionNum(FractionNum num)
        {
            this.Nume = num.Nume;
            this.Deno = num.Deno;
        }
        public static FractionNum operator+ (FractionNum num1, FractionNum num2)
        {
            FractionNum result = new FractionNum();
            result.Deno = num1.Deno * num2.Deno;
            result.Nume = (num1.Nume * num2.Deno) + (num2.Nume * num1.Deno);
            return result;
        }
        public static FractionNum operator ++(FractionNum num)
        {
            return new FractionNum(num.Nume+ num.Deno,  num.Deno);
        }
        public static bool operator ==(FractionNum num1, FractionNum num2)
        {
            return num1.Nume == num2.Nume && num1.Deno == num2.Deno;
        }
        public static bool operator !=(FractionNum num1, FractionNum num2)
        {
            return num1.Nume != num2.Nume || num1.Deno != num2.Deno;
        }
        public  void Print( )
        {
            Console.WriteLine($"{Nume}/{Deno}");
        }


       
    }
}
