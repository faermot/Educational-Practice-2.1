using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task5 : IPrintOfSolution
    {
        double e, y, a, t;

        public Task5(double e, double y, double a, double t)
        {
            this.e = e;
            this.y = y;
            this.a = a;
            this.t = t;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"D = {(7.8 * Math.Pow(a, 2) + 3.52 * t) / (Math.Log(a + (2 * y)) + Math.Pow(e, y))}");
        }
    }
}
