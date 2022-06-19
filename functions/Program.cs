using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    internal class Program
    {
        //task1
        static void FillArr(int [] Arr)
        {
            for (int i =0; i < Arr.Length; i++)
            {
                Console.WriteLine($"Enter The Student's Grade{i+1}");
                Arr[i] = int.Parse(Console.ReadLine());
            }
        }
        static (int, float) GradeSumAndAvg(int [] Arr)
        {
            int sum = 0;
            float avg = 0;
            for(int i =0; i < Arr.Length; i++)
            {
                sum = sum + Arr[i];
            }
            avg = sum / Arr.Length;
            if (sum < 50)
            {
                Console.WriteLine("You Are Fail");
            }
            else
            {
                Console.WriteLine("Congratulations");
            }
            return (sum, avg); 
        }
        //task2 
        static void Fill2DArr(int [,] Arr)
        {
            for(int col =0; col < Arr.GetLength(1); col++)
            {
                for(int row = 0; row < Arr.GetLength(0); row++)
                {
                    Console.WriteLine($"Enter Grade {col+1} Student {row+1}");
                    Arr[row, col] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Pritn2DArr(int [,] Arr)
        {
            for (int row = 0; row < Arr.GetLength(0); row++)
            {
                for(int col =0; col < Arr.GetLength(1); col++)
                {
                    Console.WriteLine($" Student {row + 1} Grade {col + 1}");
                    Console.WriteLine(Arr[row, col]);
                }
            }
        }
        static int GradesSum(int [,] Arr)
        {
            Console.WriteLine("The Sum of The Grades :");
            int sum = 0;
            for(int row = 0; row < Arr.GetLength(0); row++)
            {
                for(int col = 0; col < Arr.GetLength(1); col++)
                {
                    sum = sum + Arr[row,col];
                    Console.WriteLine($" grades sum of stedent {row +1 } is {sum}");
                }
                شرط 
                    صفر السم
            }
            Console.WriteLine("the total sum is :");
            return sum;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("---------------task1----------------");
            //Console.WriteLine("Enrer The number of Subjects");
            //int num_sub = int.Parse(Console.ReadLine());
            //int [] GradesArr = new int[num_sub];
            //FillArr(GradesArr);
            //(int, float) result  = GradeSumAndAvg(GradesArr);
            //Console.WriteLine(result);
            Console.WriteLine("----------------task2----------------");
            Console.WriteLine("Enter Number of Students ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of Sbjects ");
            int cols = int.Parse(Console.ReadLine());
            int[,] Students = new int[rows, cols];
            Fill2DArr(Students);
            Pritn2DArr(Students);
            Console.WriteLine("----------------task3------------------");
            int stu_score = GradesSum(Students);
            Console.WriteLine(stu_score);
            Console.ReadLine();
        }
    }
}
