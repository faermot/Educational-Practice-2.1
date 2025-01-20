using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task15 : IPrintOfSolution
    {
        double y, j;

        public Task15(double y, double j)
        {
            this.y = y;
            this.j = j;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"F = {(2 * Math.Sin(0.354 * y + 1)) / (Math.Log(y + 2 * j))}");
        }
    }
}
