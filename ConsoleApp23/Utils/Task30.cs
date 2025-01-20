using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task30 : IPrintOfSolution
    {
        double p, y, e;

        public Task30(double p, double y, double e)
        {
            this.p = p;
            this.y = y;
            this.e = e;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"N = {(3 * Math.Pow(y, 2) + Math.Sqrt(y + 1)) / (Math.Log(p + y) + Math.Pow(e, p))}");
        }
    }
}
