using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task17 : IPrintOfSolution
    {
        double y, n;

        public Task17(double y, double n)
        {
            this.y = y;
            this.n = n;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"H = {(Math.Pow(y, 2) - 0.8 * y + Math.Sqrt(y)) / (23.1 * Math.Pow(n, 2) + Math.Cos(n))}");
        }
    }
}
