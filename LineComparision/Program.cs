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
            Program.CalculateLength();
                
        }
        public static void CalculateLength()
        {

            Console.WriteLine("Enter the value of x1 :");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y1 :");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double val1 = Math.Pow((x2 - x1), 2);
            double val2 = Math.Pow((y2 - y1), 2);
            double res = Math.Sqrt(val1 + val2);
            Console.WriteLine("The length of a Line is :" + res);

        }

    }
}
