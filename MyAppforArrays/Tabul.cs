using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabulClassApp
{
    internal class Tabul
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;
        private double f1(double x)
        {
            return Math.Pow(Math.Abs(x), Math.Sin(x)) + Math.Sin(x);
        }
        private double f2(double x)
        {
            return Math.Pow(3, x + 3) + 2 * x;
        }
        private double f3(double x)
        {
            return Math.Pow(2, x) + Math.Sin(Math.PI * x);
        }
        public void tab(double xn = -3.9, double xk = 18.7, double h = 0.1, double a = 0.23)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else
                {
                    if ((x >= 0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else
                    {
                        y = f3(x);
                    }
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x += h;
                i++;
            }
            n = i;
        }
    }
}