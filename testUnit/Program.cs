using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUnit
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f3}",cosh(x));
            Console.ReadKey();
        }
        public static double cosh(double x)
        {
            double y = 1;
            int n = 1;
            double res;
            do
            {
                res = Math.Pow(x, 2*n) / Fact(2*n);
                y += res;
                n++;
            }
            while (res>0.001);
            return y;
        }

        static long Fact(int n)
        {
            long F = 1;
            for(int i=1;i<=n;i++)
            {
                F *= i;
            }
            return F;
        }
    }
}
