using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {

        static void GetThePower (float num, float pow)
        {
            for (float i = 1;  i== pow;i++)
            {
                float power_of_number = num * num;
                Console.WriteLine(power_of_number);
            };
        }
        static int GetEvenNumbers(int num_of_numbers)
        {
            for (int i = 2; i == num_of_numbers; i+=2)
            {
                int res = i;
            }
            return num_of_numbers;
        }

        static float NumberSum(float num1, float num2)
        {
            float sum = ;
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {

            //float number = float.Parse( Console.ReadLine());
            //float power = float.Parse(Console.ReadLine());
            //GetThePower(number, power);
            //for (int i = 1; i < 10; i+=2)
            //{
            //    Console.WriteLine(i);
            ////}
            //float num1 = float.Parse(Console.ReadLine());
            //float num2 = float.Parse(Console.ReadLine());
            //float num3 = float.Parse(Console.ReadLine());
            //float num4 = float.Parse(Console.ReadLine());
            //float num5 = float.Parse(Console.ReadLine());
            //float num6 = float.Parse(Console.ReadLine());
            //float num7 = float.Parse(Console.ReadLine());
            //float num8 = float.Parse(Console.ReadLine());
            //float num9 = float.Parse(Console.ReadLine());
            //float num10 = float.Parse(Console.ReadLine());
            //NumberSum(num1, num2, num3, num4, num5, num6, num7, num8, num9, num10);

            //GetEvenNumbers(5);
            //Console.ReadLine();




        }
    }
}
