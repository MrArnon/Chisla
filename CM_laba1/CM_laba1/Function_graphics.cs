using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_laba1
{
    class Function_graphics
    {
        public int a { get; set; }
       public int b { get; set; }
        public double h { get; set; }
        public int n { get; set; }
        public int m { get; set; }
        public Function_graphics()
        {
            a = -1;
            b = 1;
            m = 10;
            h = 1;
            n = -1;

        }
        public double func(double x)
        {
            double f;
            f = Math.Sqrt(3 + Math.Pow(x, 2)) / Math.Sqrt(5 + 7 * Math.Pow(x, 2));
            return f;
        }
        public void H()
        {
            h= (b - a) / n; 
        }
        public double Polin(double x, double h)
        {
            double sum = 0.0, pr1, pr2;
            for (double i = a; i <= b; i += h)
            {
                pr1 = 1.0;
                pr2 = 1.0;
                for (double j = a; j <= b; j += h)
                {
                    if (i != j)
                    {

                        pr1 *= (x - j);
                        pr2 *= (i - j);
                    }
                }
                sum = sum + func(i) * (double)(pr1 / pr2);
            }
            return sum;
        }
    }
}
