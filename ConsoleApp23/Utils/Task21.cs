using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task21 : IPrintOfSolution
    {
        double k, p, x, d;

        public Task21(double k, double p, double x, double d)
        {
            this.k = k;
            this.p = p;
            this.x = x;
            this.d = d;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"Q = {(Math.Sqrt(k + 2.6 * p * Math.Sin(k))) / (x - Math.Pow(d, 3))}");
        }
    }
}
