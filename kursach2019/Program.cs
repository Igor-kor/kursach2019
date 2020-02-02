using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach2019
{
    class Program
    {
        static void Main(string[] args)
        {
            double xstart, xfinish, d, e;
            double f = 0, sum = 0;
            Console.WriteLine("Х Начальное = ");
            xstart = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Х Конечное = ");
            xfinish = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("D шаг = ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("E Точность = ");
            e = Convert.ToDouble(Console.ReadLine());

            for (double x = xstart; x <= xfinish; x += d)
            {
          
                for (int n = 0; n < e; n++)
                {
                    sum += 1 / ((2 * n + 1) * Math.Pow(x, 2 * n + 1));
                }
                f = 2 * sum;
                Console.WriteLine("при х =  {0:E} ,F(x) = {1:E}", x,f);
                sum = 0;
            }

            Console.ReadKey();
        }
    }
}
