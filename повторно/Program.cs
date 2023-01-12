using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void GetParamsTriangle(double a, double b, double c, out double s, out double p)
        {
            p = (a + b + c) / 2;
            s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины всех трех сторон первого треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double s1;
            double p1;
            GetParamsTriangle(a1, b1, c1, out s1, out p1);
            Console.WriteLine("Площадь и полупериметр первого треугольника соответственно будут равны:");
            Console.WriteLine("{0:0.00} {1}", s1, p1);

            Console.WriteLine("Введите длины всех трех сторон второго треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double s2;
            double p2;
            GetParamsTriangle(a2, b2, c2, out s2, out p2);
            Console.WriteLine("Площадь и полупериметр второго треугольника соответственно будут равны:");
            Console.WriteLine("{0:0.00} {1}", s2, p2);

            if (s1 > s2)
                Console.WriteLine("Площадь первого треугольника больше площади второго");
            else if (s1 < s2)
                Console.WriteLine("Площадь второго треугольника больше площади первого");
            else
                Console.WriteLine("Площади треугольников равны");
        }
    }
}
