using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task28 : IPrintOfSolution
    {
        double v, y, e;

        public Task28(double v, double y, double e)
        {
            this.v = v;
            this.y = y;
            this.e = e;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"W = {(0.004 * v + Math.Pow(e, 2 * y)) / (Math.Pow(e, y / 2))}");
        }
    }
}
