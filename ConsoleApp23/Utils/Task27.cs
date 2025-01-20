using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task27 : IPrintOfSolution
    {
        double p, y;

        public Task27(double p, double y)
        {
            this.p = p;
            this.y = y;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"Z = {Math.Sin(Math.Pow((p + 0.4), 2)) / (Math.Pow(y, 2) + 7.325 * p)}");
        }
    }
}
