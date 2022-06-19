using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinking
{
    internal class Program
    {
        // task 2
        static int GetPower(int base_num, int pow)
        {
           
            int result = 1;
            for (int i = 0; i < pow; i++)
                {
                result *= base_num;
                }
            return result;
        }
        // task3
        static void EvenNumbers( int n)
        {
            int numbers = 0;
            for (int i = 0; i < n; i++)
            {
                numbers = numbers + 2;
                Console.WriteLine(numbers);
            }
        }
        // task 4
        static int NumberSum(int n = 10)
        {
            int sum = 0;
         
             for (int i = 0; i < n; i++)
             {
                int num = int.Parse(Console.ReadLine());
                sum = sum+ num;
             }
            
            return sum;
        }
        //task5
        static void Alphabets()
        {
            for (int i = 97; i <= 122; i++)
            {
                Console.WriteLine(((char)i));
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine(GetPower(2,4));

            Console.WriteLine("---------------task2------------------------");
            Console.WriteLine("welcome to the Get power program  if you want to calculate many numbers please enter (yes)");
            string ask = Console.ReadLine();
            while (ask == "yes")
            {
                Console.WriteLine("Enter the base number ");
                int base_number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the power");
                int pow_number = int.Parse(Console.ReadLine());
                Console.WriteLine("the result is:");
                Console.WriteLine(GetPower(base_number, pow_number));
                ask = Console.ReadLine();
            }
            Console.WriteLine("------------------task3---------------------");
            Console.WriteLine("Enter the number of even numbers you want");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("here is the even numbers");
            EvenNumbers(n);
            Console.WriteLine("--------------task4-------------------------");
            Console.WriteLine("Enter  numbers");
            Console.WriteLine(NumberSum(10));
            Console.WriteLine("--------------task5-------------------------");
            Console.WriteLine("English Alphabets");
            Alphabets();

            Console.ReadLine();

        }
    }
}
