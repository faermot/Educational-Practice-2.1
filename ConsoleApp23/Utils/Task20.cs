using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task20 : IPrintOfSolution
    {
        double t, l, y, e;

        public Task20(double t, double l, double y, double e)
        {
            this.t = t;
            this.l = l;
            this.y = y;
            this.e = e;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"K = {(2 * Math.Pow(t, 2) + 3 * l + 7.2) / (Math.Log(y + Math.Pow(e, 2 * t)))}");
        }
    }
}
