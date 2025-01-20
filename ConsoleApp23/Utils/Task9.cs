using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task9 : IPrintOfSolution
    {
        double y, w;

        public Task9(double y, double w)
        {
            this.y = y;
            this.w = w;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"V = {(Math.Pow(y + 2 * w, 3)) / (Math.Log(y + 0.75))}");
        }
    }
}
