using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_1._1
{
    internal class Program
    {

        // спосіб 1: розгалуження в скороченій формі
        static double if1(double x)
        {
            double B = 0;

            if (x <= -1)
                B = 3 + Math.Sin(Math.Abs(x));
            if (-1 < x && x <= 3)
                B = 2 * Math.Exp(x / 4 - 1);
            if (x > 3)
                B = 7 - Math.Sqrt(2) * Math.Pow(x, 3);
            
            return B;
        }
        static double if2(double x)
        {
            double B = 0;

            if (x <= -1)
                B = 3 + Math.Sin(Math.Abs(x));
            else
        if (-1 < x && x <= 3)
                B = 2 * Math.Exp(x / 4 - 1);
            else
                B = 7 - Math.Sqrt(2) * Math.Pow(x, 3);

            return B;
        }
        static void Main(string[] args)
        {
            double x; // вхідний параметр
            double y; // результат обчислення виразу
            double A; // проміжні результат
         
            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());

            A = 5 * Math.Exp(3 *x );
            y = A - if1(x);
            Console.WriteLine($"y1 = {y}");
            y = A - if2(x);
            Console.WriteLine($"y2 = {y}");

            Console.ReadKey();
        }
    }
}
