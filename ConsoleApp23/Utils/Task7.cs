using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task7 : IPrintOfSolution
    {
        double m, y;

        public Task7(double m, double y)
        {
            this.m = m;
            this.y = y;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"N = {(Math.Pow(m, 2) + 2.8 * m + 0.355) / (Math.Cos(2) * y + 3.6)}");
        }
    }
}
