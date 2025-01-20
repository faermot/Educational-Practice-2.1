using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task29 : IPrintOfSolution
    {
        double h, y, e;

        public Task29(double h, double y, double e)
        {
            this.h = h;
            this.y = y;
            this.e = e;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"T = {(0.355 * Math.Pow(h, 2) - 4.355) / (Math.Pow(e, y + h) + Math.Sqrt(2.7 * y))}");
        }
    }
}
