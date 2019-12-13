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
            int xstart, xfinish, d, e;
            double f = 0, sum = 0;
            Console.WriteLine("Х Начальное = ");
            xstart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Х Конечное = ");
            xfinish = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("D шаг = ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("E Точность = ");
            e = Convert.ToInt32(Console.ReadLine());

            for (int x = xstart; x < xfinish; x += d)
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
