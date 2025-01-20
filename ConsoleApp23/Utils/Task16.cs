using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task16 : IPrintOfSolution
    {
        double t, e, r, y;

        public Task16(double t, double e, double r, double y)
        {
            this.t = t;
            this.e = e;
            this.r = r;
            this.y = y;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"W = {(4 * Math.Pow(t, 3) + Math.Log(r)) / Math.Pow(e, (y + r)) + 7.2 * Math.Sin(r)}");
        }
    }
}
