using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task4 : IPrintOfSolution
    {
        double w, y;

        public Task4(double w, double y)
        {
            this.w = w;
            this.y = y;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"G = {9.33 * (Math.Pow(w, 3) + Math.Sqrt(w)) / (Math.Log(y + 3.5) + Math.Sqrt(y))}");
        }
    }
}
