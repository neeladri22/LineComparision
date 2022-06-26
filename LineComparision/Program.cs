using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.TwoLinesComparison();

        }
        public static void TwoLinesComparison()
        {
            Console.WriteLine("Enter the value of x1 :");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y1 :");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of x3 :");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y3 :");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of x4:");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y4:");
            double y4 = Convert.ToDouble(Console.ReadLine());

            double a = Math.Pow((x2 - x1), 2);
            double b = Math.Pow((y2 - y1), 2);
            double result1 = Math.Sqrt(a + b);

            double c = Math.Pow((x4 - x3), 2);
            double d = Math.Pow((y4 - y3), 2);
            double result2 = Math.Sqrt(a + b);

            if (result1 == result2)
            {
                Console.WriteLine("Line-A and Line-B are equal length");
            }
            else
            {
                Console.WriteLine("LineA and LineB are not equal length");
            }


        }
    }
}