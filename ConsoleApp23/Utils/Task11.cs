using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task11 : IPrintOfSolution
    {
        double y, n;

        public Task11(double y, double n)
        {
            this.y = y;
            this.n = n;
        }
        public void PrintSolution()
        {
            Console.WriteLine($"D = {Math.Pow(y, 2) + (0.5 * n + 4.8) / (Math.Sin(y))}");
        }
    }
}
