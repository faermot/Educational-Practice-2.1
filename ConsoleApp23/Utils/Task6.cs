using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task6 : IPrintOfSolution
    {
        double i, y;

        public Task6(double i, double y)
        {
            this.i = i;
            this.y = y;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"L = {(0.81 * Math.Cos(i)) / (Math.Log(y) + 2 * Math.Pow(2, i))}");
        }
    }
}
