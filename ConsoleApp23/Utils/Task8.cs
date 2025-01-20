using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task8 : IPrintOfSolution
    {
        double t, y;

        public Task8(double t, double y)
        {
            this.t = t;
            this.y = y;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"T = {(2.37 * Math.Sin(t + 1)) / (Math.Sqrt(4 * Math.Pow(y, 2) - 0.1 * y + 5))}");
        }
    }
}
