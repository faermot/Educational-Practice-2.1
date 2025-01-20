using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task2 : IPrintOfSolution
    {
        double d, y;

        public Task2(double d, double y)
        {
            this.d = d;
            this.y = y;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"F = {Math.Log(d) + 3.5 * (Math.Pow(d, 2) + 1) / (Math.Cos(2 * y))}");
        }
    }
}
