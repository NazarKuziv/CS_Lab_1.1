using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_1._1
{
    internal class Program
    {

        static double if1(double x)
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

            A = 5 * Math.Pow(Math.Exp(x),3);
            y = A - if1(x);
            Console.WriteLine($"y1 = {Math.Round(y, 2)}");
            

            Console.ReadKey();
        }
    }
}
